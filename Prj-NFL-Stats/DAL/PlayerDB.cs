using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prj_NFL_Stats.BLL;
using System.Data.SqlClient;

namespace Prj_NFL_Stats.DAL
{
    class PlayerDB
    {
        public static void AddPlayer(Player p1)
        {

            // 1. Connection Object
            SqlConnection connDB = UtilityDB.ConnectDB();
            // 2. Create and Customize SqlCommand object
            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.Connection = connDB;
            cmdInsert.CommandText = "INSERT INTO Players (PlayerId, FirstName, LastName, Position, Team)" +
                              "VALUES (@PlayerId,@FirstName,@LastName, @Position, @Team)";
            cmdInsert.Parameters.AddWithValue("@PlayerId", Convert.ToInt32(p1.PlayerId));
            cmdInsert.Parameters.AddWithValue("@FirstName", p1.FirstName);
            cmdInsert.Parameters.AddWithValue("@LastName", p1.LastName);
            cmdInsert.Parameters.AddWithValue("@Position", p1.Position);
            cmdInsert.Parameters.AddWithValue("@Team", p1.Team);
            cmdInsert.ExecuteNonQuery();
            connDB.Close();




        }



        public static void AddPlayer2(Player p1)
        {

            // 1. Connection Object
            SqlConnection connDB = UtilityDB.ConnectDB();
            // 2. Create and Customize SqlCommand object
            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.Connection = connDB;
            cmdInsert.CommandText = "INSERT INTO Players2 (PlayerId, FirstName, LastName, Position, Team)" +
                              "VALUES (@PlayerId,@FirstName,@LastName, @Position, @Team)";
            cmdInsert.Parameters.AddWithValue("@PlayerId", Convert.ToInt32(p1.PlayerId));
            cmdInsert.Parameters.AddWithValue("@FirstName", p1.FirstName);
            cmdInsert.Parameters.AddWithValue("@LastName", p1.LastName);
            cmdInsert.Parameters.AddWithValue("@Position", p1.Position);
            cmdInsert.Parameters.AddWithValue("@Team", p1.Team);
            cmdInsert.ExecuteNonQuery();
            connDB.Close();




        }

        public static void AddPlayer3(Player p1)
        {

            // 1. Connection Object
            SqlConnection connDB = UtilityDB.ConnectDB();
            // 2. Create and Customize SqlCommand object
            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.Connection = connDB;
            cmdInsert.CommandText = "INSERT INTO Players3 (PlayerId, FirstName, LastName, Position, Team)" +
                              "VALUES (@PlayerId,@FirstName,@LastName, @Position, @Team)";
            cmdInsert.Parameters.AddWithValue("@PlayerId", Convert.ToInt32(p1.PlayerId));
            cmdInsert.Parameters.AddWithValue("@FirstName", p1.FirstName);
            cmdInsert.Parameters.AddWithValue("@LastName", p1.LastName);
            cmdInsert.Parameters.AddWithValue("@Position", p1.Position);
            cmdInsert.Parameters.AddWithValue("@Team", p1.Team);
            cmdInsert.ExecuteNonQuery();
            connDB.Close();




        }



        public static List<Player> GetQbs()
        {
            List<Player> listCrs = new List<Player>();
            SqlConnection conn = UtilityDB.ConnectDB();
            SqlCommand cmdSelect = new SqlCommand();


            try
            {

                cmdSelect.CommandText = "SELECT * FROM Players " +
                "WHERE Position ='QB'";

                cmdSelect.Connection = conn;
                SqlDataReader reader = cmdSelect.ExecuteReader();
                Player crs;

                while (reader.Read())
                {
                    crs = new Player();
                    crs.PlayerId = Convert.ToInt32(reader["PlayerId"].ToString());
                    crs.FirstName = reader["FirstName"].ToString();
                    crs.LastName = reader["LastName"].ToString();
                    crs.Position = reader["Position"].ToString();
                    crs.Team = reader["Team"].ToString();
                    listCrs.Add(crs);
                }

                reader.Close();


            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }

            return listCrs;

        }

