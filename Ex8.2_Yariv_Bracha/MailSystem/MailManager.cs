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

        public void SimulateMailArrived(string mailTitle, string mailBody)
        {
            MailArrivedEventArgs mail = new MailArrivedEventArgs(mailTitle, mailBody);
            OnMailArrived(mail);
        }
    }

}

