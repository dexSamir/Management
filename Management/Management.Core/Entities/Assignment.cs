using Management.Core.Entities.Basep;
using Management.Core.Entitiesl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Core.Entities; 

public class Assignment : BaseEntity
{
    public string Title { get; set; }
    public string Description { get; set; }
    public ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();
    public ICollection<Topic> Topic { get; set; } = new HashSet<Topic>();
    public ICollection<AssignmentTag> Tags { get; set; }

}
