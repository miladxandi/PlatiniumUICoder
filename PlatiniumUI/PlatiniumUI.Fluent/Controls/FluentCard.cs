using PlatiniumUI.Fluent.Themes;

namespace PlatiniumUI.Fluent.Controls;

/// <summary>
/// Fluent Design Card control
/// A modern card container following Microsoft Fluent Design principles with elevation and smooth shadows
/// </summary>
public class FluentCard : Border
{
    public static readonly BindableProperty ElevationProperty = BindableProperty.Create(
        nameof(Elevation), typeof(double), typeof(FluentCard), FluentSpacing.Elevation2,
        propertyChanged: OnElevationChanged);

    public static readonly BindableProperty CornerRadiusProperty = BindableProperty.Create(
        nameof(CornerRadius), typeof(double), typeof(FluentCard), FluentSpacing.RadiusXl);

    public static readonly BindableProperty IsClickableProperty = BindableProperty.Create(
        nameof(IsClickable), typeof(bool), typeof(FluentCard), false);

    private double _currentElevation;

    public double Elevation
    {
        get => (double)GetValue(ElevationProperty);
        set => SetValue(ElevationProperty, value);
    }

    public double CornerRadius
    {
        get => (double)GetValue(CornerRadiusProperty);
        set => SetValue(CornerRadiusProperty, value);
    }

    public bool IsClickable
    {
        get => (bool)GetValue(IsClickableProperty);
        set => SetValue(IsClickableProperty, value);
    }

    public FluentCard()
    {
        ApplyFluentStyle();
        SetupInteractivity();
    }

    private void ApplyFluentStyle()
    {
        // Background
        Background = FluentColors.BackgroundCard;
        
        // Stroke (border)
        Stroke = FluentColors.BorderSubtle;
        StrokeThickness = 1;
        
        // Corner radius
        this.CornerRadius = CornerRadius;
        
        // Padding for content
        Content = new Grid
        {
            Padding = new Thickness(FluentSpacing.Md)
        };
        
        // Initial shadow
        UpdateShadow(Elevation);
        _currentElevation = Elevation;
    }

    private void SetupInteractivity()
    {
        if (IsClickable)
        {
            var gestureRecognizer = new TapGestureRecognizer();
            gestureRecognizer.Tapped += OnCardTapped;
            GestureRecognizers.Add(gestureRecognizer);
        }
    }

    private void OnCardTapped(object? sender, EventArgs e)
    {
        AnimatePress();
        Clicked?.Invoke(this, EventArgs.Empty);
    }

    private void AnimatePress()
    {
        // Quick press animation
        this.Animate("Press", new Animation(d =>
        {
            Scale = 1 - (d * 0.02);
        }, 0, 1), length: 100, easing: Easing.CubicOut, finished: (v, e) =>
        {
            this.Animate("Release", new Animation(d =>
            {
                Scale = (1 - 0.02) + (d * 0.02);
            }, 0, 1), length: 150, easing: Easing.CubicOut);
        });
    }

    private void AnimateElevation(double from, double to)
    {
        this.Animate("Elevation", new Animation(d =>
        {
            var currentElev = from + (to - from) * d;
            UpdateShadow(currentElev);
            _currentElevation = currentElev;
        }, 0, 1), length: 200, easing: Easing.CubicOut);
    }

    private void UpdateShadow(double elevation)
    {
        var shadowColor = elevation switch
        {
            <= 0 => Colors.Transparent,
            <= 2 => FluentColors.ShadowLight,
            <= 4 => FluentColors.ShadowMedium,
            <= 8 => FluentColors.ShadowMedium,
            <= 16 => FluentColors.ShadowDark,
            _ => FluentColors.ShadowDark
        };

        var offset = elevation / 4;

        Shadow = new Shadow
        {
            Brush = shadowColor,
            Offset = new Point((float)offset, (float)(offset * 1.5)),
            Radius = (float)elevation,
            Opacity = elevation > 0 ? 0.3f : 0f
        };
    }

    private static void OnElevationChanged(BindableObject bindable, object oldValue, object newValue)
    {
        if (bindable is FluentCard card)
        {
            card.AnimateElevation((double)oldValue, (double)newValue);
        }
    }

    public event EventHandler? Clicked;

    public void PerformClick()
    {
        if (IsClickable)
        {
            AnimatePress();
            Clicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
