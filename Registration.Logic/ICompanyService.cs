using Registration.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Registration.Logic
{
    public interface ICompanyService
    {
        IEnumerable<CompanyViewModel> GetCompanies();
        void Create(CompanyViewModel company);
    }
}
