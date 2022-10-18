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
    public partial class VerListado : ContentPage
    {
        public VerListado()
        {
            InitializeComponent();
            lvEstudiantes.ItemsSource = Estudianteinfo.ObtenerEstudiantes();
        }
    }
}