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
    public partial class Autenticacion : PhoneApplicationPage
    {
        MyDataContext db;

        public Autenticacion()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var resultado = (from u in db.listaUsuarios where u.usuario.Equals(txtUsuario.Text) && u.clave.Equals(txtClave.Password) select u).Count();
            if (resultado == 1)
            {
                NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.RelativeOrAbsolute));
            }
            else
            {
                MessageBox.Show("Error al autenticarse");
            }
            
        }

        private void Button_Loaded(object sender, RoutedEventArgs e)
        {
           db = new MyDataContext(MyDataContext.cadena);
            if (!db.DatabaseExists())
            {
                db.CreateDatabase();
                AgregarUsuarioInicial();
            }
        }

        private void AgregarUsuarioInicial()
        {
            Usuarios u = new Usuarios();
            u.usuario = "admin";
            u.clave = "123";
            db.listaUsuarios.InsertOnSubmit(u);
            db.SubmitChanges();
        }
    }
}