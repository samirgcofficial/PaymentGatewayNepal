using System;
namespace PaymentGatewayNepal.Services
{
    public interface IEsewaClass
    {
        void GetEsewaData(string Amount, string productName, string uniqueId);
    }
}
