using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp.Domain.Models
{
    public class Order : BaseEntity
    {
        public string FullName { get; set; }
        public string Address { get; set; }
        public bool IsDelivered { get; set; }
        public List<Burger> Burgers { get; set; }
    }
}
