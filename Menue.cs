using System.Runtime.Intrinsics.Arm;
using SqlClient;

class Menue
{
    DataAccess db;

    public Menue()
    {
        db = new DataAccess();
    }

    public Dictionary<string,int> GetMenue()
    {
        return db.GetMenue();
    }
}