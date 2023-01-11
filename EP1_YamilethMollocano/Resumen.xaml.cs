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
    public partial class Resumen : ContentPage
    {
        public Resumen(string nombre, string apellido, string user, string total, string dato1)
        {
            InitializeComponent();
            lblNombre.Text = nombre;
            lblApellido.Text = apellido;
            lblTotal.Text = total;
            lblUser.Text = user;
            lblDato1.Text = dato1;
      
        }
    }
}