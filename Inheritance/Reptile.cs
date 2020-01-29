using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Reptile : Animal
    {
        public Reptile(string reptileName)
        {
            Name = reptileName;
        }
        public string Name { get; set; }
        public string ScaleColor { get; set; }

        public bool CanSwim { get; set; }

        public bool HasSplitTongue { get; set; }

        public string EggColor { get; set; }
    }
}
