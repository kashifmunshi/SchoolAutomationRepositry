using System.Collections.Generic;
using AppEntity.Models;

namespace WebApp.VModels
{
    public class VOrder
    {
        public List<Department> Departments { get; set; }
        public Order Order { get; set; }
        public List<Order> Orders { get; set; }
    }
}