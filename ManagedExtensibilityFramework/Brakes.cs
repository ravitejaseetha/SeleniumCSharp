using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagedExtensibilityFramework
{
    [Export]
    public class Brakes : IParts
    {
        public void Stop()
        {
            Console.WriteLine("Stop the car : Brakes");
        }
    }
}
