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
        //public static string Argument;

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            foreach (string autoruns in e.Args)
            {
                if (autoruns == "info")
                {
                    Info linkwin = new Info(" ");
                    linkwin.ShowDialog();
                }

                else if (autoruns == "getway" || autoruns == "gw")
                {
                    var win = new OpenFileDialog();

                    win.InitialDirectory = "C:\\";
                    win.Title = "Выбери файл путь к которому нужно получить";

                    win.ShowDialog();

                    path = win.FileName;

                    Path linkwin = new Path(" ");
                    linkwin.ShowDialog();
                }
                else if (autoruns != "info" && autoruns != "getway" && autoruns != "gw")
                {
                    try
                    {
                        Process.Start(autoruns);
                        Process.GetCurrentProcess().Kill();
                    }
                    catch
                    {
                        MessageBox.Show("Проверьте правильноть указанного пути" + "\n" + "Ваш путь: " + autoruns, "Ошибка");
                        Process.GetCurrentProcess().Kill();
                    }
                }
            }
        }
    }
}
