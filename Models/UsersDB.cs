using System.Data;
using System.Data.SqlClient;

namespace RealEstateMVC.Models
{
    public class UsersDB //connectionclass
    {
        SqlConnection con = new SqlConnection("server=ZHOME\\SQLEXPRESS; database=RealEstateDB;Integrated Security=true");
        
        public string InsertDB(Userscls objcls) //modelclass obj
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_userInsert", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@userfna", objcls.ufname);
                cmd.Parameters.AddWithValue("@userlna", objcls.ulname);
                cmd.Parameters.AddWithValue("@useremail", objcls.email);
                cmd.Parameters.AddWithValue("@userphone", objcls.phone);
                cmd.Parameters.AddWithValue("@useruname", objcls.username);
                cmd.Parameters.AddWithValue("@userpwd", objcls.password);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return ("Inserted Successfully");

            }
            catch(Exception ex) 
            {
                if(con.State==ConnectionState.Open)
                {
                    con.Close();
                }
                return ex.Message.ToString();
            }
        }
    }
}
