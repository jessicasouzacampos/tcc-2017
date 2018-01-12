
using Android.App;
using Android.Content;
using Android.Widget;
using Xamarin.Forms.Xaml;
using Xamarin.Forms;
using AppTCC2.CustomRenderer;
using Android.Graphics.Drawables;
using Xamarin.Forms.Platform.Android;
using System.Threading.Tasks;

namespace AppTCC2.Droid.CustomRenderer
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NativeAndroidCell : LinearLayout, INativeElementView
    {
        public TextView HeadingTextView { get; set; }
        public TextView SubheadingTextView { get; set; }
        public ImageView ImageView { get; set; }

        public NativeCell NativeCell { get; private set; }
        public Element Element => NativeCell;

        public NativeAndroidCell(Context context, NativeCell cell) : base(context)
        {
            NativeCell = cell;

            var view = (context as Activity).LayoutInflater.Inflate(Resource.Layout.NativeAndroidCell, null);
            HeadingTextView = view.FindViewById<TextView>(Resource.Id.HeadingText);
            SubheadingTextView = view.FindViewById<TextView>(Resource.Id.SubheadingText);
            ImageView = view.FindViewById<ImageView>(Resource.Id.Image);

            AddView(view);
        }

        public void UpdateCell(NativeCell cell)
        {
            HeadingTextView.Text = cell.Name;
            SubheadingTextView.Text = cell.Category;

            // Dispose of the old image
            if (ImageView.Drawable != null)
            {
                using (var image = ImageView.Drawable as BitmapDrawable)
                {
                    if (image != null)
                    {
                        if (image.Bitmap != null)
                        {
                            image.Bitmap.Dispose();
                        }
                    }
                }
            }

            SetImage(cell.ImageFilename);
        }

        public void SetImage(string filename)
        {
            if (!string.IsNullOrWhiteSpace(filename))
            {
                // Display new image
                Context.Resources.GetBitmapAsync(filename).ContinueWith((t) =>
                {
                    var bitmap = t.Result;
                    if (bitmap != null)
                    {
                        ImageView.SetImageBitmap(bitmap);
                        bitmap.Dispose();
                    }
                }, TaskScheduler.FromCurrentSynchronizationContext());
            }
            else
            {
                // Clear the image
                ImageView.SetImageBitmap(null);
            }
        }
    }
}