        public static List<Player> GetRbs()
        {
            List<Player> listCrs = new List<Player>();
            SqlConnection conn = UtilityDB.ConnectDB();
            SqlCommand cmdSelect = new SqlCommand();


            try
            {

                cmdSelect.CommandText = "SELECT * FROM Players " +
                "WHERE Position ='RB' ";

                cmdSelect.Connection = conn;
                SqlDataReader reader = cmdSelect.ExecuteReader();
                Player crs;

                while (reader.Read())
                {
                    crs = new Player();
                    crs.PlayerId = Convert.ToInt32(reader["PlayerId"].ToString());
                    crs.FirstName = reader["FirstName"].ToString();
                    crs.LastName = reader["LastName"].ToString();
                    crs.Position = reader["Position"].ToString();
                    crs.Team = reader["Team"].ToString();
                    listCrs.Add(crs);
                }


            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }

            return listCrs;

        }


        public static List<Player> GetWrs()
        {
            List<Player> listCrs = new List<Player>();
            SqlConnection conn = UtilityDB.ConnectDB();
            SqlCommand cmdSelect = new SqlCommand();


            try
            {

                cmdSelect.CommandText = "SELECT * FROM Players " +
                "WHERE Position ='WR' ";

                cmdSelect.Connection = conn;
                SqlDataReader reader = cmdSelect.ExecuteReader();
                Player crs;

                while (reader.Read())
                {
                    crs = new Player();
                    crs.PlayerId = Convert.ToInt32(reader["PlayerId"].ToString());
                    crs.FirstName = reader["FirstName"].ToString();
                    crs.LastName = reader["LastName"].ToString();
                    crs.Position = reader["Position"].ToString();
                    crs.Team = reader["Team"].ToString();
                    listCrs.Add(crs);
                }

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }

            return listCrs;

        }


        public static List<Player> GetTEs()
        {
            List<Player> listCrs = new List<Player>();
            SqlConnection conn = UtilityDB.ConnectDB();
            SqlCommand cmdSelect = new SqlCommand();


            try
            {

                cmdSelect.CommandText = "SELECT * FROM Players " +
                "WHERE Position ='TE' ";

                cmdSelect.Connection = conn;
                SqlDataReader reader = cmdSelect.ExecuteReader();
                Player crs;

                while (reader.Read())
                {
                    crs = new Player();
                    crs.PlayerId = Convert.ToInt32(reader["PlayerId"].ToString());
                    crs.FirstName = reader["FirstName"].ToString();
                    crs.LastName = reader["LastName"].ToString();
                    crs.Position = reader["Position"].ToString();
                    crs.Team = reader["Team"].ToString();
                    listCrs.Add(crs);
                }

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }

            return listCrs;

        }

        public static List<Player> GetPlayers()
        {
            List<Player> listCrs = new List<Player>();
            SqlConnection conn = UtilityDB.ConnectDB();
            SqlCommand cmdSelect = new SqlCommand();


            try
            {

                cmdSelect.CommandText = "SELECT * FROM Players";

                cmdSelect.Connection = conn;
                SqlDataReader reader = cmdSelect.ExecuteReader();
                Player crs;

                while (reader.Read())
                {
                    crs = new Player();
                    crs.PlayerId = Convert.ToInt32(reader["PlayerId"].ToString());
                    crs.FirstName = reader["FirstName"].ToString();
                    crs.LastName = reader["LastName"].ToString();
                    crs.Position = reader["Position"].ToString();
                    crs.Team = reader["Team"].ToString();
                    listCrs.Add(crs);
                }

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }

            return listCrs;

        }

        public static Player GetRecord(int pID)
        {
            //Step 1: Connect the DB
            SqlConnection connDB = UtilityDB.ConnectDB();
            //Step 2: Perform INSERT Operation
            SqlCommand cmdSelect = new SqlCommand();
            //Parameterized Query
            cmdSelect.CommandText = "SELECT * FROM Players " +
                                    "WHERE PlayerId = @pId";

            cmdSelect.Parameters.AddWithValue("@pId", pID);
            cmdSelect.Connection = connDB;
            SqlDataReader reader = cmdSelect.ExecuteReader(); //Applied to SELECT
            Player p1 = new Player();
            if (reader.Read())
            {
                p1.PlayerId = Convert.ToInt32(reader["PlayerId"].ToString());
                p1.FirstName = reader["FirstName"].ToString();
                p1.LastName = reader["LastName"].ToString();
                p1.Position = reader["Position"].ToString();
                p1.Team = reader["Team"].ToString();
            }
            else
            {
                p1 = null;
            }




            return p1;
        }

