using Portafolio.Models;

namespace Portafolio.Services
{
	public interface IServiceEmail
	{
		Task Send(ContactViewModel contact);
	}
}
