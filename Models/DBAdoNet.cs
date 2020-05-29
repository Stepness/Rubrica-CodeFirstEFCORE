using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace PlayGround_Dependency_Injection
{
    public class DBAdoNet
    {
        /*
        * ***************************************************************************************
        * *** Definizione della classe che utilizzo per effettuare tutti gli accessi al database.
        * ***************************************************************************************
        */
        private const string StringaDiConnessione = "Data Source=Desktop-Eve;Initial Catalog=RubricaTest;User ID=sa;Password=Pa$$w0rd1!";

        public DataTable MySelect(string SqlString)
        {

            /*           
            * ***************************************************************************************
            * *** Metodo per avviare una query sul DB.
            * ***************************************************************************************
            */
            
            // Definisco l'oggetto per eseguire la connessione al DB
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = StringaDiConnessione;

            // Definisco l'oggetto con cui eseguire il comando
            SqlCommand cmd = new SqlCommand();

            SqlDataReader reader;     //Oggetto che mi ritorna la tabella dove ho fatto la select
            DataTable RecordLetti = new DataTable();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = SqlString;
            cmd.Connection = conn;

            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();
                RecordLetti.Load(reader);

                // Data is accessible through the DataReader object here.
            }
            catch //(Exception)
            {
                //ErroreMySelect = "Attenzione !! Errore durante l'esecuzione della query nel Db";
                throw new Exception();
            }
            finally
            {
                // Comunque forzo la chiusura della connessione per non lasc iare memoria impegnata

                conn.Close();
            }

            return RecordLetti;
        }
    }
}