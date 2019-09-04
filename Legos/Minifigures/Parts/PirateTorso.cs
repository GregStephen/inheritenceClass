using System;
using System.Collections.Generic;
using System.Text;

namespace Legos.Minifigures.Parts
{
    class PirateTorso : Torso
    {
        public override bool ChestHair => true;

        public PirateTorso(HandType handType)
        {
            Shirt = "Froofy with ruffles";
            HandType = handType;

        }

        public void Flex()
        {
            Console.WriteLine("The pirate torso flexed swashbucklingly");
        }

        public void Fight()
        {
            Console.WriteLine("The pirate torso waves a sword around");
        }
    }

    enum HandType
    {
        Regular,
        Hook,
        None
    }
}
