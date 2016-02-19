using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pwc.Test.Lib.Models;
using System.Collections.Specialized;

namespace Pwc.Test.Lib.Interfaces
{
    public interface IWebClientHelper
    {
        string PostData(IKisaErdModel model, string url);
        string GetData(string url);
    }
    

}
