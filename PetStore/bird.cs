using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore
{
    internal class Bird : IPet
    {
            public string Name { get; set; }
            public string Speak()
            {
            return "tweet!";
            }
            public void DontFlyAway()
            {

            }
            public void DontCrossTheRoad()
            {

            }
        
    }
}
