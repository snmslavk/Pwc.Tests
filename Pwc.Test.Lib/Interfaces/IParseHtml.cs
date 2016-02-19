using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pwc.Test.Lib.Models;

namespace Pwc.Test.Lib.Interfaces
{
    public interface IParseHtml
    {
        KisaErdModel FillModel(string htmlString);
        string GetResultTable(string htmlResponse);
    }
}
