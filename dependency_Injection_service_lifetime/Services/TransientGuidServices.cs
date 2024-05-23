namespace dependency_Injection_service_lifetime.Services
{
    public class TransientGuidServices : ITransientGuidServices
    {
        private readonly Guid id;
        public TransientGuidServices() 
        {
            id = Guid.NewGuid();
        }
        public string GetGuid()
        {
            return id.ToString();
        }

        
    }
}
