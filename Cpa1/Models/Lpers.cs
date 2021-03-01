using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Cpa1.Models
{
    public class Lpers

    {
        public void modifypers(Personne str)
        {
            string connectionstring = "Server=DESKTOP;Database=structure;Trusted_Connection=True;";
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                SqlCommand cmd = new SqlCommand("modifier3", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter paramcode = new SqlParameter();
                paramcode.ParameterName = "@code";
                paramcode.Value = str.code;
                cmd.Parameters.Add(paramcode);

                SqlParameter paramnom = new SqlParameter();
                paramnom.ParameterName = "@Nom";
                paramnom.Value = str.Nom;
                cmd.Parameters.Add(paramnom);

                SqlParameter paramprenom = new SqlParameter();
                paramprenom.ParameterName = "@Prenom";
                paramprenom.Value = str.Prenom;
                cmd.Parameters.Add(paramprenom);

                SqlParameter paramqualit = new SqlParameter();
                paramqualit.ParameterName = "@qualite";
                paramqualit.Value = str.qualite;
                cmd.Parameters.Add(paramqualit);
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (System.Data.SqlClient.SqlException)
                {


                }
            }



        }



            public void addpers(Personne str)
        { 
        string connectionstring = "Server=DESKTOP;Database=structure;Trusted_Connection=True;";
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                SqlCommand cmd = new SqlCommand("addpers", con);
               cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter paramcode = new SqlParameter();
                paramcode.ParameterName = "@code";
                paramcode.Value = str.code;
                cmd.Parameters.Add(paramcode);

                SqlParameter paramnom = new SqlParameter();
                paramnom.ParameterName = "@Nom";
                paramnom.Value = str.Nom;
                cmd.Parameters.Add(paramnom);

                SqlParameter paramprenom = new SqlParameter();
                paramprenom.ParameterName = "@Prenom";
                paramprenom.Value = str.Prenom;
                cmd.Parameters.Add(paramprenom);

                SqlParameter paramqualit = new SqlParameter();
                paramqualit.ParameterName = "@qualite";
                paramqualit.Value = str.qualite;
                cmd.Parameters.Add(paramqualit);
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch(System.Data.SqlClient.SqlException)
                {
    
                    
                }
             }
        }
        public IEnumerable<Personne> personnes
        {
            get
            {
                string connectionstring = "Server=DESKTOP;Database=structure;Trusted_Connection=True;";
                List<Personne> prs = new List<Personne>();
                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    SqlCommand cmd = new SqlCommand("getpers", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        Personne stru = new Personne();
                        stru.code = Convert.ToInt32(rdr["code"]);
                        stru.Nom = rdr["nom"].ToString();
                        stru.Prenom = rdr["prenom"].ToString();
                        stru.qualite = rdr["qualite"].ToString();
                        
                        prs.Add(stru);
                    }
                }
                return prs;
            }
        }




    }
}
