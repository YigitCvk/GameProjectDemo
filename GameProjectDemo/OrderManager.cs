using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    class OrderManager:IOrderService
    {
        public void OrderEkle(Orders orders, Gamer gamer)
        {
            Console.WriteLine("Sayın " + gamer.NickName + " Siparişiniz Alındı !");
        }

        public void OrderSil(Orders orders, Gamer gamer)
        {
            Console.WriteLine("Sayın " + gamer.NickName + " Siparişiniz Silindi ! ");
        }
    }
}
