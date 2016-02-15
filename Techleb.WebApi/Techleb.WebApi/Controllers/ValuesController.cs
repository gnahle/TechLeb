using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Techleb.WebApi.Controllers
{
    public class Order
    {
        public int OrderId { get; set; }
        public string Name { get; set; }
    }

    public class OrderAdd
    {
        public string Name { get; set; }
    }
    public class OrderEdit
    {
        public string Name { get; set; }
    }

    
    public class OrdersController : ApiController
    {
        //Database
        static List<Order> Orders = new List<Order> {
            new Order {OrderId=1,Name="Ghassan's Order" },
            new Order {OrderId=2,Name="Farah's Order" }
        };

        // GET api/values
        public IEnumerable<Order> Get()
        {
            return Orders;
        }

        // GET api/values/5
        public Order Get(int id)
        {
            return Orders.FirstOrDefault(x => x.OrderId == id);
        }

        // POST api/values
        public void Post([FromBody]OrderAdd model)
        {
            Orders.Add(new Order
            {
                Name = model.Name,
                OrderId = Orders.Count + 1
            });
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]OrderEdit model)
        {
            Order order = Orders.FirstOrDefault(x => x.OrderId == id);
            if (order == null)
                return;
            else
                order.Name = model.Name;
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            Order order = Orders.FirstOrDefault(x => x.OrderId == id);
            if (order != null)
                Orders.Remove(order);
        }
    }
}
