using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Bird : Animal
    {
        public Bird(string birdName)
        {
            Name = birdName;
        }
        public string Name { get; set; }
        public string BeakColor { get; set; }
        public string FeatherColor { get; set; }

        public bool CanFly { get; set; }

        public bool DoMigrate { get; set; }
    }
}
