using Avalonia;
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Interactivity;
using Avalonia.Media;
using Avalonia.Styling;

namespace Panuon.UI.Silver
{
    public class ButtonHelper : AvaloniaObject
    {
        #region Properties

        #region Icon
        public static object GetIcon(Button button)
        {
            return (object)button.GetValue(IconProperty);
        }

        public static void SetIcon(Button button, object value)
        {
            button.SetValue(IconProperty, value);
        }

        public static readonly AttachedProperty<object> IconProperty = 
            AvaloniaProperty.RegisterAttached<ButtonHelper, Interactive, object>("Icon", default(object), false, BindingMode.OneWay);

        #endregion

        #region IconPlacement
        public static IconPlacement GetIconPlacement(Button button)
        {
            return (IconPlacement)button.GetValue(IconPlacementProperty);
        }

        public static void SetIconPlacement(Button button, IconPlacement value)
        {
            button.SetValue(IconPlacementProperty, value);
        }

        public static readonly AttachedProperty<IconPlacement> IconPlacementProperty =
            AvaloniaProperty.RegisterAttached<ButtonHelper, Interactive, IconPlacement>("IconPlacement", default(IconPlacement), false, BindingMode.OneWay);
        #endregion

        #region CornerRadius
        public static CornerRadius GetCornerRadius(Button button)
        {
            return (CornerRadius)button.GetValue(CornerRadiusProperty);
        }

        public static void SetCornerRadius(Button button, CornerRadius value)
        {
            button.SetValue(CornerRadiusProperty, value);
        }

        public static readonly AttachedProperty<CornerRadius> CornerRadiusProperty =
            AvaloniaProperty.RegisterAttached<ButtonHelper, Interactive, CornerRadius>("CornerRadius", default(CornerRadius), false, BindingMode.OneWay);
        #endregion

        #region IsPending
        public static bool GetIsPending(Button button)
        {
            return (bool)button.GetValue(IsPendingProperty);
        }

        public static void SetIsPending(Button button, bool value)
        {
            button.SetValue(IsPendingProperty, value);
        }

        public static readonly AttachedProperty<bool> IsPendingProperty =
            AvaloniaProperty.RegisterAttached<ButtonHelper, Interactive, bool>("IsPending", default(bool), false, BindingMode.OneWay);
        #endregion

        #region PendingSpinnerStyle
        public static Style GetPendingSpinnerStyle(Button button)
        {
            return (Style)button.GetValue(PendingSpinnerStyleProperty);
        }

        public static void SetPendingSpinnerStyle(Button button, Style value)
        {
            button.SetValue(PendingSpinnerStyleProperty, value);
        }

        public static readonly AttachedProperty<Style> PendingSpinnerStyleProperty =
            AvaloniaProperty.RegisterAttached<ButtonHelper, Interactive, Style>("PendingSpinnerStyle", default(Style), false, BindingMode.OneWay);
        #endregion

        #region ShadowColor
        public static Color? GetShadowColor(Button button)
        {
            return (Color?)button.GetValue(ShadowColorProperty);
        }

        public static void SetShadowColor(Button button, Color? value)
        {
            button.SetValue(ShadowColorProperty, value);
        }

        public static readonly AttachedProperty<Color?> ShadowColorProperty =
            AvaloniaProperty.RegisterAttached<ButtonHelper, Interactive, Color?>("ShadowColor", default(Color?), false, BindingMode.OneWay);
        #endregion

        #region ClickEffect
        public static ClickEffect GetClickEffect(Button button)
        {
            return (ClickEffect)button.GetValue(ClickEffectProperty);
        }

        public static void SetClickEffect(Button button, ClickEffect value)
        {
            button.SetValue(ClickEffectProperty, value);
        }

        public static readonly AttachedProperty<ClickEffect> ClickEffectProperty =
            AvaloniaProperty.RegisterAttached<ButtonHelper, Interactive, ClickEffect>("ClickEffect", default(ClickEffect), false, BindingMode.OneWay);
        #endregion

        #region HoverBackground
        public static Brush GetHoverBackground(Button button)
        {
            return (Brush)button.GetValue(HoverBackgroundProperty);
        }

        public static void SetHoverBackground(Button button, Brush value)
        {
            button.SetValue(HoverBackgroundProperty, value);
        }

        public static readonly AttachedProperty<Brush> HoverBackgroundProperty =
            AvaloniaProperty.RegisterAttached<ButtonHelper, Interactive, Brush>("HoverBackground", default(Brush), false, BindingMode.OneWay);
        #endregion

        #region HoverForeground
        public static Brush GetHoverForeground(Button button)
        {
            return (Brush)button.GetValue(HoverForegroundProperty);
        }

        public static void SetHoverForeground(Button button, Brush value)
        {
            button.SetValue(HoverForegroundProperty, value);
        }

        public static readonly AttachedProperty<Brush> HoverForegroundProperty =
            AvaloniaProperty.RegisterAttached<ButtonHelper, Interactive, Brush>("HoverForeground", default(Brush), false, BindingMode.OneWay);
        #endregion

        #region HoverBorderBrush
        public static Brush GetHoverBorderBrush(Button button)
        {
            return (Brush)button.GetValue(HoverBorderBrushProperty);
        }

        public static void SetHoverBorderBrush(Button button, Brush value)
        {
            button.SetValue(HoverBorderBrushProperty, value);
        }

        public static readonly AttachedProperty<Brush> HoverBorderBrushProperty =
            AvaloniaProperty.RegisterAttached<ButtonHelper, Interactive, Brush>("HoverBorderBrush", default(Brush), false, BindingMode.OneWay);
        #endregion

        #region ClickBackground
        public static Brush GetClickBackground(Button button)
        {
            return (Brush)button.GetValue(ClickBackgroundProperty);
        }

        public static void SetClickBackground(Button button, Brush value)
        {
            button.SetValue(ClickBackgroundProperty, value);
        }

        public static readonly AttachedProperty<Brush> ClickBackgroundProperty =
            AvaloniaProperty.RegisterAttached<ButtonHelper, Interactive, Brush>("ClickBackground", default(Brush), false, BindingMode.OneWay);
        #endregion

        #region ClickForeground
        public static Brush GetClickForeground(Button button)
        {
            return (Brush)button.GetValue(ClickForegroundProperty);
        }

        public static void SetClickForeground(Button button, Brush value)
        {
            button.SetValue(ClickForegroundProperty, value);
        }

        public static readonly AttachedProperty<Brush> ClickForegroundProperty =
            AvaloniaProperty.RegisterAttached<ButtonHelper, Interactive, Brush>("ClickForeground", default(Brush), false, BindingMode.OneWay);
        #endregion

        #region ClickBorderBrush
        public static Brush GetClickBorderBrush(Button button)
        {
            return (Brush)button.GetValue(ClickBorderBrushProperty);
        }

        public static void SetClickBorderBrush(Button button, Brush value)
        {
            button.SetValue(ClickBorderBrushProperty, value);
        }

        public static readonly AttachedProperty<Brush> ClickBorderBrushProperty =
            AvaloniaProperty.RegisterAttached<ButtonHelper, Interactive, Brush>("ClickBorderBrush", default(Brush), false, BindingMode.OneWay);
        #endregion

        #endregion
    }

}
