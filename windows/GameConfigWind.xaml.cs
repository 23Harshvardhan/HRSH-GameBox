using HRSH_GameBox.tools;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;

namespace HRSH_GameBox.windows
{
    /// <summary>
    /// Interaction logic for GameConfigWind.xaml
    /// </summary>
    public partial class GameConfigWind : Window
    {
        static string configFolder = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + @"\HRSH\GameBox";
        static string gamesConfigFolder = configFolder + @"\config";
        static string gameConfigPath = gamesConfigFolder + @"\" + App.currentGame + ".ini";

        IniFile gameCfgFile = new IniFile(gameConfigPath);

        public GameConfigWind()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Helpers.CheckGameConfig();

            if (gameCfgFile.Read("verb") == "true")
                chkRunAsAdmin.IsChecked = true;
            else
                chkRunAsAdmin.IsChecked = false;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (chkRunAsAdmin.IsChecked == true)
                gameCfgFile.Write("verb", "true");
            else
                gameCfgFile.Write("verb", "false");

            this.Close();
        }
    }
}
