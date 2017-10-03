using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Paginas_Navegacion
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Formulario : ContentPage
    {
        public Formulario()
        {
            InitializeComponent();
        }

        private void Enviar_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Datos Ingresados", Nombre.Text + " " + Apellido.Text + "\n " + Direccion.Text + " \n " + TEL.Text + " \n" + Carrera.Text + " \n" + Semestre.Text + "\n " + Matricula.Text + "\n " + Correo.Text + "\n " + GitHub.Text, "OK");
            Navigation.PushAsync(new Calculadora());
        }
    }
}