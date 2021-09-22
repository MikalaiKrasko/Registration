using System;

namespace Registration.ViewModels
{
    public class WorkerViewModel
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public DateTime EmploymentDate { get; set; }
        public string Position { get; set; }
        public CompanyViewModel Company { get; set; }
    }
}
