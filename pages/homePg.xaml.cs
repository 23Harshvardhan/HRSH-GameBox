using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using HRSH_GameBox.tools;
using HRSH_GameBox.windows;

namespace HRSH_GameBox.pages
{
    /// <summary>
    /// Interaction logic for homePg.xaml
    /// </summary>
    public partial class homePg : Page
    {
        static string configFolder = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + @"\HRSH\GameBox";
        static string configFile = configFolder + @"\cfg.ini";
        static string gamesFile = configFolder + @"\gms.ini";

        IniFile cgfIni = new IniFile(configFile);
        IniFile gmsIni = new IniFile(gamesFile);

        public homePg()
        {
            InitializeComponent();
        }

        private void btnAddGame_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            AddGameWind addgameWind = new AddGameWind();
            addgameWind.ShowDialog();
        }

        public void DrawLibrary()
        {
            if(wrpPnl.Children.Count >= 1)
            {
                wrpPnl.Children.Clear();
            }


        }
    }
}
