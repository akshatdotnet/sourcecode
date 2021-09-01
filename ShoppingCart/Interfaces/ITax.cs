using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Implementation
{
    public interface ITax
    {
        double GetTaxByState(string state);
        void ApplyTax(int cartID, double taxPercent);
    }
}
