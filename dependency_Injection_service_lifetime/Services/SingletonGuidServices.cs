namespace dependency_Injection_service_lifetime.Services
{
    public class SingletonGuidServices : ISingletonGuidServices
    {
        private readonly string id;
        public SingletonGuidServices() 
        {
            id = Guid.NewGuid().ToString();
        }
        public string GetGuid()
        {
            return id;
        }
    }
}
