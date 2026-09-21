namespace PlatiniumUI.Fluent.Themes;

/// <summary>
/// Fluent Design System typography based on Microsoft Fluent Design principles
/// Uses Segoe UI variable font family (or system fallbacks)
/// </summary>
public static class FluentTypography
{
    // Font families - Segoe UI Variable is the Fluent Design font
    public static readonly string FontFamilyPrimary = "Segoe UI Variable, Segoe UI, Roboto, Helvetica Neue, sans-serif";
    public static readonly string FontFamilyMono = "Cascadia Code, Consolas, Courier New, monospace";
    
    // Font weights (Fluent uses specific weight values)
    public const int FontWeightRegular = 400;
    public const int FontWeightMedium = 500;
    public const int FontWeightSemiBold = 600;
    public const int FontWeightBold = 700;
    
    // Font sizes (in device-independent pixels)
    public const double FontSizeCaption = 12.0;
    public const double FontSizeBody2 = 14.0;
    public const double FontSizeBody1 = 16.0;
    public const double FontSizeTitle3 = 18.0;
    public const double FontSizeTitle2 = 20.0;
    public const double FontSizeTitle1 = 24.0;
    public const double FontSizeSubtitle = 28.0;
    public const double FontSizeHeading = 34.0;
    public const double FontSizeDisplay = 40.0;
    public const double FontSizeLargeTitle = 60.0;
    
    // Line heights (multipliers)
    public const double LineHeightTight = 1.25;
    public const double LineHeightNormal = 1.5;
    public const double LineHeightRelaxed = 1.75;
    
    // Letter spacing
    public const double LetterSpacingTight = -0.5;
    public const double LetterSpacingNormal = 0.0;
    public const double LetterSpacingWide = 0.5;
}
