using Management.Core.Entities.Basep;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Core.Entities; 
public class Topic : BaseEntity
{
    public string Name { get; set; }
    public int AssignmentId { get; set; }   
    public Assignment Assignment { get; set; } 
}
