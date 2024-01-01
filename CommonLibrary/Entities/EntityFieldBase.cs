using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary.Entities
{
    public class EntityFieldBase
    {
        public Guid CreatedUser { get; set; }
        public DateTime CreatedTime { get; set; } = DateTime.Now;
        public Guid LastSaved { get; set; }
        public DateTime LastSavedTime { get; set; } = DateTime.Now;
    }
}
