using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace AzmanSys
{
    class customerDbConn: dbConn
    {
        public void insertCustomer(string CusFName, string CusLName, string CusTelNum)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "INSERT INTO `tblCustomer` (`CusID`, `CusFName`, `CusLName`, `CusTelNum`) VALUES (NULL,@CusFName, @CusLName, @CusTelNum);";
            comm.Parameters.AddWithValue("@CusFName", CusFName);
            comm.Parameters.AddWithValue("@CusLName", CusLName);
            comm.Parameters.AddWithValue("@CusTelNum", CusTelNum);
            comm.ExecuteNonQuery();
            connClose();
        }


        public void updateCustomer(string CusID, string FName, string LName, string Tel)
        {
                   
          MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "UPDATE `tblCustomer` SET `CusFName`=@CusFName,`CusLName`=@CusLName,`CusTelNum`=@CusTelNum WHERE CusID=@CusID";
           // comm.Parameters.AddWithValue("@CusID", CusID);
            comm.Parameters.AddWithValue("@CusFName", FName);
            comm.Parameters.AddWithValue("@CusLName", LName);
            comm.Parameters.AddWithValue("@CusTelNum", Tel);
            comm.Parameters.AddWithValue("@CusID", CusID);
            comm.ExecuteNonQuery();
            connClose();
            //shoib
        }

        public void deleteCustomer(string CusID)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "DELETE FROM `tblCustomer` WHERE CusID = @CusID";
            comm.Parameters.AddWithValue("@CusID", CusID);
            comm.ExecuteNonQuery();
            connClose();
        }
    }
}
