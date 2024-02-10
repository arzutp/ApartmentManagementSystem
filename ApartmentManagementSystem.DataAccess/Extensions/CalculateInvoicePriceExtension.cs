using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.DataAccess.Extensions
{
    public static class CalculateInvoicePriceExtension
    {
        public static decimal CalculateInvoicePrice(this decimal price, int discount)
        {
            decimal discountAmount = (price * discount) / 100;
            return price + discountAmount;
        }
    }
}
