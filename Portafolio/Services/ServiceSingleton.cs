namespace Portafolio.Services
{
    public class ServiceSingleton
    {
        public Guid GetGuid { get; set; }

        public ServiceSingleton()
        {
            GetGuid = Guid.NewGuid();
        }
    }
}
