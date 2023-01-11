using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EP1_YamilethMollocano
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnIngresar_Clicked(object sender, EventArgs e)
        {
            //Login  Text
            string user = txtUser.Text;
            string pass = txtPass.Text;

            if (user != "estudiante2023" || pass != "uisrael2023")
            {
                await DisplayAlert("Alerta", "POr favor validar usuario o clave incorrectos ", "Reintentar");
                return;
            }
            else
            {
                await Navigation.PushAsync(new Registro(user, pass));
                await DisplayAlert("Acceso Correcto", "CURSOS ONLINE", "Aceptar");
            }
        }
    }
}