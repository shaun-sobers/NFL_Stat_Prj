using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prj_NFL_Stats.BLL;
using System.Data.SqlClient;

namespace Prj_NFL_Stats.DAL
{
    class TeamDB
    {
        public static List<Team> GetTeams()
        {
            List<Team> listTm = new List<Team>();
            SqlConnection conn = UtilityDB.ConnectDB();
            SqlCommand cmdSelect = new SqlCommand();


            try
            {

                cmdSelect.CommandText = "SELECT * FROM Teams";

                cmdSelect.Connection = conn;
                SqlDataReader reader = cmdSelect.ExecuteReader();
                Team tm;

                while (reader.Read())
                {
                    tm = new Team();
                    tm.TeamCode = reader["TeamCode"].ToString();
                    tm.Name = reader["TeamName"].ToString();
                    tm.ByeWeek = Convert.ToInt32(reader["ByeWeek"].ToString());
                    tm.City = reader["TeamCity"].ToString();
                    listTm.Add(tm);
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

            return listTm;

        }

        public static Team GetATeam(string tID)
        {
            //Step 1: Connect the DB
            SqlConnection connDB = UtilityDB.ConnectDB();
            //Step 2: Perform INSERT Operation
            SqlCommand cmdSelect = new SqlCommand();
            //Parameterized Query
            cmdSelect.CommandText = "SELECT * FROM Teams " +
                                    "WHERE TeamName = @name";

            cmdSelect.Parameters.AddWithValue("@name", tID);
            cmdSelect.Connection = connDB;
            SqlDataReader reader = cmdSelect.ExecuteReader(); //Applied to SELECT
            Team tm = new Team();
            if (reader.Read())
            {
                tm.City = reader["TeamCity"].ToString();
                tm.ByeWeek = Convert.ToInt32(reader["ByeWeek"]);
                tm.Name = reader["TeamName"].ToString();
                tm.TeamCode = reader["TeamCode"].ToString();
            }
            else
            {
                tm = null;
            }




            return tm;
        }

        public static Team GetATeamCode(string tID)
        {
            //Step 1: Connect the DB
            SqlConnection connDB = UtilityDB.ConnectDB();
            //Step 2: Perform INSERT Operation
            SqlCommand cmdSelect = new SqlCommand();
            //Parameterized Query
            cmdSelect.CommandText = "SELECT * FROM Teams " +
                                    "WHERE TeamCode = @name";

            cmdSelect.Parameters.AddWithValue("@name", tID);
            cmdSelect.Connection = connDB;
            SqlDataReader reader = cmdSelect.ExecuteReader(); //Applied to SELECT
            Team tm = new Team();
            if (reader.Read())
            {
                tm.City = reader["TeamCity"].ToString();
                tm.ByeWeek = Convert.ToInt32(reader["ByeWeek"]);
                tm.Name = reader["TeamName"].ToString();
                tm.TeamCode = reader["TeamCode"].ToString();
            }
            else
            {
                tm = null;
            }




            return tm;
        }
    }
}
