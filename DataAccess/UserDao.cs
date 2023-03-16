using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Cache;

namespace DataAccess
{
    public class UserDao : ConnectionToSql
    {
        public bool Login(string user, string pass)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using(var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select  *from NhanVien where TaiKhoan = @user and MatKhau = @pass";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    //command.Parameters.AddWithValue("@id", UserLoginCache.MaNV);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UserLoginCache.MaNV = reader.GetString(0);
                            UserLoginCache.HoTen = reader.GetString(3);
                            UserLoginCache.ChucVu = reader.GetString(4);
                            UserLoginCache.Email = reader.GetString(5);
                            UserLoginCache.DiaChi = reader.GetString(6);
                            UserLoginCache.SDT = reader.GetString(7);
                            UserLoginCache.Luong = reader.GetDouble(8);
                        }
                        return true;
                    }
                    else
                    {

                        return false;
                    }
                }
            }
        }
    }
}
