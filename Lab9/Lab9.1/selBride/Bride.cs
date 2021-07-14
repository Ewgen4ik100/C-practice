using selBride.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace selBride
{
    public class Bride
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }
        public int Growth { get; set; }
        public Alcohol Alcohol { get; set; }
        public Smoking Smoking { get; set; }
        public BodyType BodyType { get; set; }
        public int Priority { get; set; } = 0;
    }
}
