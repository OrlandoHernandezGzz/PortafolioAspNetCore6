using Portafolio.Models;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace Portafolio.Services
{
	public class ServiceEmailSendGrid : IServiceEmail
	{
		private readonly IConfiguration configuration;

		public ServiceEmailSendGrid(IConfiguration configuration)
		{
			this.configuration = configuration;
		}

		public async Task Send(ContactViewModel contact)
		{
			var apiKey = configuration.GetValue<string>("SENDGRID_API_KEY");
			var email = configuration.GetValue<string>("SENDGRID_FROM");
			var name = configuration.GetValue<string>("SENDGRID_NAME");

			var client = new SendGridClient(apiKey);
			var from = new EmailAddress(email, name);
			var subject = $"El cliente {contact.Email} quiere contactarte";
			var to = new EmailAddress(email, name);
			var message = contact.Message;

			var contentHtml = @$"De: {contact.Name} - Email: {contact.Email} - Mensaje: {contact.Message}";

			var singleEmail = MailHelper.CreateSingleEmail(from, to, subject, message, contentHtml);

			var respuesta = await client.SendEmailAsync(singleEmail);

		}

	}
}
