using System.Linq;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using RoutingEffects = playground.Effects;

[assembly: ExportEffect(typeof(playground.iOS.Effects.LineSpacingEffect), "LineSpacingEffect")]
namespace playground.iOS.Effects
{
    public class LineSpacingEffect : PlatformEffect
    {
        public double LineSpacing { get; set; }

        protected override void OnAttached()
        {
            try
            {
                if (!(Control is UILabel uiLabel))
                {
                    return;
                }

                //set line to multiple lines 
                uiLabel.Lines = 0;

                var effect = (RoutingEffects.LineSpacingEffect)Element.Effects.FirstOrDefault(f => f is RoutingEffects.LineSpacingEffect);
                var text = uiLabel.AttributedText;
                var textRange = new NSRange(0, text.Length);

                var updatedText = new NSMutableAttributedString(uiLabel.AttributedText);
                updatedText.AddAttribute(UIStringAttributeKey.ParagraphStyle,
                 new NSMutableParagraphStyle()
                 {
                     LineHeightMultiple = effect.LineSpacing
                 }, textRange);

                uiLabel.AttributedText = updatedText;
            }
            catch 
            {
                return;
            }

        }

        protected override void OnDetached()
        {
        }
    }
}
