using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Implementation
{
    public interface IWallet
    {
        double GetUserBalance(int userID);
    }
}
