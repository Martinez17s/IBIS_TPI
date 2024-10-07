using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Enums;

namespace Domain.Entities
{
    public class Professional : User
    {
        public Specialty Specialty { get; set; }
        public List<Appointment> Appointments { get; set; }
    }
}
