using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoenixOnWheels.Models
{
    public class Client : BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public bool BlackListed { get; set; }
        public bool RedListed { get; set; }

        // lista de documentos de identidad

        public List<string> Comments { get; set; }
    }
}
