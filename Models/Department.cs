using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EfCore.Models
{
    public class Department : BaseEntity
    {
        public string Name { get; set; }
        public string Code { get; set; }
    }
}