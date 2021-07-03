using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Financial_Manager_V0._0.ViewModel;
using System.Windows.Threading;
using Financial_Manager_V0._0.Data;

namespace Financial_Manager_V0._0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer;
        private double panelWidth;
        bool hidden;
        public MainWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 0, 0, 10);
            timer.Tick += Timer_Tick;
            panelWidth = MenuPanel.Width;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (hidden)
            {
                MenuPanel.Width += 1;
                if (MenuPanel.Width >= 150)
                {
                    timer.Stop();
                    hidden = false;
                }
            }
            else
            {
                MenuPanel.Width -= 1;
                if (MenuPanel.Width <= 36)
                {
                    timer.Stop();
                    hidden = true;
                }
            }
        }

        private void AccountViewModel(object sender, RoutedEventArgs e)
        {
            DataContext = new AccountViewModel();
        }

        private void ReportViewModel(object sender, RoutedEventArgs e)
        {
            DataContext = new ReportViewModel();
        }

        private void MenuDrawerClick(object sender, RoutedEventArgs e)
        {
            timer.Start();
        }
    }
}
