using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_1.ViewModels
{
    class MainWindowViewModel : BaseViewModel
    {
        MainWindow mainWindow;
        public MainWindowViewModel(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
        }
    }
}
