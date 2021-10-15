using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace S5_MVCEFCore.DatabaseFirst.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Order = new HashSet<Order>();
        }

        public int Id { get; set; }
        //Se usa para personalisar (NO ES NECESARIO)
        [Display(Name = "Nombres")]
        public string FirstName { get; set; }
        //Se usa para personalisar (NO ES NECESARIO)
        [Display(Name = "Apellidos")]
        public string LastName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<Order> Order { get; set; }
    }
}
