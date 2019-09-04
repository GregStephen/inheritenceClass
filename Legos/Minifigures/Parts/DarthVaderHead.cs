using System;
using System.Collections.Generic;
using System.Text;

namespace Legos.Minifigures.Parts
{
    class DarthVaderHead : Head
    {
        public DarthVaderHead()
        {

        }

        public override void Talk()
        {
            Console.WriteLine("Khooooh Puuuhrr");
            base.Talk();
            Console.WriteLine("Khooooh Puuuhrr");
        }
        public override void Think()
        {
            Console.WriteLine("Am I your father?");
        }
    }
}
