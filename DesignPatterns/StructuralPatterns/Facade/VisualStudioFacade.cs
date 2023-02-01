using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanningPatterns.DesignPatterns.StructuralPatterns.Facade
{
    internal class VisualStudioFacade
    {
        TextEditor textEditor;
        Compiller compiller;
        CLR crl;

        public VisualStudioFacade(TextEditor textEditor, Compiller compiller, CLR crl)
        {
            this.textEditor = textEditor;
            this.compiller = compiller;
            this.crl = crl;
        }

        public void Start()
        {
            textEditor.CreateCode();
            textEditor.Save();
            compiller.Compile();
            crl.Execute();
        }
        public void Stop()
        {
            crl.Finish();
        }
    }
}
