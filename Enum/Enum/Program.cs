using System;
using Enum.Entities;
using Enum.Entities.Enums;

namespace Enum;

class Program
{
    static void Main(string[] args)
    {
        Order order = new Order
        {
            Id = 1000, Moment = DateTime.Now, Status = OrderStatus.PROCESSING
        };
        Console.WriteLine($"Order: {order}");
        
        // Convertendo um Enum para string
        string txt = OrderStatus.PEDDINGPAYMENT.ToString();
        Console.WriteLine(txt);
        
        // Covnertendo um string para Enum
        OrderStatus os = System.Enum.Parse<OrderStatus>("DELIVERED");
        Console.WriteLine(os);
    }
}