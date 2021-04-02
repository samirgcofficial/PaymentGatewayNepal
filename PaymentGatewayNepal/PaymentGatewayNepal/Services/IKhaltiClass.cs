using System;
namespace PaymentGatewayNepal.Services
{
    public interface IKhaltiClass
    {
        void GetKhaltiData(string Amount, string productName, string uniqueId);
    }
}
