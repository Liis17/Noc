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

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            foreach (string autoruns in e.Args)
            {
                if (autoruns == "тест")
                {
                    Process.GetCurrentProcess().Kill();
                }
            }

        }
    }
}
