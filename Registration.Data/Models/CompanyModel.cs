using System;
using System.Collections.Generic;
using System.Text;

namespace Registration.Data.Models
{
   public class CompanyModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string LegalForm { get; set; }
    }
}
