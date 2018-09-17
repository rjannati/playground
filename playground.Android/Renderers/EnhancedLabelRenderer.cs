using System.ComponentModel;
using Android.Content;
using playground.Controls;
using playground.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(EnhancedLabel), typeof(EnhancedLabelRenderer))]
namespace playground.Droid.Renderers
{
    public class EnhancedLabelRenderer : LabelRenderer
    {
        public EnhancedLabelRenderer(Context context) : base(context) { }

        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
            if (e.NewElement != null)
            {
                var enhancedLabel = (EnhancedLabel)Element;
                Control.SetLineSpacing(0f, enhancedLabel.LineHeight);
            }
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName == EnhancedLabel.LineHeightProperty.PropertyName ||
                e.PropertyName == Label.TextProperty.PropertyName ||
                e.PropertyName == Label.FormattedTextProperty.PropertyName ||
                e.PropertyName == Label.FontProperty.PropertyName ||
                e.PropertyName == Label.FontFamilyProperty.PropertyName ||
                e.PropertyName == Label.FontAttributesProperty.PropertyName ||
                e.PropertyName == Label.FontSizeProperty.PropertyName)
            {
                var enhancedLabel = Element as EnhancedLabel;
                Control.SetLineSpacing(0f, enhancedLabel.LineHeight);
            }
        }

    }
}