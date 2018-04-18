using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace hw10
{
    public class Emps
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Deps> Deps { get; set; }
        public Emps()
        {
            Deps = new List<Deps>();
        }
    }
}
