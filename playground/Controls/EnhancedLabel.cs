using System;
using Xamarin.Forms;

namespace playground.Controls
{
    public class EnhancedLabel : Label
    {
        public static readonly BindableProperty LineHeightProperty =
            BindableProperty.Create("LineHeight", typeof(float), typeof(EnhancedLabel), 0.0f, defaultBindingMode: BindingMode.TwoWay);

        public float LineHeight
        {
            get { return (float)GetValue(LineHeightProperty); }
            set { SetValue(LineHeightProperty, value); }
        }
    }
}
