using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTO
{
    public class CarDto : IDto
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public string Model { get; set; }
        public int ModelYear { get; set; }
        public string Kilometer { get; set; }        
        public bool Damaged { get; set; }
    }
}
