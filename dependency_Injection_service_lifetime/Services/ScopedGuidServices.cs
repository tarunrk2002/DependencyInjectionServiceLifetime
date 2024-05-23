namespace dependency_Injection_service_lifetime.Services
{
    public class ScopedGuidServices : IScopedGuidServices
    {
        private readonly Guid id;
        public ScopedGuidServices() 
        {
            id = Guid.NewGuid();
        }
        public string GetGuid()
        {
            return id.ToString();
        }
    }
}
