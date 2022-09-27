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
using System.IO;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using HRSH_GameBox.tools;
using System.Collections;
using System.Diagnostics;

namespace HRSH_GameBox.pages
{
    /// <summary>
    /// Interaction logic for gamePg.xaml
    /// </summary>
    public partial class gamePg : Page
    {
        static string configFolder = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + @"\HRSH\GameBox";
        static string tempFile = configFolder + @"\temp.dat";
        static string posterFolder = configFolder + @"\posters\";
        static string configFile = configFolder + @"\cfg.ini";
        static string gamesFile = configFolder + @"\gms.ini";
        static string nameId = configFolder + @"\idn.ini";
        static string posterLoc = configFolder + @"\pos.ini";

        IniFile name = new IniFile(nameId);
        IniFile poster = new IniFile(posterLoc);
        IniFile path = new IniFile(gamesFile);

        private string idToLoad;

        public gamePg()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            FileStream fs = File.OpenRead(tempFile);
            byte[] bytes = new byte[1024];
            fs.Read(bytes, 0, bytes.Length);
            fs.Dispose();

            idToLoad = System.Text.Encoding.UTF8.GetString(bytes);

            lblGameName.Content = name.Read(idToLoad);
            imgPoster.Source = new BitmapImage(new Uri(poster.Read(idToLoad), UriKind.RelativeOrAbsolute));
        }

        private void btnPlay_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show(System.IO.Path.GetDirectoryName(path.Read(idToLoad)), path.Read(idToLoad));
            Process proc = new Process();
            proc.StartInfo.FileName = path.Read(idToLoad);
            proc.StartInfo.WorkingDirectory = System.IO.Path.GetDirectoryName(path.Read(idToLoad));
            
            try
            {
                proc.Start();
            }
            catch
            {
                MessageBox.Show("Unable to start process. Please check configuration for the game.", "Unable To Launch", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
