namespace PlatiniumUI.Fluent.Themes;

/// <summary>
/// Fluent Design System resource dictionary
/// Provides all colors, styles, and control templates for Fluent Design
/// </summary>
public class FluentResources : ResourceDictionary
{
    public FluentResources()
    {
        // Merge color resources
        MergeColorResources();
        
        // Merge typography resources
        MergeTypographyResources();
        
        // Merge spacing resources
        MergeSpacingResources();
        
        // Define control styles
        DefineControlStyles();
    }
    
    private void MergeColorResources()
    {
        // Primary colors
        this["FluentPrimary"] = FluentColors.Primary;
        this["FluentPrimaryLight"] = FluentColors.PrimaryLight;
        this["FluentPrimaryDark"] = FluentColors.PrimaryDark;
        this["FluentPrimaryTint"] = FluentColors.PrimaryTint;
        
        // Neutral colors
        this["FluentNeutralLightest"] = FluentColors.NeutralLightest;
        this["FluentNeutralLighter"] = FluentColors.NeutralLighter;
        this["FluentNeutralLight"] = FluentColors.NeutralLight;
        this["FluentNeutralGray"] = FluentColors.NeutralGray;
        this["FluentNeutralDark"] = FluentColors.NeutralDark;
        this["FluentNeutralDarker"] = FluentColors.NeutralDarker;
        this["FluentNeutralDarkest"] = FluentColors.NeutralDarkest;
        this["FluentNeutralBlack"] = FluentColors.NeutralBlack;
        
        // Text colors
        this["FluentTextPrimary"] = FluentColors.TextPrimary;
        this["FluentTextSecondary"] = FluentColors.TextSecondary;
        this["FluentTextTertiary"] = FluentColors.TextTertiary;
        this["FluentTextOnPrimary"] = FluentColors.TextOnPrimary;
        
        // Background colors
        this["FluentBackgroundPrimary"] = FluentColors.BackgroundPrimary;
        this["FluentBackgroundSecondary"] = FluentColors.BackgroundSecondary;
        this["FluentBackgroundTertiary"] = FluentColors.BackgroundTertiary;
        this["FluentBackgroundCard"] = FluentColors.BackgroundCard;
        
        // Border colors
        this["FluentBorderDefault"] = FluentColors.BorderDefault;
        this["FluentBorderSubtle"] = FluentColors.BorderSubtle;
        this["FluentBorderStrong"] = FluentColors.BorderStrong;
        this["FluentBorderFocus"] = FluentColors.BorderFocus;
        
        // State colors
        this["FluentSuccess"] = FluentColors.Success;
        this["FluentSuccessLight"] = FluentColors.SuccessLight;
        this["FluentWarning"] = FluentColors.Warning;
        this["FluentWarningLight"] = FluentColors.WarningLight;
        this["FluentError"] = FluentColors.Error;
        this["FluentErrorLight"] = FluentColors.ErrorLight;
        this["FluentInfo"] = FluentColors.Info;
        this["FluentInfoLight"] = FluentColors.InfoLight;
        
        // Shadow colors
        this["FluentShadowLight"] = FluentColors.ShadowLight;
        this["FluentShadowMedium"] = FluentColors.ShadowMedium;
        this["FluentShadowDark"] = FluentColors.ShadowDark;
    }
    
    private void MergeTypographyResources()
    {
        // Font sizes
        this["FluentFontSizeCaption"] = FluentTypography.FontSizeCaption;
        this["FluentFontSizeBody2"] = FluentTypography.FontSizeBody2;
        this["FluentFontSizeBody1"] = FluentTypography.FontSizeBody1;
        this["FluentFontSizeTitle3"] = FluentTypography.FontSizeTitle3;
        this["FluentFontSizeTitle2"] = FluentTypography.FontSizeTitle2;
        this["FluentFontSizeTitle1"] = FluentTypography.FontSizeTitle1;
        this["FluentFontSizeSubtitle"] = FluentTypography.FontSizeSubtitle;
        this["FluentFontSizeHeading"] = FluentTypography.FontSizeHeading;
        this["FluentFontSizeDisplay"] = FluentTypography.FontSizeDisplay;
        this["FluentFontSizeLargeTitle"] = FluentTypography.FontSizeLargeTitle;
        
        // Font weights
        this["FluentFontWeightRegular"] = Microsoft.Maui.FontWeight.Regular;
        this["FluentFontWeightMedium"] = Microsoft.Maui.FontWeight.Medium;
        this["FluentFontWeightSemiBold"] = (Microsoft.Maui.FontWeight)600;
        this["FluentFontWeightBold"] = Microsoft.Maui.FontWeight.Bold;
    }
    
    private void MergeSpacingResources()
    {
        // Spacing
        this["FluentSpacingXxs"] = FluentSpacing.Xxs;
        this["FluentSpacingXs"] = FluentSpacing.Xs;
        this["FluentSpacingS"] = FluentSpacing.S;
        this["FluentSpacingM"] = FluentSpacing.M;
        this["FluentSpacingMd"] = FluentSpacing.Md;
        this["FluentSpacingL"] = FluentSpacing.L;
        this["FluentSpacingXl"] = FluentSpacing.Xl;
        this["FluentSpacingXxl"] = FluentSpacing.Xxl;
        this["FluentSpacingXxxl"] = FluentSpacing.Xxxl;
        this["FluentSpacingHuge"] = FluentSpacing.Huge;
        this["FluentSpacingLarger"] = FluentSpacing.Larger;
        
        // Control heights
        this["FluentControlHeightSmall"] = FluentSpacing.ControlHeightSmall;
        this["FluentControlHeightMedium"] = FluentSpacing.ControlHeightMedium;
        this["FluentControlHeightLarge"] = FluentSpacing.ControlHeightLarge;
        
        // Border radius
        this["FluentRadiusNone"] = FluentSpacing.RadiusNone;
        this["FluentRadiusSmall"] = FluentSpacing.RadiusSmall;
        this["FluentRadiusMedium"] = FluentSpacing.RadiusMedium;
        this["FluentRadiusLarge"] = FluentSpacing.RadiusLarge;
        this["FluentRadiusXl"] = FluentSpacing.RadiusXl;
        this["FluentRadiusXxl"] = FluentSpacing.RadiusXxl;
        this["FluentRadiusFull"] = FluentSpacing.RadiusFull;
        
        // Elevation
        this["FluentElevation0"] = FluentSpacing.Elevation0;
        this["FluentElevation1"] = FluentSpacing.Elevation1;
        this["FluentElevation2"] = FluentSpacing.Elevation2;
        this["FluentElevation4"] = FluentSpacing.Elevation4;
        this["FluentElevation8"] = FluentSpacing.Elevation8;
        this["FluentElevation16"] = FluentSpacing.Elevation16;
        this["FluentElevation24"] = FluentSpacing.Elevation24;
    }
    
    private void DefineControlStyles()
    {
        // Base style for all Fluent controls
        this["FluentControlBaseStyle"] = new Style(typeof(View))
        {
            Setters =
            {
                new Setter
                {
                    Property = VisualElement.BackgroundColorProperty,
                    Value = FluentColors.BackgroundPrimary
                }
            }
        };
        
        // Default Button style will be defined in FluentButton
        // Default Entry style will be defined in FluentEntry
        // etc.
    }
}
