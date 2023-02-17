using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore
{
    internal interface ISpeakable
    {
       
        public string Speak();


    }
    internal interface INameable
    {
        public string Name { get; set; }
    }
    internal interface IPet : ISpeakable, INameable
    {

    }
}
