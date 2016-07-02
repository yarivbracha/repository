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
            MailArrivedEventArgs mail = new MailArrivedEventArgs("simulate mail - title", "simulate mail - body");
            OnMailArrived(mail);
        }
    }

}

