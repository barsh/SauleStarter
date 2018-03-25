using Saule;

namespace SauleStarter.ApiResources
{
    public class CompanyResource : ApiResource
    {
        public CompanyResource()
        {
            Attribute("Name");
            Attribute("Location");
        }
    }
}