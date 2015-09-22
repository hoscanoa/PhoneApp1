using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace PhoneApp1
{
    public partial class Listado : PhoneApplicationPage
    {
        public Listado()
        {
            InitializeComponent();
            
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            MyDataContext db = new MyDataContext(MyDataContext.cadena);
            lstParticipantes.ItemsSource = db.listaParticipantes;
        }



    }
}