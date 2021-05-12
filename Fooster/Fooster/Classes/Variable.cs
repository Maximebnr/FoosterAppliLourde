using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Collections.ObjectModel;

namespace Fooster.Classes
{
    static class Variable
    {
        //static public String ChaineConnexion = "btsinfo-rousseau53.fr;port=33019;user=2021-fooster;password=lefosterVaMa53;database=2021-fooster_MaximeDBB";
        //Chaîne Distance

        static public String ChaineConnexion = "server=127.0.0.1;port=3306;user=root;database=fooster";
        // Chaîne Locale

        // Création de la connexion
        static public MySqlConnection GestEPOKAConn = new MySqlConnection(ChaineConnexion);



    }
}
