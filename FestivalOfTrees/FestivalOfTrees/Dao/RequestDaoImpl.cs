using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FestivalOfTrees.Model;
using System.Data.SqlClient;

namespace FestivalOfTrees.Dao
{
    public class RequestDaoImpl : RequestDao
    {
        public int createRequest(Request req)
        {
            int admin = 0, committee = 0, donor = 0;
            if (req.Admin)
                admin = 1;
            if (req.Committee)
                committee = 1;
            if (req.Donor)
                donor = 1;
            SqlConnection conn = DBHelper.loadDB();
            string query = "INSERT INTO REQUEST OUTPUT INSERTED.ID VALUES ("
                    + "'" + req.RequestEmail + "'"
                    + ", " + admin
                    + ", '" + committee
                    + ", " + donor
                    + ") ";
            SqlCommand command = new SqlCommand(query, conn);
            int id = (int)command.ExecuteScalar();
            req.RequestID = id;
            return id;
        }

        public List<Request> getAllRequests()
        {
            throw new NotImplementedException();
        }

        public List<Request> getRequestByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public int updateRequest(Request req)
        {
            throw new NotImplementedException();
        }
    }
}