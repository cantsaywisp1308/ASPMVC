using Microsoft.EntityFrameworkCore;
using MVC_Test_WebApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Test_WebApplication1.Services
{
    public class CustomerServiceImp : CustomerService
    {
        private DatabaseContext db;

        public CustomerServiceImp(DatabaseContext _db)
        {
            db = _db;
        }

        public Order AddNewOrder(Order order)
        {
            db.Orders.Add(order);
            db.SaveChanges();
            return order;
        }

        public Customer ChangeProfile(Customer customer)
        {
            db.Entry(customer).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return customer;
        }

        public void DeleteOrder(int ordID)
        {
            db.Orders.Remove(db.Orders.Find(ordID));
            db.SaveChanges();
        }

        public Customer Find(int id)
        {
            return db.Customers.Find(id);
        }

        public List<Customer> FindAll()
        {
            return db.Customers.ToList();
        }

        public Customer FindById(int id)
        {
            return db.Customers.AsNoTracking().SingleOrDefault(c => c.Id == id);
        }

        public int FindCustomerByOrder(int ordID)
        {
            return db.Orders.Find(ordID).CustomerId;
        }

        public List<Order> ListOrders(int cusID)
        {
            return db.Orders.Where(o => o.CustomerId == cusID).ToList();
        }
    }
}
