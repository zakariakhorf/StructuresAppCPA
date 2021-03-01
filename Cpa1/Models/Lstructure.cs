using Habanero.Faces.Base;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Xceed.Wpf.Toolkit;
using System.Web;
using System.Linq;
 
namespace Cpa1.Models
{
    public class lstructure
    {
        public structuse verifier(int code)
        {
            bool codeuse = false;
            string connectionstring = "Server=DESKTOP;Database=structure;Trusted_Connection=True;";
            using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    SqlCommand cmd = new SqlCommand("ex", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlParameter paramcode = new SqlParameter();
                    paramcode.ParameterName = "@code";
                    paramcode.Value = code;
                    cmd.Parameters.Add(paramcode); 

                    con.Open();
                codeuse = Convert.ToBoolean(cmd.ExecuteScalar());
                structuse co = new structuse();
                co.code = code;
                co.codeuse = codeuse;
                return co;

        }

         }
       

















        public IEnumerable<structure> Structures
        {
            get
            {
                string connectionstring = "Server=DESKTOP;Database=structure;Trusted_Connection=True;";
         List<structure> structures = new List<structure>();
                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    SqlCommand cmd = new SqlCommand("getall", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        structure stru = new structure();
                        stru.code = Convert.ToInt32(rdr["code"]);
                        stru.abr = rdr["abreviation"].ToString();
                        stru.desig = rdr["designation"].ToString();
                        stru.adr = rdr["adresse"].ToString();
                        stru.telephone = (rdr["telephone"]).ToString();
                        stru.fax = (rdr["fax"]).ToString();
                        stru.IDattaché = Convert.ToInt32(rdr["idattache"]); 
                        stru.IDpersonne = Convert.ToInt32(rdr["idpersonne"]);
                        structures.Add(stru);
                    }
                }
                return structures ;
            }
        }  
        
        public void addstructure(structure str)
        {
            string connectionstring = "Server=DESKTOP;Database=structure;Trusted_Connection=True;";
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                SqlCommand cmd = new SqlCommand("addall", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter paramcode = new SqlParameter();
                paramcode.ParameterName = "@code";
                paramcode.Value = str.code;
                cmd.Parameters.Add(paramcode);

                SqlParameter paramabr = new SqlParameter();
                paramabr.ParameterName = "@abr";
                paramabr.Value = str.abr;
                cmd.Parameters.Add(paramabr);

                SqlParameter paramdesig = new SqlParameter();
                paramdesig.ParameterName = "@desig";
                paramdesig.Value = str.desig;
                cmd.Parameters.Add(paramdesig);

                SqlParameter paramadr = new SqlParameter();
                paramadr.ParameterName = "@adr";
                paramadr.Value = str.adr;
                cmd.Parameters.Add(paramadr);

                SqlParameter paramtel = new SqlParameter();
                paramtel.ParameterName = "@telephone";
                paramtel.Value = str.telephone;
                cmd.Parameters.Add(paramtel);

                SqlParameter paramfax = new SqlParameter();
                paramfax.ParameterName = "@fax";
                paramfax.Value = str.fax;
                cmd.Parameters.Add(paramfax);

                SqlParameter paramatt = new SqlParameter();
                paramatt.ParameterName = "@idattaché";
                paramatt.Value = str.IDattaché;
                cmd.Parameters.Add(paramatt);

                SqlParameter parampers = new SqlParameter();
                parampers.ParameterName = "@idpersonne";
                parampers.Value = str.IDpersonne;
                cmd.Parameters.Add(parampers);

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
        public void modifystructure(structure str,int id)
        {
            string connectionstring = "Server=DESKTOP;Database=structure;Trusted_Connection=True;";
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                SqlCommand cmd = new SqlCommand("modifier11", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter paraml = new SqlParameter();
                paraml.ParameterName = "@nligne";
                paraml.Value = id;
                cmd.Parameters.Add(paraml);

                SqlParameter paramcode = new SqlParameter();
                paramcode.ParameterName = "@code";
                paramcode.Value = str.code;
                cmd.Parameters.Add(paramcode);

                SqlParameter paramabr = new SqlParameter();
                paramabr.ParameterName = "@abr";
                paramabr.Value = str.abr;
                cmd.Parameters.Add(paramabr);

                SqlParameter paramdesig = new SqlParameter();
                paramdesig.ParameterName = "@desig";
                paramdesig.Value = str.desig;
                cmd.Parameters.Add(paramdesig);

                SqlParameter paramadr = new SqlParameter();
                paramadr.ParameterName = "@adr";
                paramadr.Value = str.adr;
                cmd.Parameters.Add(paramadr);

                SqlParameter paramtel = new SqlParameter();
                paramtel.ParameterName = "@telephone";
                paramtel.Value = str.telephone;
                cmd.Parameters.Add(paramtel);

                SqlParameter paramfax = new SqlParameter();
                paramfax.ParameterName = "@fax";
                paramfax.Value = str.fax;
                cmd.Parameters.Add(paramfax);

                SqlParameter paramatt = new SqlParameter();
                paramatt.ParameterName = "@idattaché";
                paramatt.Value = str.IDattaché;
                cmd.Parameters.Add(paramatt);

                SqlParameter parampers = new SqlParameter();
                parampers.ParameterName = "@idpersonne";
                parampers.Value = str.IDpersonne;
                cmd.Parameters.Add(parampers);

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
    }
}
    

