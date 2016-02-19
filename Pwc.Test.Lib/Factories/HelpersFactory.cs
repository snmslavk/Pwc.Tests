using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pwc.Test.Lib;
using Pwc.Test.Lib.Interfaces;
using Pwc.Test.Lib.Models;

namespace Pwc.Test.Lib.Factories
{
    public class HelpersFactory : AbstractHelpersFactory
    {
        public override IParseHtml GetParseHtmlHelper()
        {
            return new ParseHtml();
        }
        public override ICoreFuncs GetCoreFuncsHelper()
        {
            return new CoreFuncs();
        }
        public override IKisaErdModel GetKisaErdModel()
        {
            return new KisaErdModel();
        }
        public override IWebClientHelper GetWebClientHelper()
        {
            return new WebClientRoutine();
        }
    }
}
