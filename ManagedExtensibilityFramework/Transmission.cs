using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagedExtensibilityFramework
{
    [Export]
    public class Transmission : IParts
    {
        public void ShiftUp()
        {
            Console.WriteLine("Shift up : Transmission");
        }
    }
}
