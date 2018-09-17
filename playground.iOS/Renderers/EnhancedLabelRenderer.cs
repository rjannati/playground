using System;
using System.ComponentModel;
using playground.Controls;
using playground.iOS.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using UIKit;
using Foundation;

[assembly: ExportRenderer(typeof(EnhancedLabel), typeof(EnhancedLabelRenderer))]
namespace playground.iOS.Renderers
{
    public class EnhancedLabelRenderer : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                var enhancedLabel = e.NewElement as EnhancedLabel;
                UpdateLineHeight(enhancedLabel.LineHeight);
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
                UpdateLineHeight(enhancedLabel.LineHeight);
            }
        }

        void UpdateLineHeight(float lineHeight)
        {
            if (Control != null)
            {
                Control.Lines = 0;
                var text = Control.AttributedText;
                if (text != null)
                {
                    var textRange = new NSRange(0, text.Length);

                    var updatedAttributedText = new NSMutableAttributedString(Control.AttributedText);
                    updatedAttributedText.AddAttribute(UIStringAttributeKey.ParagraphStyle,
                                             new NSMutableParagraphStyle()
                                             {
                                                 LineHeightMultiple = lineHeight
                                             }, textRange);

                    Control.AttributedText = updatedAttributedText;
                }
            }
        }
    }
}
