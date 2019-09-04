using System;
using System.Collections.Generic;
using System.Text;

namespace Legos.Minifigures.Parts
{
    class FatHead : Head
    {
        public FatHead()
        {
            Size = HeadSize.Fat;
        }

        public override void Think()
        {
            Console.WriteLine("I'm saddd my head is fat");
        }
    }
}
