using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISample
{
    public class WebControl
    {
        private IControl con;
        private IControl Control
        {
            get
            {
                return con;
            }
        }

        public void Click()
        {
            Control.Click();
        }
    }
}
