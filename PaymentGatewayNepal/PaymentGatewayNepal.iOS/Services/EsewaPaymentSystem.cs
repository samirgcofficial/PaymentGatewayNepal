using System;
using PaymentGatewayNepal.iOS.Services;
using PaymentGatewayNepal.Services;

[assembly: Xamarin.Forms.Dependency(typeof(EsewaPaymentSystem))]
namespace PaymentGatewayNepal.iOS.Services
{
    public class EsewaPaymentSystem : EsewaSDKPaymentDelegate, IEsewaClass
    {
        public EsewaPaymentSystem()
        {
        }
        public void GetEsewaData(string amt, string productName, string uniqueId)
        {

          //  EsewaSDK. initiatePayment(merc
            //Long val = Long.ValueOf(amt);
            //Long amount = val;
            //config = new Com.Khalti.CheckOut.Api.Config(publicKey, uniqueId, productName, "", amount, new myKhalticlass());
            //KhaltiCheckOut khaltiCheckOut2 = new KhaltiCheckOut(currentContext, config);
            //khaltiCheckOut2.Show();
        }
    }
}
