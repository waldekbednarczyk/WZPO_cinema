using System;
using System.Collections.Generic;
using System.Text;

namespace WZPO.DataAccess.Models
{
    public abstract class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
    }
}
