using HRSH_GameBox.pages;
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
using System.Configuration;
using System.IO;

namespace HRSH_GameBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static string configFolder = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + @"\HRSH\GameBox";
        static string configFile = configFolder + @"\cfg.ini";
        static string gamesFile = configFolder + @"\gms.ini";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void mainWind_Loaded(object sender, RoutedEventArgs e)
        {
            CheckConfig();
            mainFrame.Content = new homePg();
        }

        void CheckConfig()
        {
            if(!File.Exists(configFile))
            {
                FileStream fs1 = File.Create(configFile);
                fs1.Dispose();
            }

            if(!File.Exists(gamesFile))
            {
                FileStream fs2 = File.Create(gamesFile);
                fs2.Dispose();
            }
        }
    }
}
