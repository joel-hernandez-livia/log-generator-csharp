using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogConsole
{
    internal class Log
    {
        private string path = "";
        //private string salto = "\n";

        public Log(string path)
        {
            this.path = path;
        }

        public void Add(string sLog)
        {
            CreateDirectory();
            string nameFile = GetNameFile();
            string cadena = "";
            cadena += $"{DateTime.Now} {sLog} {Environment.NewLine}";

            StreamWriter sw = new StreamWriter(path+"/"+nameFile, true);
            sw.Write(cadena);
            sw.Close();
        }

        private string GetNameFile()
        {
            string nameFile="";
            nameFile = $"log_{DateTime.Now.Day}_{DateTime.Now.Month}_{DateTime.Now.Year}.txt";
            return nameFile;
        }
        public void CreateDirectory() {
            try
            {
                if (!Directory.Exists(path)) 
                { 
                    Directory.CreateDirectory(path);
                }
            }
            catch (DirectoryNotFoundException ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
