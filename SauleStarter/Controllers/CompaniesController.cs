using System.Collections.Generic;
using System.Web.Http;
using SauleStarter.ApiResources;
using SauleStarter.Resources;
using Saule.Http;

namespace SauleStarter.Controllers
{
    public class CompaniesController : ApiController
    {
        [Route("api/companies")]
        //[ReturnsResource(typeof(CompanyResource))]
        // prior line results in: 
        //      - http error 406 if request via browser
        //      - http error 500 if request via postman with header: 'Accept: application/vnd.api+json' 
        public IEnumerable<Company> Get()
        {
            var companies = new List<Company>();
            for (var i = 0; i < 100; i++)
            {
                companies.Add(new Company
                {
                    Name = "Company" + i,
                    Location = "Location of Company" + i
                });
            }
            return companies;
        }
    }
}
