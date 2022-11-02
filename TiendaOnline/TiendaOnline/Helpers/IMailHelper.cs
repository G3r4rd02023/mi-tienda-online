using TiendaOnline.Common;

namespace TiendaOnline.Helpers
{
    public interface IMailHelper
    {
        Response SendMail(string toName, string toEmail, string subject, string body);
    }
}
