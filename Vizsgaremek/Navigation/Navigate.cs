using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Vizsgaremek
{
    public static class Navigate
    {
        // eltároljuk a MainWindowt, hogy tudjunk váltani ablakot (pages) 
        public static MainWindow mainWindow;

        /// <summary>
        /// Egy új ablakra vált
        /// </summary>
        /// <param name="userControl">rre az ablakra váltunk</param>
        public static void Navigation(UserControl userControl)
        {
            mainWindow.PageContent.Children.Clear();
            mainWindow.PageContent.Children.Add(userControl);
        }

        public static void Navigation(Page userPage)
        {
            mainWindow.PageContent.Children.Clear();
            mainWindow.PageContent.Children.Add(userPage);
        }
    }
}
