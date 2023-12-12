using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPatterns.uj_design_patterns_assignments.builder
{
    internal class FormBuilder : IFormBuilder
    {
        private ButtonsBuilder btnBuilder;
        private WelcomeMessageBuilder wmsgBuilder;
        private Form f;

        public void constructForm()
        {
            f = new Form(wmsgBuilder.printWM(), btnBuilder.addButtons());
        }

        public void setButtonsBuilder(ButtonsBuilder bb)
        {
            btnBuilder = bb;
        }

        public void setWMBuilder(WelcomeMessageBuilder mb)
        {
            wmsgBuilder = mb;
        }
        public Form getForm()
        {
            return f;
        }

    }
}
