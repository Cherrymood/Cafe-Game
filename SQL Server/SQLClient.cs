using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SqlClient{
    public class Menue
    {
        public int MenueID {get; set;}
        public string MenueName {get; set;}
        public int Price {get; set;}
        public string MenueDescription {get; set;}
        public override string ToString()
        {
            return string.Format("MenueID: {0}, MenueName: {1}, Price: {2}, MenueDescription: {3}",
                MenueID, MenueName, Price, MenueDescription);
        }
    }
}