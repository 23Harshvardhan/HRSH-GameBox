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
using System.IO;

namespace HRSH_GameBox.pages
{
    /// <summary>
    /// Interaction logic for homePg.xaml
    /// </summary>
    public partial class homePg : Page
    {
        static string configFolder = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + @"\HRSH\GameBox";
        static string posterFolder = configFolder + @"\posters\";
        static string configFile = configFolder + @"\cfg.ini";
        static string gamesFile = configFolder + @"\gms.ini";
        static string nameId = configFolder + @"\idn.ini";
        static string poster = configFolder + @"\pos.ini";

        IniFile cgfIni = new IniFile(configFile);
        IniFile gmsIni = new IniFile(gamesFile);
        IniFile inm = new IniFile(nameId);
        IniFile posIni = new IniFile(poster);

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
            if (wrpPnl.Children.Count >= 1)
            {
                wrpPnl.Children.Clear();
            }

            string[] entries = File.ReadAllLines(nameId);
            entries = entries.Skip(1).ToArray();

            List<string> gameIds = new List<string>();

            if (gameIds.Count >= 1)
                gameIds.Clear();

            if (entries.Length >= 1)
            {
                foreach (string entry in entries)
                {
                    string id = entry.Substring(0, entry.IndexOf('='));
                    gameIds.Add(id);
                }

                foreach (string id in gameIds)
                {
                    Image img = new Image();
                    
                    img.Name = id;
                    img.Source = new BitmapImage(new Uri(posIni.Read(id), UriKind.RelativeOrAbsolute));
                    img.Width = 140;
                    img.Height = 200;
                    img.Stretch = Stretch.Fill;
                    img.Margin = new Thickness(20,20, 0, 0);
                    img.MouseDown += Img_MouseDown;
                    img.ToolTip = inm.Read(id);
                    
                    wrpPnl.Children.Add(img);
                }
            }
        }

        private void Img_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var gameObj = (Image)sender;
            var window = (MainWindow)Application.Current.MainWindow;
            App.currentGame = gameObj.Name;
            window.mainFrame.Content = new gamePg();
        }

        private void homePge_Loaded(object sender, RoutedEventArgs e)
        {
            DrawLibrary();
        }

        private void btnRedraw_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            DrawLibrary();
        }
    }
}
