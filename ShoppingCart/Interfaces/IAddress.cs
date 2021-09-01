using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Implementation
{
    public interface IAddress
    {
        Address GetAddressDetails(int userID);
    }
}
