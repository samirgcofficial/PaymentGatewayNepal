using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaymentGatewayNepal.Services;
using Xamarin.Forms;

namespace PaymentGatewayNepal
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        void Khalti_Clicked(System.Object sender, System.EventArgs e)
        {
            DependencyService.Get<IKhaltiClass>().GetKhaltiData("500", "productName", "uniqueId");
        }

        void Esewa_Clicked(System.Object sender, System.EventArgs e)
        {
            DependencyService.Get<IEsewaClass>().GetEsewaData("500", "productName", "uniqueId");
        }
    }
}
