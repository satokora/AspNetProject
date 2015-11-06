using FestivalOfTrees.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestivalOfTrees.Dao
{
    interface RequestDao
    {
        int createRequest(Request req);

        int updateRequest(Request req);

        List<Request> getRequestByEmail(string email);

        List<Request> getAllRequests();
    }
}
