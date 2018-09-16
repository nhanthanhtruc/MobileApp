using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using PokeDexApp.iOS;
using UIKit;
using Xamarin.Forms; // phải thêm vào

[assembly: Dependency(typeof(iOsDeviceInfo))]// phải thêm vào
namespace PokeDexApp.iOS
{
    public class iOsDeviceInfo : IDeviceInfo
    {
        public string GetPlatform()
        {
            return "Welcome to iOs!";
        }
    }
}