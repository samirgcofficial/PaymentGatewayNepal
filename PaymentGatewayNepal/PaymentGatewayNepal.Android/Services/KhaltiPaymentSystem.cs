using System;
using Android.Content;
using Java.Lang;
using PaymentGatewayNepal.Droid.Services;
using PaymentGatewayNepal.Services;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(KhaltiPaymentSystem))]
namespace PaymentGatewayNepal.Droid.Services
{
    public class KhaltiPaymentSystem : MainActivity, IKhaltiClass
    {
        Context currentContext = (MainActivity)Forms.Context;
        //private Com.Khalti.CheckOut.Api.Config config;
        //// Require Parameters
        //System.String publicKey = Constant.Pub;
        //Long amount = (Long)100L; // In Paisa    

        public void GetKhaltiData(string amt, string productName, string uniqueId)
        {
            Long val = Long.ValueOf(amt);
            Long amount = val;
            //config = new Com.Khalti.CheckOut.Api.Config(publicKey, uniqueId, productName, "", amount, new myKhalticlass());
            //KhaltiCheckOut khaltiCheckOut2 = new KhaltiCheckOut(currentContext, config);
           // khaltiCheckOut2.Show();
        }

    }
}
