using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlidePresentation
{
    public class Presentation
    {

        public List<Slide> Slides { get; set; }

        public void AddSlide(Slide slide)
        {
            Slides.Add(slide);
        }
    }
}
