using MVC_Test_WebApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Test_WebApplication1.Services
{
    public interface CustomerService
    {
        public List<Customer> FindAll();

        public Customer Find(int id);

        public Customer ChangeProfile(Customer customer);

        public Customer FindById(int id);

        public Order AddNewOrder(Order order);

        public int FindCustomerByOrder(int ordID);

        public List<Order> ListOrders(int cusID);

        public void DeleteOrder(int ordID);
    }
}
