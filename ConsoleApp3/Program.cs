using System;
using WhatsAppApi;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string From = "8097944981";
            string Mobile_NO = "8422052368";//8422052368,8104032389
            //  var link = "https://web.whatsapp.com/send?phone=" + model.Mobile_NO + "&amp;forceIntent=true&amp;load=loadInIOSExternalSafari";
            WhatsApp wa = new WhatsApp(From, "8422052368", "PKG");

            wa.OnConnectSuccess += () =>
            {
                wa.OnLoginSuccess += (mobileNo, Data) =>
                {
                    wa.SendMessage(Mobile_NO, "Hi THIS IS TEST");
                };
            };            
            Console.WriteLine("Message send !");
            Console.ReadLine();
        }
    }
}
