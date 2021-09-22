using Registration.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Registration.Data
{
    public interface ICompanyProvider
    {
        IEnumerable<CompanyModel> GetAllCompanies();
    }
}
