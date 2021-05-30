using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

//=> RON,EUR,USD,GBP,CHF

namespace CasaSchimbValutar
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }


            //adaugam elementele in sqlite

            //void addObject()
            //{
            


                //private void add(object sender, EventArgs e)
                //{
                //    try
                //    {
                //        con.Open();
                //        string Query = "insert into sqliteDb(ID,Name) values('" + this.textBox1.Text + "','" + this.textBox2.Text + "')";

                //        SQLiteCommand cmd = new SQLiteCommand(Query, con);
                //        cmd.ExecuteNonQuery();
                //        con.close();
                //    }
                //    catch (Exception ex)
                //    {
                //        MessageBox.Show(ex.Message);
                //    }
                //}
            //}
    }

}
    

