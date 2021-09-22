using Registration.Data.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Registration.Data
{
  public  class CompanyProvider : ICompanyProvider
    {
        string connectionString = "Data Source=.; Initial Catalog=Registration;Integrated Security=True";

        public IEnumerable<CompanyModel> GetAllCompanies()
        {
            List<CompanyModel> companies = new List<CompanyModel>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("Select * from Companies", con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    CompanyModel company = new CompanyModel();
                    company.Id = Guid.Parse(rdr["Id"].ToString());
                    company.Name = rdr["Name"].ToString();
                    company.LegalForm = rdr["LegalForm"].ToString();

                    companies.Add(company);
                }
                con.Close();
            }
            return companies;
        }
    }
}
