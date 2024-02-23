using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Specialized;
using Microsoft.IdentityModel.Protocols;
using Microsoft.Identity.Client;

namespace SqlClient{

    public class DataAccess
    {
        public List<Dish> GetDish(string dish)
        {
            throw new NotImplementedException();
        }
        public Dictionary<string, int> GetMenue()
        {
            throw new NotImplementedException();
        }
    }
}