using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid._05_DIP.Bad
{


    public class EmailService
    {
        public void Send() 
        {
        
        }
    }

    public class UserService(EmailService service)
    {

    }
}
