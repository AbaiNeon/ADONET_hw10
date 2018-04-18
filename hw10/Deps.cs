using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace hw10
{
    public class Deps
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Emps> Emps { get; set; }
        public Deps()
        {
            Emps = new List<Emps>();
        }
    }
}
