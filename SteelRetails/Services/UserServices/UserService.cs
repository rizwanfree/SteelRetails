using SteelRetails.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBFramework;
using SteelRetails.Utilities;
using System.Windows.Forms;

namespace SteelRetails.Services.UserServices
{
    public class UserService
    {
        DBSQLServer db = new DBSQLServer(AppSetting.ConnectionString());

        // Create (Insert) operation
        public void InsertUser(object userObject)
        {
            try
            {
                db.InsertOrUpdateRecord("uspUser_Insert", userObject);
                MessageBox.Show("User Added Successfully.", "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Read (Select) operation
        public DataTable GetUserById(int id)
        {            
            DBParameter para = new DBParameter { Parameter = "@Id", Value = id };

            try
            {
                return db.GetDataList("uspUser_GetUserById", para);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        // Update operation
        public void UpdateUser(object userObject)
        {
            try
            {
                db.InsertOrUpdateRecord("uspUser_UpdateUser", userObject);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                
            }
        }

        // Delete operation
        public void DeleteUser(int id)
        {
            DBParameter para = new DBParameter { Parameter = "@Id", Value = id };
            try
            {
                db.DeleteRecord("uspUser_DeleteUser", para);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Login Details
        public DataTable LoginUser(string username, string password)
        {
            List<DBParameter> paras = new List<DBParameter>();
            DBParameter user = new DBParameter { Parameter = "username", Value = username };
            DBParameter pass = new DBParameter { Parameter = "password", Value = password };
            paras.Add(user);
            paras.Add(pass);
            try
            {
                DataTable dt = db.GetDataList("uspUser_CheckLoginDetails", paras.ToArray());
                if (dt.Rows.Count > 0)  return dt;
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
    }
}

