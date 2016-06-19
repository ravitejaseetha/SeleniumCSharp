using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISampleNew
{
    public class WebControl
    {
        public static IControl con;
        public static IControl Control
        {
            get
            {
                return con;
            }
        }

        public static void Click()
        {
            Control.Click();
        }
    }
}
