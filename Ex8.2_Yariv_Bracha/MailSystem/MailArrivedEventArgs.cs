using System;

namespace MailSystem
{
    class MailArrivedEventArgs : EventArgs
    {
        private string title;
        private string body;

        public MailArrivedEventArgs(string title, string body)
        {
            this.title = title;
            this.body = body;
        }

        public string Title
        {
            get { return title; }
        }

        public string Body
        {
            get { return body; }
        }
    }
}

