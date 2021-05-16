using System;
using System.Collections.Generic;
using System.Text;

namespace WZPO.DataAccess.Models
{
    public class Administrator : User
    {
        public ICollection<PrivelageName> Privelages { get; set; }
    }
}
