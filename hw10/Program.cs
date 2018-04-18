using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw10
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Context context = new Context())
            {
                Emps employee1 = new Emps() { Name = "AAA"};
                Emps employee2 = new Emps() { Name = "BBB" };
                Emps employee3 = new Emps() { Name = "CCC" };

                context.Emps.AddRange(new List<Emps> { employee1, employee2, employee3 });
                context.SaveChanges();

                Deps department1 = new Deps() { Name = "develop" };
                department1.Emps.Add(employee1);
                department1.Emps.Add(employee2);

                Deps department2 = new Deps() { Name = "sells" };
                department2.Emps.Add(employee2);

                Deps department3 = new Deps() { Name = "educational" };
                department2.Emps.Add(employee3);

                context.Deps.Add(department1);
                context.Deps.Add(department2);
                context.Deps.Add(department3);
                context.SaveChanges();
            }
        }
    }
}
