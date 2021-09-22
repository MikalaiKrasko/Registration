using System;
using System.Collections.Generic;
using System.Text;

namespace Registration.ViewModels
{
   public class CompanyViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberOfWorkers { get; set; }
        public string LegalForm { get; set; }
    }
}
