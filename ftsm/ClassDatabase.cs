using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ftsm
{
    class classDataBaseManager
    {
        public static string tipoUsuario = "";

        static string[] stringConexion = System.IO.File.ReadAllLines(@"" + System.Windows.Forms.Application.StartupPath + "\\conexion.txt");
        public static DataTable tablaBusqueda { get; set; }
        public static MySqlConnection _conn = new MySqlConnection(stringConexion[0]);
        public static DataTable tablaEquipos;
        public static string connectionStringTablaInsercion;
        public static OleDbConnection __connExcel;
        public static MySqlDataAdapter adapt;
        
        

        public static DataTable runSelectQuery(string query)
        {
            Console.WriteLine(query);
            DataTable tablaSelect = new DataTable();
            string sql = query;

            try
            {

                var comm = new MySqlCommand(sql, classDataBaseManager._conn);
                classDataBaseManager._conn.Open();
                classDataBaseManager.adapt = new MySqlDataAdapter(comm);
                MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(classDataBaseManager.adapt);
                classDataBaseManager.tablaBusqueda = new DataTable();
                classDataBaseManager.adapt.Fill(tablaSelect);
                classDataBaseManager._conn.Close();

                if (tablaSelect == null)
                {

                    return null;
                }
                else if (tablaSelect.Rows.Count < 1)
                {
                    return null;
                }

                return tablaSelect;

            }
            catch (Exception e)
            {
                classDataBaseManager.ManageException(e);
                Console.WriteLine(sql);
                return null;

            }
        }

        private static void ManageException(Exception e)
        {
            if (_conn.State == System.Data.ConnectionState.Open)
                _conn.Close();
            MessageBox.Show(e.ToString());
        }



        
    }

}

