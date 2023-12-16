namespace Portafolio.Services
{
    public class ServiceTransient
    {
        public Guid GetGuid { get; set; }

        public ServiceTransient()
        {
            GetGuid = Guid.NewGuid();
        }
    }
}
