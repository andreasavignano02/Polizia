using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Polizia.Models
{
    public class Anagrafe
    {
        [Display(Name = "Anagrafica")]
        public int IdAnagrafica { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Indirizzo { get; set; }
        public string City { get; set; }
        public string CodiceFiscale { get; set;}
        public int IdVerbale { get; set; }

        [Display(Name = "Violazioni")]
        public int IDVerbale { get; set; }
        public string Violazioni { get; set; }
        public static List<Anagrafe> GetAllAnagrafie() 
        { 
            List<Anagrafe> anagrafia = new List<Anagrafe>();
            SqlConnection con = SharedClass.GetConnectionDb();
            try 
            { 
                con.Open();
                SqlDataReader reader = SharedClass.GetReaderAfterSQL("Select * from Anagrafica inner join Violazioni on Anagrafica.IdVerbale = Violazioni.IDVerbale", con);
                if (reader.HasRows) 
                { 
                    while(reader.Read()) 
                    {
                        Anagrafe anagrafe = new Anagrafe
                        {
                            IdAnagrafica = Convert.ToInt32(reader["IDAnagrafica"]),
                            Cognome = reader["Cognome"].ToString(),
                            Nome = reader["Nome"].ToString(),
                            Indirizzo = reader["Indirizzo"].ToString(),
                            City = reader["Città"].ToString(),
                            CodiceFiscale= reader["CodiceFiscale"].ToString(),
                            IdVerbale = Convert.ToInt32(reader["IdVerbale"])
                        };
                        anagrafia.Add(anagrafe);
                    }
                }
            }
            catch(Exception ex) 
            { }
            con.Close();    
            return anagrafia;
            
        }
        
    }
}