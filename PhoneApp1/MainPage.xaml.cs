using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using PhoneApp1.Resources;

namespace PhoneApp1
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Código de ejemplo para traducir ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MyDataContext db = new MyDataContext(MyDataContext.cadena);

            try
            {
                Participantes p = new Participantes();
                p.ApPaterno = txtApPaterno.Text;
                p.ApMaterno = txtApMaterno.Text;
                p.Nombres = txtNombres.Text;
                p.DNI = txtDNI.Text;
                p.Correo = txtCorreo.Text;
                p.Direccion = txtDireccion.Text;
                p.Telefono = txtTelefono.Text;
                if (rbnM.IsChecked == true)
                {
                    p.Genero = "M";
                }
                else
                {
                    p.Genero = "F";
                }
                db.listaParticipantes.InsertOnSubmit(p);
                db.SubmitChanges();
                MessageBox.Show("Registro agregado correctamente");

                NavigationService.Navigate(new Uri("/Confirmacion.xaml", UriKind.RelativeOrAbsolute));

            }
            catch (Exception)
            {
                MessageBox.Show("Error al agregar el registro.");
            }

            
        }

        // Código de ejemplo para compilar una ApplicationBar traducida
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Establecer ApplicationBar de la página en una nueva instancia de ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Crear un nuevo botón y establecer el valor de texto en la cadena traducida de AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Crear un nuevo elemento de menú con la cadena traducida de AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}