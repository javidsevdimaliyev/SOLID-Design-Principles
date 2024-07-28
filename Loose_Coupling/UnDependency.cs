using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loose_Coupling_Dependency;
class MailSender
{
    public void SendMail(string email)
    {
        //Gmail gmail = new();
        //gmail.Send(email);

        //Tough Coupling
        Hotmail hotmail = new();
        hotmail.SendHotmail(email);
    }
}
class Gmail
{
    public Gmail()
    {

    }
    public void Send(string to)
    {
        //...
    }
}
class Hotmail
{
    public void SendHotmail(string to)
    {
        //...
    }
}