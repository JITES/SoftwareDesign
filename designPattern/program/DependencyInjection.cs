using System;
using System.Collections.Generic;
using System.Text;

namespace designPattern.program
{
    class DependencyInjection
    {
        public void Implementation()
        {
            IOCSpellChecker engCheck = new IOCSpellChecker();
            TextWriter t = new TextWriter(engCheck);

        }
    }
    class IOCSpellChecker
    {

    }
    class TextWriter
    {
        private IOCSpellChecker checker;

        public TextWriter(IOCSpellChecker check)
        {
            this.checker = check;
        }

        public void CheckSpelling() => _ = "This is Checker";
       
    }
}
