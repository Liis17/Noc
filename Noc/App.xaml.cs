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

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            foreach (string autoruns in e.Args)
            {
                if (autoruns == "info")
                {

                }

                if (autoruns == "getway" || autoruns == "gt")
                {
                    var win = new OpenFileDialog();

                    win.InitialDirectory = "C:\\";
                    win.Title = "Выбери файл чтоб скопировать его путь";

                    win.ShowDialog();

                    path = win.FileName;

                    Path linkwin = new Path(" ");
                    linkwin.ShowDialog();
                }
                Process.Start(autoruns);

                Process.GetCurrentProcess().Kill();
            }

        }
    }
}
