using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_1_HPA_4.DB;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Proyecto_1_HPA_4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginUi : ContentPage
    {
        public LoginUi()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var profesor = ProfesoresInfo.ExisteElProfesor(txtuser.Text, txtpass.Text);

            if (profesor != null)
            {
                Navigation.PushAsync(new HomePage(profesor));
            }
            else
            {
                DisplayAlert("error", "usuario o contraseña incorrecta", "ok");
            }
        }
    }
}