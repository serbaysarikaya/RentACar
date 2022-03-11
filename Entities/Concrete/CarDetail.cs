using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class CarDetail : IEntity
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public int ModelYear { get; set; }
        public int ColorId { get; set; }
        public string Kilometer { get; set; }
        public bool Damaged { get; set; }
    }
}
