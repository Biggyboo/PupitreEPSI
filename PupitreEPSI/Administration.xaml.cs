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
    /// Logique d'interaction pour Administration.xaml
    /// </summary>
    public partial class Administration : Page
    {
        public Administration()
        {
            InitializeComponent();
            EPSI.Source = new BitmapImage(new Uri("epsi-logo-hd.jpg", UriKind.Relative));
            IDRAC.Source = new BitmapImage(new Uri("logo_idrac2.png", UriKind.Relative));
            IFAG.Source = new BitmapImage(new Uri("Ifag_logo.png", UriKind.Relative));
            IGEFI.Source = new BitmapImage(new Uri("igefi.jpg", UriKind.Relative));
            OSS.Source = new BitmapImage(new Uri("Logo-OSS.png", UriKind.Relative));
            SUP.Source = new BitmapImage(new Uri("SUP-DE-COM.png", UriKind.Relative));
            WIS.Source = new BitmapImage(new Uri("Logo-WIS.png", UriKind.Relative));
        }
    }
}
