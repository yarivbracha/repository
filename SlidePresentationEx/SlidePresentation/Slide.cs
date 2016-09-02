using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlidePresentation
{
    public class Slide
    {
        public string Header { get; set; }
        public List<string> Bullets { get; set; }

        public Slide()
        {
            Header = "Wpf!!!";
            Bullets.Add("first sentence");
            Bullets.Add("second sentence");
            Bullets.Add("last sentence");
        }

        public void AddBullet(string bullet)
        {
            Bullets.Add(bullet);
        }

        public void RemoveBullet(string bullet)
        {
            Bullets.Remove(bullet);
        }
    }
}
