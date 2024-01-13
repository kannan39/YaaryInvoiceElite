using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YaaryInvoiceElite.Domain;
using YaaryInvoiceElite.Helper;

namespace YaaryInvoiceElite
{
    public partial class Form3 : Form
    {
        List<DmnAreaMap> lstAreaMap = new List<DmnAreaMap>();
        Dictionary<string, DmnAreaMap> dictAreaMap = new Dictionary<string, DmnAreaMap>();

        public Form3(string selectedArea)
        {
            AreaDTO areaDTO = new AreaDTO();
            areaDTO = AreaCSVParser.GetdmnAreaMap();

            lstAreaMap = areaDTO.lstAreaMap;
            dictAreaMap = areaDTO.areaMapDict;

            DmnAreaMap dmnAreaMap = dictAreaMap[selectedArea];

            InitializeComponent();

            SqlConnection sqlConnection;
            SqlCommand cmd;

            sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SKannan\source\repos\YaaryInvoiceElite\YaaryInvoiceElite\YarryDB.mdf;Integrated Security=True");
            sqlConnection.Open();


            string query = "INSERT INTO InvoiceToken (TokenNumber, FromLocation,ToLocation,Distance, Fare, BookingFee, InsertedDateTime) " +
                                   "VALUES(@TokenNumber, @FromLocation, @ToLocation, @Distance, @Fare, @BookingFee, @InsertedDateTime)";
            SqlCommand insertCmd = new SqlCommand(query, sqlConnection);

            Random generator = new Random();
            String randomSixDigit = generator.Next(0, 1000000).ToString("D6");

            insertCmd.Parameters.Add("@TokenNumber", SqlDbType.VarChar, 50).Value = randomSixDigit;
            insertCmd.Parameters.Add("@FromLocation", SqlDbType.VarChar, 50).Value = "Kilabakkam";
            insertCmd.Parameters.Add("@ToLocation", SqlDbType.VarChar, 50).Value = dmnAreaMap.Area;
            insertCmd.Parameters.Add("@Distance", SqlDbType.VarChar, 50).Value = dmnAreaMap.Distance;
            insertCmd.Parameters.Add("@Fare", SqlDbType.VarChar, 50).Value = dmnAreaMap.Fare;
            insertCmd.Parameters.Add("@BookingFee", SqlDbType.Int).Value = 5;
            insertCmd.Parameters.Add("@InsertedDateTime", SqlDbType.DateTime).Value = DateTime.Now;

            try
            {
                insertCmd.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                Console.WriteLine("Error Generated. Details: " + e.ToString());
            }


            sqlConnection.Close();

            lblTokenNoValue.Text = randomSixDigit;
            lblFromLocationValue.Text = "Kilabakkam";
            lblToLocationValue.Text = dmnAreaMap.Area;
            lblDistanceValue.Text = dmnAreaMap.Distance;
            lblFareValue.Text = dmnAreaMap.Fare;

        }

        Bitmap memoryImage;

        private void btnPrint_Click(object sender, EventArgs e)
        {
            CaptureScreen();
            printDocument1.Print();
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printPreviewDialog1.ShowDialog();
        }


        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void lblForm2SelectedArea_Click(object sender, EventArgs e)
        {

        }

    }
}

