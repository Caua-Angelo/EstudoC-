using EstudoAulaC_97Enum.Entities;
using EstudoAulaC_97Enum.Entities.Enums;

namespace EstudoAulaC_97Enum {
    internal class Program {
        static void Main(string[] args) {

            Order order = new Order {
                Id = 1080,
                Moment = DateTime.Now,
                Status = Entities.Enums.OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(txt);
            Console.WriteLine(os);

            
        }
    }
}
