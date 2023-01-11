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
    public partial class Registro : ContentPage
    {
        public Registro(string user, string pass)
        {
            InitializeComponent();
            string usuario = lblUser.Text;
            lblUser.Text = usuario + user;
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            try
            {
                double dato1 = Convert.ToDouble(txtDato1.Text);

                if (dato1 < 4000)
                {
                    double saldo = (4000 - dato1);
                    double cuota = saldo / 5;
                    double parte = (cuota * 5)/100;
               

                    double total = (5*parte)+ saldo;
                    txtResultado.Text = total.ToString();
                }
                else
                {
                    if (dato1 == 4000)
                    {
                        double parte = 0;
                        

                        double total = dato1 + (parte * 5);
                        txtResultado.Text = total.ToString();
                        DisplayAlert("Notificación", "CURSO TOTALMENTE PAGADO", "Ok");
                    }
                    else
                    {
                        if (dato1 > 4000)
                        {
                           
                            DisplayAlert("Alerta", "VALOR INGRESADO INCORRECTO", "Reintentar");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("Mensaje de Alerta", "ERROR" + ex.Message, "Ok.");
            }
        }

        private void btnGuardar_Clicked(object sender, EventArgs e)
        {
            if (txtNombre.Text == null)
            {
                DisplayAlert("Error", "Ingrese Datos", "Reintentar");
            }
            else
            {
                if (txtDato1.Text == null)
                {
                    DisplayAlert("Error", "Ingrese Datos", "Reintentar");
                }
                else
                {
                    DisplayAlert("Confirmación", "Elemento guardado con Exito", "Ok");
                }
            }
        }

        private async void btnResumen_Clicked(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string user = lblUser.Text;
            string total = txtResultado.Text;
            string dato1 = txtDato1.Text;
        
            await Navigation.PushAsync(new Resumen(nombre, apellido, user, total, dato1));
        }
    }
}