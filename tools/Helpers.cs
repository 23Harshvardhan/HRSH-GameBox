using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSH_GameBox.tools
{
    internal class Helpers
    {
        static string configFolder = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + @"\HRSH\GameBox";
        static string configFile = configFolder + @"\cfg.ini";
        static string gamesFile = configFolder + @"\gms.ini";
        static string posterPath = configFolder + @"\pos.ini";
        static string idName = configFolder + @"\idn.ini";
        static string gamesConfigFolder = configFolder + @"\config";
        static string gameConfigPath = gamesConfigFolder + @"\" + App.currentGame + ".ini";

        static IniFile gameCfg = new IniFile(idName);
        static IniFile gameCfgFile = new IniFile(gameConfigPath);

        public static string GetNewGameId()
        {
            int i = 0;
            bool found = false;

            while (!found)
            {
                if (gameCfg.KeyExists("i" + i.ToString()))
                {
                    i++;
                }
                else
                {
                    found = true;
                }
            }

            return "i" + i.ToString();
        }

        public static void CheckGameConfig()
        {
            if (!File.Exists(gameConfigPath))
            {
                FileStream fs = File.Create(gameConfigPath);
                fs.Dispose();

                gameCfgFile.Write("verb", "false");
            }
        }
    }
}
