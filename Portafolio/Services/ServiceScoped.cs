namespace Portafolio.Services
{
    public class ServiceScoped
    {
        public Guid GetGuid { get; set; }

        public ServiceScoped()
        {
            GetGuid = Guid.NewGuid();
        }
    }
}
