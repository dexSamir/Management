using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Core.Entities;
public class AssignmentTag 
{
    public int Id { get; set; }
    public int AssignmentId { get; set; }
    public int TagId { get; set; }
    public Assignment Assignment { get; set; }
    public Tag Tag { get; set; } 
}
