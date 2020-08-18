using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Noc
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static string path;
        public string Argument;

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            Argument = "";
            foreach (string autoruns in e.Args)
            {
                Argument += autoruns;
            }

            if (Argument == "info")
            {
                Info linkwin = new Info(" ");
                linkwin.ShowDialog();
            }

            if (Argument == "getway" || Argument == "gt")
            {
                var win = new OpenFileDialog();

                win.InitialDirectory = "C:\\";
                win.Title = "Выбери файл путь к которому нужно получить";

                win.ShowDialog();

                path = win.FileName;

                MessageBox.Show(path); //debug

                Path linkwin = new Path(" ");
                linkwin.ShowDialog();
            }
            MessageBox.Show(Argument);
            try
            {
                Process.Start(Argument);
            }
            catch
            {
                MessageBox.Show("Проверьте правильноть указанного пути","Ошибка");
            }
            

            //Process.GetCurrentProcess().Kill();
        }
    }
}
