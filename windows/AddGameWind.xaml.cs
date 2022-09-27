using HRSH_GameBox.tools;
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
using System.Windows.Shapes;
using System.IO;
using HRSH_GameBox.pages;

namespace HRSH_GameBox.windows
{
    /// <summary>
    /// Interaction logic for AddGameWind.xaml
    /// </summary>
    public partial class AddGameWind : Window
    {
        static string configFolder = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + @"\HRSH\GameBox";
        static string posterFolder = configFolder + @"\posters\";
        static string configFile = configFolder + @"\cfg.ini";
        static string gamesFile = configFolder + @"\gms.ini";
        static string posterPath = configFolder + @"\pos.ini";
        static string idName = configFolder + @"\idn.ini";

        IniFile gameCfg = new IniFile(gamesFile);
        IniFile gamePos = new IniFile(posterPath);
        IniFile nameFile = new IniFile(idName);

        public AddGameWind()
        {
            InitializeComponent();
        }

        private void btnLocPoster_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDlg = new Microsoft.Win32.OpenFileDialog();
            openFileDlg.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG";
            Nullable<bool> result = openFileDlg.ShowDialog();
            if (result == true)
            {
                txtItemPath.Text = openFileDlg.FileName;
            }
        }

        private void btnLocGame_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDlg = new Microsoft.Win32.OpenFileDialog();
            openFileDlg.Filter = "";
            Nullable<bool> result = openFileDlg.ShowDialog();
            if (result == true)
            {
                txtGamePath.Text = openFileDlg.FileName;
                txtGameName.Text = System.IO.Path.GetFileNameWithoutExtension(openFileDlg.FileName);
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (File.Exists(txtItemPath.Text))
            {
                if(txtGameName.Text.Length >= 1)
                {
                    if(File.Exists(txtGamePath.Text))
                    {
                        string id = Helpers.GetNewGameId();
                        gameCfg.Write(id, txtGamePath.Text);
                        nameFile.Write(id, txtGameName.Text);

                        File.Move(txtItemPath.Text, posterFolder + System.IO.Path.GetFileName(txtItemPath.Text));
                        gamePos.Write(id, posterFolder + System.IO.Path.GetFileName(txtItemPath.Text));

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Specified path to the game is not valid or does not exist!", "Invalid Game Path", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Game name can't be empty!", "Empty Game Name", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Specified path to the poster is not valid or does not exist!", "Invalid Poster Path", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
