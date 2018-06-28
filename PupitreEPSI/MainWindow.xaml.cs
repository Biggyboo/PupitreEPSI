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

namespace PupitreEPSI
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();
            Frame.NavigationService.Navigate(new Accueil());
          
            dispatcherTimer.Tick += new EventHandler(DispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 1, 0);
            dispatcherTimer.Start();
        }

        private void Ecole_Click(object sender, RoutedEventArgs e)
        {
            Frame.NavigationService.Navigate(new Ecole());
            dispatcherTimer.Stop();
            dispatcherTimer.Start();

        }

        private void Ecole_Enter(object sender, RoutedEventArgs e)
        {
            
            
        }

        private void Visiteur_Click(object sender, RoutedEventArgs e)
        {

        }


        private void Administration_Click(object sender, RoutedEventArgs e)
        {
            Frame.NavigationService.Navigate(new Administration());
            dispatcherTimer.Stop();
            dispatcherTimer.Start();
        }

        private void test_Click(object sender, RoutedEventArgs e)
        {
            Frame.NavigationService.Navigate(new Ecole());
        }

        private void Frame_Navigated(object sender, NavigationEventArgs e)
        {

        }



        private void DispatcherTimer_Tick(object sender, EventArgs e)
        {
            Frame.NavigationService.Navigate(new Accueil());
        }
       
    }
}
