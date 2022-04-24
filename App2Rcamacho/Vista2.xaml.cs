using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2Rcamacho
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Vista2 : ContentPage
    {
        public Vista2(string usuario, string contraseña)
        {
            InitializeComponent();

        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {

            try
            {
                double datoUno = Convert.ToDouble(txtDatoUno.Text);
                double datoDos = Convert.ToDouble(txtDatoDos.Text);
                double datoTres = Convert.ToDouble(txtDatoTres.Text);
                double datoCuatro = Convert.ToDouble(txtDatoCuatro.Text);
                string mensaje = "";

                double suma = (datoUno * 0.3) + (datoDos * 0.2);
                txtResultado.Text = suma.ToString();
                lblResultado.Text = suma.ToString();

                double suma2 = (datoTres * 0.3) + (datoCuatro * 0.2);
                txtResultado2.Text = suma2.ToString();
                lblResultado.Text = suma2.ToString();

                double notaFinal = suma + suma2;
                txtNotaFinal.Text = notaFinal.ToString();

                if(notaFinal >= 7)
                {
                    mensaje = "APROBADO";
                }
                else if(notaFinal >= 5)
                {
                    mensaje = "SUPLETORIO";
                }
                else
                {
                    mensaje = "REPROBADO";
                }

                lblMensaje.Text = mensaje;

            }
            catch (Exception ex)
            {
                DisplayAlert("ERROR", ex.Message, "cerrar");
            }

        }

        private void txtDatoUno_TextChanged_1(object sender, TextChangedEventArgs e)
        {

            if (txtDatoUno.Text.Length > 0)
            {

                double datoUno = Convert.ToDouble(txtDatoUno.Text);
                if (datoUno > 0 && datoUno <= 10)
                { }

                else
                {
                    DisplayAlert("ERROR", "La nota debe estar entre 0 y 10", "cerrar");
                }
            }
        }

        private void txtDatoDos_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(txtDatoDos.Text.Length > 0)
            {
                double datoDos = Convert.ToDouble(txtDatoDos.Text);
                if (datoDos > 0 && datoDos <= 10)
                        { }
                else
                {
                    DisplayAlert("ERROR", "La nota debe estar entre 0 y 10", "cerrar");
                }
            }

        }

        private void txtDatoTres_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtDatoTres.Text.Length > 0)
            {
                double datoTres = Convert.ToDouble(txtDatoTres.Text);
                if (datoTres > 0 && datoTres <= 10)
                { }
                else
                {
                    DisplayAlert("ERROR", "La nota debe estar entre 0 y 10", "cerrar");
                }
            }
        }

        private void txtDatoCuatro_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtDatoCuatro.Text.Length > 0)
            {
                double datoCuatro = Convert.ToDouble(txtDatoCuatro.Text);
                if (datoCuatro > 0 && datoCuatro <= 10)
                { }
                else
                {
                    DisplayAlert("ERROR", "La nota debe estar entre 0 y 10", "cerrar");
                }
            }

        }
    }   
}
