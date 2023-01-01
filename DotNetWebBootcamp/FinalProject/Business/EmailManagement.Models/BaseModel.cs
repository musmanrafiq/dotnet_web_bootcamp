using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailManagement.Models
{
    public   class BaseModels
    {
        public DateTime CreatedOn { get; set; }
        public DateTime UpdateOn { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
}
