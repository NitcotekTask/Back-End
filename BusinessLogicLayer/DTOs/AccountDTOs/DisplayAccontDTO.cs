using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.DTOs.AccountDTOs
{
    public class DisplayAccontDTO
    {
        public Guid ID { get; set; }
        public string Number { get; set; } = null!;
        public string NameAR { get; set; } = null!;
    }
}
