using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;  //la libreria de MySql
using System.Data; //la libreria del DataTable

namespace PruebaBBDD

{
    class Conexion
    {
        public MySqlConnection conexion;//variable que se encarga de conectarnos al servidor MySql

        public Conexion() // el constructor de la clase
        {
            conexion = new MySqlConnection("Server=127.0.0.1; Database=listaPokemons; Uid=root; Pwd=; Port=3306");
        }

        public DataTable getPokemons()
        {
            //como un if else pero para evitar errores
            try {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM pokemon", conexion);
                MySqlDataReader resultado = consulta.ExecuteReader(); //Guarda el resuldado de la quarry (consulta)
                DataTable pokemons = new DataTable(); // Formato que espera el datagridview
                pokemons.Load(resultado);
                conexion.Close();
                return pokemons;
                    
            }
            catch (MySqlException e){
                throw e;
            }

        }
        public DataTable getPokemonPorId(int _id)
        {
            //como un if else pero para evitar errores
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM pokemon WHERE id='" + _id + "'", conexion);
                MySqlDataReader resultado = consulta.ExecuteReader(); //Guarda el resuldado de la quarry (consulta)
                DataTable pokemons = new DataTable(); // Formato que espera el datagridview
                pokemons.Load(resultado);
                conexion.Close();
                return pokemons;

            }
            catch (MySqlException e)
            {
                throw e;
            }

        }

    }

}
