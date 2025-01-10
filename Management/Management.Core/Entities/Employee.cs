using Management.Core.Entities;
using Management.Core.Entities.Basep;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Core.Entitiesl; 

public class Employee : BaseEntity
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public decimal Salary { get; set; }
    public int Age { get; set; }
    public DateTime BirthDate { get; set; } 
    public int Position { get; set; }
    public int AssignmentId { get; set; }
    public Assignment Assignment { get; set; }
}
