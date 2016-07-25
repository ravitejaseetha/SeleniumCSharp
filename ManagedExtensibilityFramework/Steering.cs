using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagedExtensibilityFramework
{
    [Export]
    public class Steering : IParts
    {
        public void Left()
        {
            Console.WriteLine("Turn Left: Steering");
        }
    }
}
