using EstudoAulaC_97Enum1._2.Entities.Enums;
using EstudoAulaC_97Enum1._2.Entities;
namespace EstudoAulaC_97Enum1._2
{
     class Program
    {
        static void Main(string[] args)
        {
           
            Order order = new Order{
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment,
            };
            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();//converter de enum para string
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");//converter de string para enum /o valor entre o maior que e menor que deve ser equivalente a um

            Console.WriteLine(OrderStatus.PendingPayment);
            Console.WriteLine(txt);
        }
    }
}
