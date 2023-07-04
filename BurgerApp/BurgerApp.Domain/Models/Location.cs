using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp.Domain.Models
{
    public class Location : BaseEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime OpensAt { get; set; }
        public DateTime ClosesAt { get; set; }
    }
}
