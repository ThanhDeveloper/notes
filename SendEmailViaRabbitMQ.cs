// Create a connection factory
var factory = new ConnectionFactory() { HostName = "localhost" };

// Create a connection
using (var connection = factory.CreateConnection())
{
    // Create a channel
    using (var channel = connection.CreateModel())
    {
        // Declare a queue for the message
        channel.QueueDeclare(queue: "email", durable: false, exclusive: false, autoDelete: false, arguments: null);
    }
}

//create send email function
private static void SendEmail(string to, string subject, string body)
{
    // Create an email address object for the sender
    MailAddress sender = new MailAddress("sender@example.com", "Sender Name");

    // Create an email address object for the recipient
    MailAddress recipient = new MailAddress(to, "Recipient Name");

    // Create a mail message object
    MailMessage message = new MailMessage(sender, recipient);

    // Set the subject and message body of the email
    message.Subject = subject;
    message.Body = body;

    // Set the server and credentials for sending the email
    SmtpClient smtpClient = new SmtpClient("smtp.example.com");
    NetworkCredential credentials = new NetworkCredential("username", "password");
    smtpClient.Credentials = credentials;

    // Send the email
    smtpClient.Send(message);
}

// Create a connection factory
var factory = new ConnectionFactory() { HostName = "localhost" };

// Create a connection
using (var connection = factory.CreateConnection())
{
    // Create a channel
    using (var channel = connection.CreateModel())
    {
        // Declare a queue for the message
        channel.QueueDeclare(queue: "email", durable: false, exclusive: false, autoDelete: false, arguments: null);

        // Create a message consumer
        var consumer = new EventingBasicConsumer(channel);

        // Set up a handler for received messages
        consumer.Received += (model, ea) =>
        {
            var body = ea.Body;
            var message = Encoding.UTF8.GetString(body);
            Console.WriteLine("Received message: {0}", message);

            // Parse the message to get the email details
            var parts = message.Split('|');
            var to = parts[0];
            var subject = parts[1];
            var body = parts[2];

            // Send the email
            SendEmail(to, subject, body);
        };

       // Start consuming messages
channel.BasicConsume(queue: "email", autoAck: true, consumer: consumer);

// Wait for messages
Console.WriteLine("Press any key to exit.");
 console.ReadKey();
 


