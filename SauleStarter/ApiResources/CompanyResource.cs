using Saule;

namespace SauleStarter.ApiResources
{
    public class CompanyResource : ApiResource
    {
        public CompanyResource()
        {
            WithId("ID");
            Attribute("Name");
            Attribute("Location");
        }
    }
}