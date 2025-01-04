using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace password_generator_csharp
{
    public static class ThemeManager
    {
        public static string CurrentTheme { get; private set; } = "Defecto";

        public static void LoadTheme()
        {
            CurrentTheme = Properties.Settings.Default.SelectedTheme;
            if (string.IsNullOrEmpty(CurrentTheme))
            {
                CurrentTheme = "Defecto"; // Tema por defecto
            }
            ThemeColors.ElegirTema(CurrentTheme);
        }

        public static void SaveTheme(string theme)
        {
            CurrentTheme = theme;
            Properties.Settings.Default.SelectedTheme = theme;
            Properties.Settings.Default.Save();
            ThemeColors.ElegirTema(theme);
        }
    }
}
