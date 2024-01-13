using Microsoft.VisualBasic.FileIO;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using YaaryInvoiceElite.Domain;

namespace YaaryInvoiceElite
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string loginName = txt_UserName.Text;
            string password = txt_Password.Text;

            if ((loginName == "Kannan") && (password == "Mannai"))
            {
                LocationForm locationForm = new LocationForm();
                locationForm.ShowDialog();
                Close();
            }

            else
            {
                lbl_InvalidCred.Show();
                lbl_InvalidCred.Text = "The username or password you're trying to log in with might be incorrect";
            }
        }

        /*private void ImportAreaData()
        {
            SqlConnection sqlConnection;
            SqlCommand cmd;
            List<DmnAreaMap> lstAreaMap = new List<DmnAreaMap>();

            sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SKannan\source\repos\YaaryInvoiceElite\YaaryInvoiceElite\YarryDB.mdf;Integrated Security=True");
            sqlConnection.Open();

            cmd = new SqlCommand("delete from dmnAreaMap", sqlConnection);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception x)
            {
                MessageBox.Show(" Error deleting dmnAreaMap table");
            }

            finally
            {
                sqlConnection.Close();
            }

            using (TextFieldParser parser = new TextFieldParser(@"C:\Users\SKannan\source\repos\YaaryInvoiceElite\YaaryInvoiceElite\Chennai - Chennai-Areas.csv"))
            {

                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                while (!parser.EndOfData)
                {
                    DmnAreaMap dmnAreaMap = new DmnAreaMap();
                    string[] fields = parser.ReadFields();
                    dmnAreaMap.Area = fields[0];
                    dmnAreaMap.Fare = fields[1];
                    dmnAreaMap.Distance = fields[2];

                    lstAreaMap.Add(dmnAreaMap);
                }
            }

            sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SKannan\source\repos\YaaryInvoiceElite\YaaryInvoiceElite\YarryDB.mdf;Integrated Security=True");
            sqlConnection.Open();

            if (lstAreaMap != null && lstAreaMap.Count > 0)
            {
                int index = 0;
                foreach (DmnAreaMap map in lstAreaMap)
                {
                    index = index + 1;
                    string query = "INSERT INTO dmnAreaMap (Id, Area,Fare,Distance) VALUES(@Id, @Area, @Fare, @Distance)";
                    SqlCommand insertCmd = new SqlCommand(query, sqlConnection);

                    insertCmd.Parameters.Add("@Id", SqlDbType.Int).Value = index;
                    insertCmd.Parameters.Add("@Area", SqlDbType.VarChar, 50).Value = map.Area;
                    insertCmd.Parameters.Add("@Fare", SqlDbType.VarChar, 50).Value = map.Fare;
                    insertCmd.Parameters.Add("@Distance", SqlDbType.VarChar, 50).Value = map.Distance;

                    try
                    {
                        insertCmd.ExecuteNonQuery();

                    }
                    catch (SqlException e)
                    {
                        Console.WriteLine("Error Generated. Details: " + e.ToString());
                    }

                }
                sqlConnection.Close();
            }

            }*/
        }
    }