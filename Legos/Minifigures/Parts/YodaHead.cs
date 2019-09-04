using System;
using System.Collections.Generic;
using System.Text;

namespace Legos.Minifigures.Parts
{
    class YodaHead : Head
    {
        public bool HasEars => true;

        public YodaHead()
        {
            Size = HeadSize.Small;
        }

        public override void Talk()
        {
            Console.WriteLine("Talking head I am");
        }

        public override void Think()
        {
            Console.WriteLine("Fuck yeah I'm Yoda");
        }
    }
}
