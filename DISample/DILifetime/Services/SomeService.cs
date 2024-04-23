namespace DILifetime.Services
{
    public class SomeService : ITransientService, IScopeService, ISingletonService
    {
        readonly Guid _id;
        public SomeService()
        {
            _id = Guid.NewGuid();
        }
        public Guid GetId()
        {
            return _id;
        }
    }
}
