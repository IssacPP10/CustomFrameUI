using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace password_generator_csharp
{
    public static class ThemeColors
    {
        public static Color PanelPadre;
        public static Color PanelMenu;
        public static Color BarraTitulo;        
        public static Color FuenteIconos;


        //Colores Defecto
        private static readonly Color PanelPadreD = Color.FromArgb(255, 255, 255);
        private static readonly Color PanelMenuD = Color.FromArgb(122, 35, 56);
        private static readonly Color BarraTituloD = Color.FromArgb(186, 54, 85);        
        private static readonly Color FuenteIconosD = Color.White;

        //Tema Morado
        private static readonly Color PanelPadreM = Color.FromArgb(255, 255, 255);
        private static readonly Color PanelMenuM = Color.FromArgb(94, 65, 97);
        private static readonly Color BarraTituloM = Color.FromArgb(164, 64, 173);        
        private static readonly Color FuenteIconosM = Color.White;

        //Tema Verde
        private static readonly Color PanelPadreV = Color.FromArgb(255, 255, 255);
        private static readonly Color PanelMenuV = Color.FromArgb(121, 173, 0);
        private static readonly Color BarraTituloV = Color.FromArgb(157, 224, 0);        
        private static readonly Color FuenteIconosV = Color.White;
        

        //SeleccionarColores
        #region -> Metodos
        public static void ElegirTema(string Tema)
        {
            if (Tema == "Defecto")
            {
                PanelPadre = PanelPadreD;
                PanelMenu = PanelMenuD;
                BarraTitulo = BarraTituloD;                
                FuenteIconos = FuenteIconosD;
            }
            if (Tema == "Morado")
            {
                PanelPadre = PanelPadreM;
                PanelMenu = PanelMenuM;
                BarraTitulo = BarraTituloM;                
                FuenteIconos = FuenteIconosM;
            }
            if (Tema == "Verde")
            {
                PanelPadre = PanelPadreV;
                PanelMenu = PanelMenuV;
                BarraTitulo = BarraTituloV;                
                FuenteIconos = FuenteIconosV;
            }
            // Guardar el tema seleccionado
            Properties.Settings.Default.SelectedTheme = Tema;
            Properties.Settings.Default.Save();
        }
        #endregion
        public static string CargarTema()
        {
            return Properties.Settings.Default.SelectedTheme;
        }
    }
}
