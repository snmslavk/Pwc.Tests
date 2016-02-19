using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pwc.Test.Lib.Models;

namespace Pwc.Test.Lib.Interfaces
{
    public interface ICoreFuncs
    {
        KisaErdModel GetIndexModel();
        string PostData(IKisaErdModel model);
    }
}
