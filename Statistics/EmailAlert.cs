using System;
using System.Collections.Generic;
using System.Text;

namespace Statistics
{
    public class EmailAlert : IAlerter
    {
        public bool emailSent;

        public void SendAlert()
        {
            this.emailSent = true;
        }
    }
}
