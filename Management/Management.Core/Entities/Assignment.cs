using Management.Core.Entities.Basep;
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

}
