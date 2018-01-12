using Android.Views;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using AppTCC2.Controls;
using AppTCC2.Droid.Controls;

[assembly: ExportRenderer(typeof(MyEntry), typeof(MyEntryRenderer))]
namespace AppTCC2.Droid.Controls
{
    public class MyEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.SetBackgroundColor(global::Android.Graphics.Color.LightGreen);
            }
        }

        public override bool OnKeyLongPress(Keycode keyCode, KeyEvent e)
        {
            return base.OnKeyLongPress(keyCode, e);           
        }
    }
}