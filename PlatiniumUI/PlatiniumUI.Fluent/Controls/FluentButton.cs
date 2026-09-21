using PlatiniumUI.Fluent.Themes;

namespace PlatiniumUI.Fluent.Controls;

/// <summary>
/// Fluent Design Button control
/// A modern button following Microsoft Fluent Design principles with smooth animations and proper states
/// </summary>
public class FluentButton : Button
{
    public static readonly BindableProperty CornerRadiusProperty = BindableProperty.Create(
        nameof(CornerRadius), typeof(double), typeof(FluentButton), FluentSpacing.RadiusLarge);

    public static readonly BindableProperty ElevationProperty = BindableProperty.Create(
        nameof(Elevation), typeof(double), typeof(FluentButton), FluentSpacing.Elevation2);

    public static readonly BindableProperty IsLoadingProperty = BindableProperty.Create(
        nameof(IsLoading), typeof(bool), typeof(FluentButton), false,
        propertyChanged: OnIsLoadingChanged);

    public static readonly BindableProperty ButtonTypeProperty = BindableProperty.Create(
        nameof(ButtonType), typeof(FluentButtonType), typeof(FluentButton), FluentButtonType.Primary);

    private bool _isPressed;
    private Color _originalBackgroundColor;
    private Color _originalTextColor;

    public new double CornerRadius
    {
        get => (double)GetValue(CornerRadiusProperty);
        set => SetValue(CornerRadiusProperty, value);
    }

    public double Elevation
    {
        get => (double)GetValue(ElevationProperty);
        set => SetValue(ElevationProperty, value);
    }

    public bool IsLoading
    {
        get => (bool)GetValue(IsLoadingProperty);
        set => SetValue(IsLoadingProperty, value);
    }

    public FluentButtonType ButtonType
    {
        get => (FluentButtonType)GetValue(ButtonTypeProperty);
        set => SetValue(ButtonTypeProperty, value);
    }

    public FluentButton()
    {
        ApplyFluentStyle();
        SetupInteractivity();
    }

    private void ApplyFluentStyle()
    {
        // Set default properties based on Fluent Design
        FontFamily = FluentTypography.FontFamilyPrimary;
        FontSize = FluentTypography.FontSizeBody1;
        FontAttributes = FontAttributes.None;
        Padding = new Thickness(FluentSpacing.Md, FluentSpacing.S);
        MinimumHeightRequest = FluentSpacing.ControlHeightMedium;

        ApplyButtonTypeStyle();
    }

    private void ApplyButtonTypeStyle()
    {
        switch (ButtonType)
        {
            case FluentButtonType.Primary:
                BackgroundColor = FluentColors.Primary;
                TextColor = FluentColors.TextOnPrimary;
                BorderColor = Colors.Transparent;
                BorderWidth = 0;
                break;

            case FluentButtonType.Secondary:
                BackgroundColor = FluentColors.BackgroundSecondary;
                TextColor = FluentColors.TextPrimary;
                BorderColor = FluentColors.BorderDefault;
                BorderWidth = 1;
                break;

            case FluentButtonType.Outline:
                BackgroundColor = Colors.Transparent;
                TextColor = FluentColors.Primary;
                BorderColor = FluentColors.Primary;
                BorderWidth = 1;
                break;

            case FluentButtonType.Text:
                BackgroundColor = Colors.Transparent;
                TextColor = FluentColors.Primary;
                BorderColor = Colors.Transparent;
                BorderWidth = 0;
                Padding = new Thickness(FluentSpacing.S, FluentSpacing.Xs);
                break;
        }

        _originalBackgroundColor = BackgroundColor;
        _originalTextColor = TextColor;
    }

    private void SetupInteractivity()
    {
        Pressed += OnPressed;
        Released += OnReleased;
    }

    private void OnPressed(object? sender, EventArgs e)
    {
        _isPressed = true;
        AnimatePress();
    }

    private void OnReleased(object? sender, EventArgs e)
    {
        _isPressed = false;
        AnimateRelease();
    }

    private void AnimatePress()
    {
        var targetBg = ButtonType == FluentButtonType.Primary
            ? FluentColors.PrimaryDark
            : FluentColors.NeutralLight;

        this.Animate("Press", new Animation(d =>
        {
            var color = MixColors(_originalBackgroundColor, targetBg, d);
            BackgroundColor = color;
        }, 0, 1), length: 100, easing: Easing.CubicOut);
    }

    private void AnimateRelease()
    {
        this.Animate("Release", new Animation(d =>
        {
            var color = MixColors(ButtonType == FluentButtonType.Primary ? FluentColors.PrimaryDark : FluentColors.NeutralLight, _originalBackgroundColor, d);
            BackgroundColor = color;
        }, 0, 1), length: 200, easing: Easing.CubicOut);
    }

    private static void OnIsLoadingChanged(BindableObject bindable, object oldValue, object newValue)
    {
        if (bindable is FluentButton button)
        {
            button.UpdateLoadingState();
        }
    }

    private void UpdateLoadingState()
    {
        if (IsLoading)
        {
            Opacity = 0.7;
            InputTransparent = true;
        }
        else
        {
            Opacity = 1;
            InputTransparent = false;
        }
    }

    private static Color MixColors(Color color1, Color color2, double ratio)
    {
        return Color.FromRgb(
            (byte)(color1.Red * (1 - ratio) + color2.Red * ratio),
            (byte)(color1.Green * (1 - ratio) + color2.Green * ratio),
            (byte)(color1.Blue * (1 - ratio) + color2.Blue * ratio));
    }
}

public enum FluentButtonType
{
    Primary,
    Secondary,
    Outline,
    Text
}
