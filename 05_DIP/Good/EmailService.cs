using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid._05_DIP.Good
{

    public interface IEmailService
    {
        void Send();
    }
    public class EmailService : IEmailService
    {
        public void Send()
        {
            Console.WriteLine("Sending Email");
        }
    }

    public class FakeEmailService : IEmailService
    {
        public void Send()
        {
            Console.WriteLine("Fake");
        }
    }

    public class UserService(IEmailService emailService)
    {

    }
}
