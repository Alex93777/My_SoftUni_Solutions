using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOopHierarchy
{
    public class Customer
    {
        //характеристиките: списък с поръчки, име, имейл
        private List<Order> _orderHistory = new();
        public IReadOnlyCollection<Order> OrderHistory => this._orderHistory.AsReadOnly();
        public string Name { get; set; }
        public string Email { get; set; }
    
        //Конструктор
        public Customer(string name, string email)
        {
            //нов празен обект
            //_orderHistory - {}
            Name = name;
            Email = email;
        }

        //действия
        public void AddOrder (Order order)
        {
            _orderHistory.Add(order);
        }
    }
}
