using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestivalOfTrees.Utilities
{
    public interface ISessionManager
    {
        string createSessionId();
        ISession getSession(string strSesId);
        ISession removeSession(string strSesId);
    }
}
