using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pwc.Test.Lib.Interfaces;




namespace Pwc.Test.Lib.Factories
{
    public abstract class AbstractHelpersFactory
    {
        public abstract IParseHtml GetParseHtmlHelper();
        public abstract ICoreFuncs GetCoreFuncsHelper();
        public abstract IKisaErdModel GetKisaErdModel();
        public abstract IWebClientHelper GetWebClientHelper();
    }
}
