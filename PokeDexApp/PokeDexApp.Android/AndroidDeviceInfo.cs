using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using PokeDexApp.Droid;
using Xamarin.Forms; // phải thêm vào

[assembly: Dependency(typeof(AndroidDeviceInfo))] // phải thêm vào
namespace PokeDexApp.Droid
{
    public class AndroidDeviceInfo : IDeviceInfo
    {
        public string GetPlatform()
        {
            //Run native android code
            return "Welcome to Android!";
        }
    }
}