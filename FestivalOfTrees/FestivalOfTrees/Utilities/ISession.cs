using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestivalOfTrees.Utilities
{
    public interface ISession
    {
        Object getAttribute(string strKey);
        void setAttribute(string strKey, Object objValue);
        Object removeAttribute(string strKey);
    }
}
