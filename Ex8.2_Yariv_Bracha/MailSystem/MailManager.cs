using System;

namespace MailSystem
{
    class MailManager
    {
        public event EventHandler<MailArrivedEventArgs> MailArrived;

        protected virtual void OnMailArrived(MailArrivedEventArgs e)
        {
            if (MailArrived != null)
            {
                MailArrived(this, e);
            }
        }

        public void SimulateMailArrived()
        {
            MailArrivedEventArgs firstMail = new MailArrivedEventArgs("This is first mail!", "first body mail");
            MailArrivedEventArgs secondMail = new MailArrivedEventArgs("This is second mail!", "second body mail");
            MailArrivedEventArgs thirdMail = new MailArrivedEventArgs("This is third mail!", "third body mail");
            MailArrivedEventArgs fourthMail = new MailArrivedEventArgs("This is fourth mail!", "fourth body mail");
            OnMailArrived(firstMail);
            OnMailArrived(secondMail);
            OnMailArrived(thirdMail);
            OnMailArrived(fourthMail);
        }
    }

}

