﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Statistics
{
    public class LEDAlert : IAlerter
    {
        public bool ledGlows;

        public void SendAlert()
        {
            this.ledGlows = true;
        }
    }
}
