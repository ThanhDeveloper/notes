using System;
using System.Net;
using System.Net.Mail;

namespace SendEmailExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an email address object for the sender
            MailAddress sender = new MailAddress("sender@example.com", "Sender Name");

            // Create an email address object for the recipient
            MailAddress recipient = new MailAddress("recipient@example.com", "Recipient Name");

            // Create a mail message object
            MailMessage message = new MailMessage(sender, recipient);

            // Set the subject and message body of the email
            message.Subject = "Hello from C#";
            message.Body = "This is an email message sent from C#.";

            // Set the server and credentials for sending the email
            SmtpClient smtpClient = new SmtpClient("smtp.example.com");
            NetworkCredential credentials = new NetworkCredential("username", "password");
            smtpClient.Credentials = credentials;

            // Send the email
            smtpClient.Send(message);

            Console.WriteLine("Email sent!");
        }
    }
}
