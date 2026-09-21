namespace PlatiniumUI.Fluent.Themes;

/// <summary>
/// Fluent Design System color palette based on Microsoft Fluent Design principles
/// Primary accent color: #F26522 (Platinum Orange)
/// </summary>
public static class FluentColors
{
    // Primary Brand Color - Platinum Orange
    public static readonly Color Primary = Color.FromArgb("#F26522");
    
    // Primary variants
    public static readonly Color PrimaryLight = Color.FromArgb("#FF8A4D");
    public static readonly Color PrimaryDark = Color.FromArgb("#CC551B");
    public static readonly Color PrimaryTint = Color.FromArgb("#FFF0E6");
    
    // Neutral colors (Fluent Design grays)
    public static readonly Color NeutralLightest = Color.FromArgb("#FAFAFA");
    public static readonly Color NeutralLighter = Color.FromArgb("#F3F3F3");
    public static readonly Color NeutralLight = Color.FromArgb("#E0E0E0");
    public static readonly Color NeutralGray = Color.FromArgb("#8A8A8A");
    public static readonly Color NeutralDark = Color.FromArgb("#606060");
    public static readonly Color NeutralDarker = Color.FromArgb("#323232");
    public static readonly Color NeutralDarkest = Color.FromArgb("#202020");
    public static readonly Color NeutralBlack = Color.FromArgb("#000000");
    
    // Text colors
    public static readonly Color TextPrimary = Color.FromArgb("#242424");
    public static readonly Color TextSecondary = Color.FromArgb("#606060");
    public static readonly Color TextTertiary = Color.FromArgb("#8A8A8A");
    public static readonly Color TextOnPrimary = Color.FromArgb("#FFFFFF");
    
    // Background colors
    public static readonly Color BackgroundPrimary = Color.FromArgb("#FFFFFF");
    public static readonly Color BackgroundSecondary = Color.FromArgb("#FAFAFA");
    public static readonly Color BackgroundTertiary = Color.FromArgb("#F3F3F3");
    public static readonly Color BackgroundCard = Color.FromArgb("#FFFFFF");
    
    // Border colors
    public static readonly Color BorderDefault = Color.FromArgb("#E0E0E0");
    public static readonly Color BorderSubtle = Color.FromArgb("#F0F0F0");
    public static readonly Color BorderStrong = Color.FromArgb("#C8C8C8");
    public static readonly Color BorderFocus = Primary;
    
    // State colors
    public static readonly Color Success = Color.FromArgb("#107C10");
    public static readonly Color SuccessLight = Color.FromArgb("#DFF6DD");
    public static readonly Color Warning = Color.FromArgb("#FFAA44");
    public static readonly Color WarningLight = Color.FromArgb("#FFF4CE");
    public static readonly Color Error = Color.FromArgb("#D13438");
    public static readonly Color ErrorLight = Color.FromArgb("#FDE7E9");
    public static readonly Color Info = Color.FromArgb("#0078D4");
    public static readonly Color InfoLight = Color.FromArgb("#DEECF9");
    
    // Acrylic/Elevation overlays
    public static readonly Color AcrylicLight = Color.FromArgb("#80FFFFFF");
    public static readonly Color AcrylicDark = Color.FromArgb("#80000000");
    
    // Shadow colors
    public static readonly Color ShadowLight = Color.FromArgb("#1A000000");
    public static readonly Color ShadowMedium = Color.FromArgb("#33000000");
    public static readonly Color ShadowDark = Color.FromArgb("#4D000000");
    
    // Hover and Press states
    public static readonly Color HoverOverlay = Color.FromArgb("#0A000000");
    public static readonly Color PressOverlay = Color.FromArgb("#14000000");
    public static readonly Color SelectedOverlay = Color.FromArgb("#0D000000");
    
    // Focus visual
    public static readonly Color FocusBorder = Primary;
    public static readonly Color FocusInnerBorder = Color.FromArgb("#FFFFFF");
}
