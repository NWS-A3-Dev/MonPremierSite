using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonPremierSite.DBModels
{
    public class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
