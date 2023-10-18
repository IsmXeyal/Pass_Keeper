using System.Net.Mail;
using System.Net;

namespace Pass_Keeper.Models;

public class NetWork
{
    public static void SendNotification(string toadmin, Notification notification)
    {
        SmtpClient smtp = new()
        {
            Host = "smtp.gmail.com",
            Port = 587,
            UseDefaultCredentials = false,
            Credentials = new NetworkCredential("bossconsoleaz@gmail.com", "olijoozcvknqalsy"),
            DeliveryMethod = SmtpDeliveryMethod.Network,
            EnableSsl = true
        };

        MailAddress FromEmail = new MailAddress("bossconsoleaz@gmail.com", "PassKeeper");
        MailAddress ToEmail = new MailAddress(toadmin, "Khayal Ismayilov");

        MailMessage message = new MailMessage()
        {
            From = FromEmail,
            Subject = notification.Title,
            Body = notification.Text
        };

        message.To.Add(ToEmail);

        try
        {
            smtp.Send(message);
        }
        catch (SmtpException ex)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"\n\n  An error occurred: {ex.Message}      \n\n\n\t\t\t\t\t  Press any key to continue... ");
            Console.ResetColor();
        }
    }
}
