using System.Linq;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using RoutingEffects = playground.Effects;


[assembly: ExportEffect(typeof(playground.Droid.Effects.LineSpacingEffect), "LineSpacingEffect")]
namespace playground.Droid.Effects
{
    public class LineSpacingEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            try
            {
                if (Control is TextView textView)
                {
                    var effect = (RoutingEffects.LineSpacingEffect)Element.Effects.FirstOrDefault(f => f is RoutingEffects.LineSpacingEffect);
                    textView.SetLineSpacing(0, effect.LineSpacing);
                }
            }
            catch 
            {
                return;
            }
        }

        protected override void OnDetached()
        {
            return;
        }
    }
}
