using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CustomFlip.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AnimationButton : ContentView
    {
        public AnimationButton()
        {
            InitializeComponent();
        }

        private bool _isAnimatin = false;
        private void Animation()
        {
            Task.Run(async () =>
            {
                while (_isAnimatin)
                {
                    await button.ScaleTo(1.5, 500);
                    await button.ScaleTo(1, 500);
                }
                button.CancelAnimations();
            });
        }

        public static readonly BindableProperty IsEnableAnimationProperty = BindableProperty.Create(
            nameof(IsEnableAnimation),
            typeof(bool),
            typeof(AnimationButton),
            defaultValue:false,
            propertyChanging: OnIsEnableAnimationChanging);

        private static void OnIsEnableAnimationChanging(BindableObject bindable, object oldValue, object newValue)
        {
            bool nValue = (bool)newValue;
            if(!(bindable is AnimationButton))
            {
                return;
            }
            var animBtn = (AnimationButton)bindable;
           
            if (!nValue)
            {
                //animBtn.button.CancelAnimations();
                return;
            }
            animBtn.Animation();


        }

        public bool IsEnableAnimation
        {
            get=>(bool)GetValue(IsEnableAnimationProperty);
            set=>SetValue(IsEnableAnimationProperty, (_isAnimatin = value));
        }
    }
}