using System;
using Android.Content;
using Java.Lang;
using PaymentGatewayNepal.Services;
using Xamarin.Forms;

namespace PaymentGatewayNepal.Droid.Services
{
    public class EsewaPaymentSystem : MainActivity, IEsewaClass
    {
        Context currentContext = (MainActivity)Forms.Context;
        public void GetEsewaData(string amt, string productName, string uniqueId)
        {
            Long val = Long.ValueOf(amt);
            Long amount = val;
            //config = new Com.Khalti.CheckOut.Api.Config(publicKey, uniqueId, productName, "", amount, new myKhalticlass());
            //KhaltiCheckOut khaltiCheckOut2 = new KhaltiCheckOut(currentContext, config);
            // khaltiCheckOut2.Show();
        }
    }
}
