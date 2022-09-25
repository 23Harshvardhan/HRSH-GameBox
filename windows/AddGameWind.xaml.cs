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

namespace HRSH_GameBox.windows
{
    /// <summary>
    /// Interaction logic for AddGameWind.xaml
    /// </summary>
    public partial class AddGameWind : Window
    {
        public AddGameWind()
        {
            InitializeComponent();
        }

        private void btnLocPoster_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDlg = new Microsoft.Win32.OpenFileDialog();

            Nullable<bool> result = openFileDlg.ShowDialog();
            if (result == true)
            {
                txtItemPath.Text = openFileDlg.FileName;
            }
        }
    }
}