        public static List<Player> GetPlayers2()
        {
            List<Player> listCrs = new List<Player>();
            SqlConnection conn = UtilityDB.ConnectDB();
            SqlCommand cmdSelect = new SqlCommand();


            try
            {

                cmdSelect.CommandText = "SELECT * FROM Players2";

                cmdSelect.Connection = conn;
                SqlDataReader reader = cmdSelect.ExecuteReader();
                Player crs;

                while (reader.Read())
                {
                    crs = new Player();
                    crs.PlayerId = Convert.ToInt32(reader["PlayerId"].ToString());
                    crs.FirstName = reader["FirstName"].ToString();
                    crs.LastName = reader["LastName"].ToString();
                    crs.Position = reader["Position"].ToString();
                    crs.Team = reader["Team"].ToString();
                    listCrs.Add(crs);
                }

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }

            return listCrs;

        }

        public static List<Player> GetPlayers3()
        {
            List<Player> listCrs = new List<Player>();
            SqlConnection conn = UtilityDB.ConnectDB();
            SqlCommand cmdSelect = new SqlCommand();


            try
            {

                cmdSelect.CommandText = "SELECT * FROM Players3";

                cmdSelect.Connection = conn;
                SqlDataReader reader = cmdSelect.ExecuteReader();
                Player crs;

                while (reader.Read())
                {
                    crs = new Player();
                    crs.PlayerId = Convert.ToInt32(reader["PlayerId"].ToString());
                    crs.FirstName = reader["FirstName"].ToString();
                    crs.LastName = reader["LastName"].ToString();
                    crs.Position = reader["Position"].ToString();
                    crs.Team = reader["Team"].ToString();
                    listCrs.Add(crs);
                }

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }

            return listCrs;

        }

        public static List<Player> GetTeamPlayers(string code)
        {
            List<Player> listCrs = new List<Player>();
            SqlConnection conn = UtilityDB.ConnectDB();
            SqlCommand cmdSelect = new SqlCommand();


            try
            {

                cmdSelect.CommandText = "SELECT * FROM Players " +
                "WHERE Team = @code ";

                cmdSelect.Connection = conn;
                cmdSelect.Parameters.AddWithValue("@code", code);
                SqlDataReader reader = cmdSelect.ExecuteReader();
                Player crs;

                while (reader.Read())
                {
                    crs = new Player();
                    crs.PlayerId = Convert.ToInt32(reader["PlayerId"].ToString());
                    crs.FirstName = reader["FirstName"].ToString();
                    crs.LastName = reader["LastName"].ToString();
                    crs.Position = reader["Position"].ToString();
                    crs.Team = reader["Team"].ToString();
                    listCrs.Add(crs);
                }

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }

            return listCrs;

        }

        public static List<PlayerTest> GetNewPlayers()
        {
            List<PlayerTest> listCrs = new List<PlayerTest>();
            SqlConnection conn = UtilityDB.ConnectDB();
            SqlCommand cmdSelect = new SqlCommand();


            try
            {

                cmdSelect.CommandText = "SELECT * FROM Players " +
                "WHERE Position ='FS'";

                cmdSelect.Connection = conn;
                SqlDataReader reader = cmdSelect.ExecuteReader();
                PlayerTest crs;

                while (reader.Read())
                {
                    crs = new PlayerTest();
                    crs.PlayerID = Convert.ToInt32(reader["PlayerId"].ToString());
                    crs.Name = reader["Name"].ToString();
                    crs.Team = reader["Team"].ToString();
                    listCrs.Add(crs);
                }

                reader.Close();


            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }

            return listCrs;

        }

    }


}
