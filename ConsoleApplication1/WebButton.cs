using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class WebButton : WebControl
    {
        public WebButton(Browser myBrowser)
            : base(myBrowser,LocatorType.Id, ControlType.Button)
            
        {

        }
        public IButton Button
        {
            get
            {
                return (IButton)Control;
            }
        }


        public new void Click()
        {
            Button.Click();
        }
    }
}
