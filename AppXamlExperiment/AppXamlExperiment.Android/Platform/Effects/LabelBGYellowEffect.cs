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
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Android.Graphics;
using AppXamlExperiment.Droid.Platform.Effects;

[assembly: ResolutionGroupName("EffectsSample")]
[assembly: ExportEffect(typeof(LabelBGYellowEffect), "LabelBGYellowEffect")]
namespace AppXamlExperiment.Droid.Platform.Effects
{
    public class LabelBGYellowEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            try
            {
                var label = (TextView)Control;
                label.SetBackgroundColor(Android.Graphics.Color.Yellow);
            }
            catch (Exception ex)
            {

            }
        }
        protected override void OnDetached()
        {
            throw new NotImplementedException();
        }
    }
}