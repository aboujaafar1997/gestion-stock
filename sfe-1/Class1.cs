using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace WindowsFormsApplication1
{
    class Class1
    {
        static public List<top_bare> b = new List<top_bare>();
        static public int index;
       static public chate ch = new chate();
        static public MySqlConnection cn = new MySqlConnection("server = 127.0.0.1; port=3306; database= sfe; uid=root; password=");
        static public MySqlDataAdapter adapter = new MySqlDataAdapter();
        static public MySqlCommand cmd = new MySqlCommand();
        static public int fin = 0;
        public static String sha256(string hach ) {
           SHA1CryptoServiceProvider objimplsercry = new SHA1CryptoServiceProvider();
            Byte[] bytestring = System.Text.Encoding.ASCII.GetBytes(hach);
            bytestring = objimplsercry.ComputeHash(bytestring);
        String finalstring = "";
            foreach (Byte bt in bytestring) { 
                finalstring = finalstring+  bt.ToString();
            }
            return finalstring;
    }
    }
}
