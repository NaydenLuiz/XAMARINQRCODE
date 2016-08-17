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
using AppQR;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using AppQR.Droid;
using ZXing;
[assembly: ExportRenderer(typeof(MainPage), typeof(ActivityQR))]
namespace AppQR.Droid
{
   
    public class ActivityQR : PageRenderer
    {
       public ActivityQR()
        {
            var activity = this.Context as Activity;
            

            ///scanPage.OnScanResult += (result) => {
                // Stop scanning
             //   scanPage.IsScanning = false;

                // Pop the page and show the result
            //    Device.BeginInvokeOnMainThread(() => {
           //         Navigation.PopAsync();
           //         DisplayAlert("Scanned Barcode", result.Text, "OK");
          //      });
          //  };
            //activity.StartActivity(activity);
        }
    }
}