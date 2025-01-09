using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Core.Entities.Basep;
public abstract class BaseEntity
{
    public int Id { get; set; }
    public bool IsDeleted { get; set; } 
    public DateTime CreatedTime { get; set; }   
}
