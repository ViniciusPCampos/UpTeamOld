using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Twilio.Clients;
using Twilio.Http;

namespace UPTEAM.Infra.CrossCutting.Identity.Configuration
{
    public class SmsService : IIdentityMessageService
    {
        public Task SendAsync(IdentityMessage message)
        {
            // Utilizando TWILIO como SMS Provider.
            // https://www.twilio.com/docs/quickstart/csharp/sms/sending-via-rest

            const string accountSid = "SEU ID";
            const string authToken = "SEU TOKEN";

            var client = new TwilioRestClient(accountSid, authToken);

            client.Request(new Request(HttpMethod.Post, ""));

            return Task.FromResult(0);
        }
    }
}