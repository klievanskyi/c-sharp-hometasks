//Following SRP principle, the responsibility of the Customer class should be only the Register method. The Customer class should not worry with the definition of Validation Rules of the Email address and sending messages.

//Please change the class Customer and create the class MailService following the SRP principle.

namespace Task1
{
    class Customer
    {
        private MailService mailService;
        public void Register(string email, string password)
        {
            try
            {
                if(mailService.ValidEmail(email))
                {
                    mailService.SendEmail(email, "Email title", "Email body");
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }

    class MailService
    {
        public bool ValidEmail(string email)
        {
            return email.Contains("@");
        }

        public void SendEmail(string email, string emailTitle, string emailBody)
        {
            Console.WriteLine(string.Format("Mail:{0}, Title:{1}, Body:{2}", email, emailTitle, emailBody));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
