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
        static string idName = configFolder + @"\idn.ini";
        static string gamesConfigFolder = configFolder + @"\config";

        static IniFile gameCfg = new IniFile(idName);

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
            if (App.currentGame != null)
            {
                string gameConfigPath = gamesConfigFolder + @"\" + App.currentGame + ".ini";
                IniFile gameCfgFile = new IniFile(gameConfigPath);

                if (!File.Exists(gameConfigPath))
                {
                    FileStream fs = File.Create(gameConfigPath);
                    fs.Dispose();

                    gameCfgFile.Write("verb", "false");
                }
            }
        }

        public static string TranslateVerb(string verbReading)
        {
            if (verbReading == "true")
                return "runas";
            else
                return "";
        }
    }
}
