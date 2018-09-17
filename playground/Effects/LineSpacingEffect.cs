using Xamarin.Forms;

namespace playground.Effects
{
    public class LineSpacingEffect : RoutingEffect
    {
        public float LineSpacing { get; set; }

        public LineSpacingEffect() : base ("Playground.LineSpacingEffect")
        {
        }
    }
}
