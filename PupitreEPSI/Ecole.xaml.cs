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
using System.Windows.Threading;

namespace PupitreEPSI
{
    /// <summary>
    /// Logique d'interaction pour Ecole.xaml
    /// </summary>
    public partial class Ecole : Page
    {
        public Ecole()
        {
            InitializeComponent();
            //EPSI.Source = new BitmapImage(new Uri("epsi-logo-hd.jpg", UriKind.Relative));
            //IDRAC.Source = new BitmapImage(new Uri("logo_idrac2.png", UriKind.Relative));
            //IFAG.Source = new BitmapImage(new Uri("Ifag_logo.png", UriKind.Relative));
            //IGEFI.Source = new BitmapImage(new Uri("igefi.jpg", UriKind.Relative));
            //OSS.Source = new BitmapImage(new Uri("Logo-OSS.png", UriKind.Relative));
            //SUP.Source = new BitmapImage(new Uri("SUP-DE-COM.png", UriKind.Relative));
            //WIS.Source = new BitmapImage(new Uri("Logo-WIS.png", UriKind.Relative));
        }

        private void EPSI_button_Click(object sender, RoutedEventArgs e)
        {

        }

        

        private void IDRAC_button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void IFAG_button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void IGEFI_button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void OSS_button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SUP_button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void WIS_button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EPSI_button_MouseEnter(object sender, MouseEventArgs e)
        {
            Image img = new Image();
            
            img.Source = new BitmapImage(new Uri("epsi-logo-hd.png", UriKind.Relative));
            this.EPSI_button.Content = img;
            
        }

        private void EPSI_button_MouseLeave(object sender, MouseEventArgs e)
        {
            
            Label lab = new Label();
            lab.Content = "EPSI";
            this.EPSI_button.Content = lab;

        }

        private void IDRAC_button_MouseEnter(object sender, MouseEventArgs e)
        {
            Image img = new Image();
            img.Source = new BitmapImage(new Uri("logo_idrac2.png", UriKind.Relative));
            this.IDRAC_button.Content = img;
        }

        private void IDRAC_button_MouseLeave(object sender, MouseEventArgs e)
        {
            Label lab = new Label();
            lab.Content = "IDRAC";
            this.IDRAC_button.Content = lab;
        }

        private void IFAG_button_MouseEnter(object sender, MouseEventArgs e)
        {
            Image img = new Image();
            img.Source = new BitmapImage(new Uri("Ifag_logo.png", UriKind.Relative));
            this.IFAG_button.Content = img;
        }

        private void IFAG_button_MouseLeave(object sender, MouseEventArgs e)
        {
            Label lab = new Label();
            lab.Content = "IFAG";
            lab.Foreground = new SolidColorBrush(Colors.White);
            this.IFAG_button.Content = lab;
        }

        private void IGEFI_button_MouseEnter(object sender, MouseEventArgs e)
        {
            Image img = new Image();
            img.Source = new BitmapImage(new Uri("igefi.png", UriKind.Relative));
            this.IGEFI_button.Content = img;
        }

        private void IGEFI_button_MouseLeave(object sender, MouseEventArgs e)
        {
            Label lab = new Label();
            lab.Content = "IGEFI";
            lab.Foreground = new SolidColorBrush(Colors.White);
            this.IGEFI_button.Content = lab;
        }

        private void OSS_button_MouseEnter(object sender, MouseEventArgs e)
        {
            Image img = new Image();
            img.Source = new BitmapImage(new Uri("Logo-OSS.png", UriKind.Relative));
            this.OSS_button.Content = img;
        }

        private void OSS_button_MouseLeave(object sender, MouseEventArgs e)
        {
            Label lab = new Label();
            lab.Content = "Open Source School";
            this.OSS_button.Content = lab;
        }

        private void SUP_button_MouseEnter(object sender, MouseEventArgs e)
        {
            Image img = new Image();
            img.Source = new BitmapImage(new Uri("SUP-DE-COM.png", UriKind.Relative));
            this.SUP_button.Content = img;
        }

        private void SUP_button_MouseLeave(object sender, MouseEventArgs e)
        {
            Label lab = new Label();
            lab.Content = "SUP de COM";
            this.SUP_button.Content = lab;
        }

        private void WIS_button_MouseEnter(object sender, MouseEventArgs e)
        {
            Image img = new Image();
            img.Source = new BitmapImage(new Uri("Logo-WIS.png", UriKind.Relative));
            this.WIS_button.Content = img;
        }

        private void WIS_button_MouseLeave(object sender, MouseEventArgs e)
        {
            Label lab = new Label();
            lab.Content = "WIS";
            this.WIS_button.Content = lab;
        }
    }
}
