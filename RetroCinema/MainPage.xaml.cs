using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RetroCinema
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnInSecion_Clicked(object sender, EventArgs e)
        {
            if (usuario.Text=="admin" && contraseña.Text == "123")
                {
                    Navigation.PushAsync(new Pages.Home());
                }
               
        }

        

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pages.PageRegistro());
        }
    }
}
