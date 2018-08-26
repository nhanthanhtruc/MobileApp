using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PokeDexApp.CodeLogics
{
    class Check
    {
        public static async Task<bool> CheckPermissions(Permission permission)
        {
            var permissionStatus = await CrossPermissions.Current.CheckPermissionStatusAsync(permission);
            var request = false;
            if (permissionStatus == PermissionStatus.Denied)
            {
                if (Device.RuntimePlatform == Device.iOS)
                {
                    var title = $"{permission} Permission";
                    var question =
                        $"To use this plugin the {permission} permission is required. Please go into Settings and turn on {permission} for the app.";
                    var positive = "Settings";
                    var negative = "Maybe Later";
                    var task = Application.Current?.MainPage?.DisplayAlert(title, question, positive, negative);

                    if (task == null) return false;

                    var result = await task;
                    if (result) CrossPermissions.Current.OpenAppSettings();

                    return false;
                }

                request = true;
            }

            if (request || permissionStatus != PermissionStatus.Granted)
            {
                var shouldShowRequestPermission = await CrossPermissions.Current.ShouldShowRequestPermissionRationaleAsync(permission);
                if (shouldShowRequestPermission)
                {
                    var newStatus = await CrossPermissions.Current.RequestPermissionsAsync(permission);
                    if (newStatus.ContainsKey(permission) && newStatus[permission] != PermissionStatus.Granted)
                    {
                        var title = $"{permission} Permission";
                        var question = $"To use the plugin the {permission} permission is required.";
                        var positive = "Settings";
                        var negative = "Maybe Later";
                        var task = Application.Current?.MainPage?.DisplayAlert(title, question, positive, negative);
                        if (task == null) return false;

                        var result = await task;
                        if (result) CrossPermissions.Current.OpenAppSettings();

                        return false;
                    }
                }
                else
                {
                    return true;
                }
            }

            return true;
        }
    }
}
