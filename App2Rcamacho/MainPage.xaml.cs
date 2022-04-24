using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2Rcamacho
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btn_Clicked(object sender, EventArgs e)
        {
            string user = txtUsuario.Text;
            string contraseña = txtContraseña.Text;
            if (user == "estudiante2022" && contraseña=="uisrael2022")
            {

                DisplayAlert("Bienvenido", "Se ha iniciado sesi{on con éxito", "OK");
                await Navigation.PushAsync(new Vista2(user, contraseña));
            }

            else
            {
                DisplayAlert("Alerta", "Las credenciales son erróneas", "salir");

            }

           
        }
    }
}
