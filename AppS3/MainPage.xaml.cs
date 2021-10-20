using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppS3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnAbrir_Clicked(object sender, EventArgs e)
        {
            try
            {
                string usuario = txtUsuario.Text;
                string clave = txtClave.Text;

                //Abrir la ventana
                await Navigation.PushAsync(new viewDos(usuario, clave));
            }
            catch(Exception e)
            {
                await DisplayAlert("Mensaje de advertencia ", e.Message ,"ok");
            }
           
        }
    }
}
