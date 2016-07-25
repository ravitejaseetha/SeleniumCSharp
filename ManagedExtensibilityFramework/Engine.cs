using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagedExtensibilityFramework
{
    [Export]
    public class Engine : IParts
    {
        public void Start()
        {
            Console.WriteLine("Start the Engine :Engine");
        }
    }
}
