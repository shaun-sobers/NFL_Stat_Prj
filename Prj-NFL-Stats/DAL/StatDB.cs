using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prj_NFL_Stats.BLL;
using System.Data.SqlClient;

namespace Prj_NFL_Stats.DAL
{
    class StatDB
    {
        public static void AddStats(Stat st1)
        {

            // 1. Connection Object
            SqlConnection connDB = UtilityDB.ConnectDB();
            // 2. Create and Customize SqlCommand object
            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.Connection = connDB;
            cmdInsert.CommandText = "INSERT INTO Stats  (playerId, week, rushes, fumbles, rushingYards, rushingTouchDowns, targets, receptions, recievingYards, recievingTouchdowns, offensiveSnaps, passingYards, passingAttempts, passingCompletions, passingTouchdowns, sacks, interceptions)" +
                              "VALUES (@playerId, @week, @rushes,@fumble , @rushingYards, @rushingTouchDowns, @targets, @receptions, @recievingYards, @recievingTouchdowns, @offensiveSnaps, @passingYards, @passAttempts, @passCompletions, @passingTouchdowns, @sacks, @interceptions)";
            cmdInsert.Parameters.AddWithValue("@playerid", st1.PlayerId);
            cmdInsert.Parameters.AddWithValue("@week", st1.Week);
            cmdInsert.Parameters.AddWithValue("@rushes", st1.Rushes);
            cmdInsert.Parameters.AddWithValue("@rushingYards", st1.RushingYards);
            cmdInsert.Parameters.AddWithValue("@rushingTouchdowns", st1.RushingTouchDowns);
            cmdInsert.Parameters.AddWithValue("@targets", st1.Targets);
            cmdInsert.Parameters.AddWithValue("@receptions", st1.Receptions);
            cmdInsert.Parameters.AddWithValue("@recievingYards", st1.RecievingYards);
            cmdInsert.Parameters.AddWithValue("@recievingTouchdowns", st1.RecievingTouchdowns);
            cmdInsert.Parameters.AddWithValue("@offensiveSnaps", st1.OffensiveSnaps);
            cmdInsert.Parameters.AddWithValue("@passingYards", st1.PassingYards);
            cmdInsert.Parameters.AddWithValue("@passAttempts", st1.PassAttempts);
             cmdInsert.Parameters.AddWithValue("@passCompletions", st1.PassCompletions);
            cmdInsert.Parameters.AddWithValue("@passingTouchdowns", st1.PassingTouchdowns);
            cmdInsert.Parameters.AddWithValue("@sacks", st1.Sacks);
            cmdInsert.Parameters.AddWithValue("@interceptions", st1.Interceptions);
            cmdInsert.Parameters.AddWithValue("@fumble", st1.Fumbles);
            cmdInsert.ExecuteNonQuery();
            connDB.Close();




        }


        public static List<Stat> GetPlayerStats(int pId)
        {
            List<Stat> listPs = new List<Stat>();
            SqlConnection conn = UtilityDB.ConnectDB();
            SqlCommand cmdSelect = new SqlCommand();


            try
            {

                cmdSelect.CommandText = "SELECT * FROM Stats " +
                "WHERE PlayerId  =  @pid ";

                cmdSelect.Connection = conn;
                cmdSelect.Parameters.AddWithValue("@pId", pId);
                SqlDataReader reader = cmdSelect.ExecuteReader();
                Stat S1;

                while (reader.Read())
                {
                    S1 = new Stat();


                    S1.PlayerId = Convert.ToInt32(reader["PlayerId"].ToString());
                    S1.Rushes = Convert.ToInt32(reader["Rushes"].ToString());
                    S1.RushingYards = Convert.ToInt32(reader["RushingYards"].ToString());
                    S1.RushingTouchDowns = Convert.ToInt32(reader["RushingTouchdowns"].ToString());
                    S1.Targets = Convert.ToInt32(reader["Targets"].ToString());
                    S1.Receptions = Convert.ToInt32(reader["Receptions"].ToString());
                    S1.RecievingYards = Convert.ToInt32(reader["RecievingYards"].ToString());
                    S1.RecievingTouchdowns = Convert.ToInt32(reader["RecievingTouchdowns"].ToString());
                    S1.OffensiveSnaps = Convert.ToInt32(reader["OffensiveSnaps"].ToString());
                    S1.PassingYards = Convert.ToInt32(reader["PassingYards"].ToString());
                    S1.PassAttempts = Convert.ToInt32(reader["PassingAttempts"].ToString());
                    S1.PassCompletions = Convert.ToInt32(reader["PassingCompletions"].ToString());
                    S1.PassingTouchdowns = Convert.ToInt32(reader["PassingTouchdowns"].ToString());
                    S1.Sacks = Convert.ToInt32(reader["Sacks"].ToString());
                    S1.Interceptions = Convert.ToInt32(reader["Interceptions"].ToString());
                    S1.Fumbles = Convert.ToInt32(reader["Fumbles"].ToString());
                    S1.Week = Convert.ToInt32(reader["Week"].ToString());

                    listPs.Add(S1);
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

            return listPs;

        }
    }
}
