﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class CarDetail : IEntity
    {
        public int ModelYear { get; set; }
        public string Kilometer { get; set; }
        public bool Damaged { get; set; }
    }
}
