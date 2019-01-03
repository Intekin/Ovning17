using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernate2
{
    class School
    {
        public virtual Guid Id { get; set; }
        public virtual string Name { get; set; }
    }
}
