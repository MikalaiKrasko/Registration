using Registration.Data;
using Registration.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Registration.Logic
{
    public class CompanyService : ICompanyService
    {
        private ICompanyProvider _companyProvider;

        public CompanyService(
            ICompanyProvider companyProvider)
        {
            _companyProvider = companyProvider;
        }
        public IEnumerable<CompanyViewModel> GetCompanies()
        {
            var companies = _companyProvider.GetAllCompanies();
            var result = new List<CompanyViewModel>();
            foreach (var c in companies)
            {
                result.Add(new CompanyViewModel
                {
                    Id = c.Id,
                    Name = c.Name,
                    LegalForm = c.LegalForm,
                    NumberOfWorkers = 2 //calculate NumberOfWorkers
                });
            }
            return result;
        }

        public void Create(CompanyViewModel company)
        {

        }

    }
}
