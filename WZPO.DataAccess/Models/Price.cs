using System;
using System.Collections.Generic;
using System.Text;

namespace WZPO.DataAccess.Models
{
    public class Price
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Cost { get; set; }
        public bool IsActive { get; set; }
    }
}
