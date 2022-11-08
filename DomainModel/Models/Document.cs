using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Models
{
    public class Document
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string documentType { get; set; }
        public int documentNumber { get; set; }
        public DateTime ExpireDate { get; set; }
        public int? PassengerId { get; set; }
        public Passenger Passenger { get; set; }

    }
}
