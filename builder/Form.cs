using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uj_design_patterns.uj_design_patterns_assignments.builder
{
    internal class Form
    {
        private readonly string _wmessage;
        private Button button;

        public Form(string wm, Button btn)
        {
            _wmessage = wm;
            button = btn;
        }

        public void ShowForm()
        {
            Console.WriteLine(_wmessage);
            button.Click();
        }
    }
}
