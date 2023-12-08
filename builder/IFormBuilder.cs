﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uj_design_patterns.uj_design_patterns_assignments.builder
{
    internal interface IFormBuilder
    {
        void constructForm();
        void setButtonsBuilder(ButtonsBuilder bb);
        void setWMBuilder(WelcomeMessageBuilder mb);
        Form getForm();

    }
}
