using Core.Entities;
using System;

namespace Entities.Concrete
{
    public class User : IEntity
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Status { get; set; }
    }
}
