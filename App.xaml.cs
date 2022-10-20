using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace HRSH_GameBox
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        // Keeps track of the current game's ID.
        public static string currentGame;

        // Keeps track of the opening and closing time of the current game.
        public static DateTime startTime;
        public static DateTime endTime;
    }
}
