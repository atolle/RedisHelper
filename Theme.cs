using System.Drawing;

namespace RedisHelper
{
    internal static class Theme
    {
        public static readonly Color Background = ColorTranslator.FromHtml("#F5F6F8");
        public static readonly Color CardBackground = Color.White;
        public static readonly Color CardBorder = ColorTranslator.FromHtml("#E2E4E9");

        public static readonly Color TextPrimary = ColorTranslator.FromHtml("#1F2937");
        public static readonly Color TextMuted = ColorTranslator.FromHtml("#6B7280");

        public static readonly Color Accent = ColorTranslator.FromHtml("#DC382C");
        public static readonly Color AccentHover = ColorTranslator.FromHtml("#C42E23");

        public static readonly Color SecondaryButtonText = ColorTranslator.FromHtml("#374151");
        public static readonly Color SecondaryButtonBackground = ColorTranslator.FromHtml("#F0F1F3");
        public static readonly Color SecondaryButtonHover = ColorTranslator.FromHtml("#E4E6EA");

        public static readonly Color DangerButtonBackground = ColorTranslator.FromHtml("#FDECEC");
        public static readonly Color DangerButtonHover = ColorTranslator.FromHtml("#FADADA");
        public static readonly Color Danger = ColorTranslator.FromHtml("#B91C1C");

        public static readonly Color SuccessBackground = ColorTranslator.FromHtml("#EAF7EE");
        public static readonly Color Success = ColorTranslator.FromHtml("#15803D");

        public static readonly Color GridAltRow = ColorTranslator.FromHtml("#F7F8FA");
        public static readonly Color GridSelected = ColorTranslator.FromHtml("#D9DBDF");

        public static readonly Font Base = new Font("Segoe UI", 9.5f, FontStyle.Regular);
        public static readonly Font BaseBold = new Font("Segoe UI", 9.5f, FontStyle.Bold);
        public static readonly Font CardHeader = new Font("Segoe UI", 11f, FontStyle.Bold);
        public static readonly Font Caption = new Font("Segoe UI", 8f, FontStyle.Bold);
        public static readonly Font Muted = new Font("Segoe UI", 8.5f, FontStyle.Regular);
        public static readonly Font Loading = new Font("Segoe UI Semibold", 14f, FontStyle.Regular);
    }
}
