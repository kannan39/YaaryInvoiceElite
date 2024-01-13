using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YaaryInvoiceElite.Domain;
using YaaryInvoiceElite.Helper;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace YaaryInvoiceElite
{
    public partial class LocationForm : Form
    {
        public static string SelectedArea = "";
        SqlConnection sqlConnection;
        SqlCommand cmd;
        SqlDataReader reader;
        SqlDataAdapter adapter;

        List<DmnAreaMap> lstAreaMap = new List<DmnAreaMap>();
        Dictionary<string, DmnAreaMap> dictAreaMap = new Dictionary<string, DmnAreaMap>();


        public LocationForm()
        {
            InitializeComponent();

            AreaDTO areaDTO = new AreaDTO();
            areaDTO = AreaCSVParser.GetdmnAreaMap();

            lstAreaMap = areaDTO.lstAreaMap;
            dictAreaMap = areaDTO.areaMapDict;


            this.comboBoxToLocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxToLocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            comboBoxToLocation.DataSource = lstAreaMap.Select(areaMap => areaMap.Area).ToList();

            this.comboBoxToLocation.SelectedIndexChanged += new System.EventHandler(ComboBox1_SelectedIndexChanged);
        }

        //private void GetdmnAreaMap()
        //{

        //    using (TextFieldParser parser = new TextFieldParser(@"C:\Users\SKannan\source\repos\YaaryInvoiceElite\YaaryInvoiceElite\Chennai - Chennai-Areas.csv"))
        //    {

        //        parser.TextFieldType = FieldType.Delimited;
        //        parser.SetDelimiters(",");
        //        while (!parser.EndOfData)
        //        {
        //            DmnAreaMap dmnAreaMap = new DmnAreaMap();
        //            string[] fields = parser.ReadFields();
        //            dmnAreaMap.Area = fields[0];
        //            dmnAreaMap.Fare = fields[1];
        //            dmnAreaMap.Distance = fields[2];

        //            lstAreaMap.Add(dmnAreaMap);

        //            dictAreaMap.Add(dmnAreaMap.Area, dmnAreaMap);
        //        }
        //    }
        //}

        private void ComboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {

            string selectedArea = (string)comboBoxToLocation.SelectedItem;

            int count = 0;
            int resultIndex = -1;

            DmnAreaMap dmnAreaMap = new DmnAreaMap();
            dmnAreaMap = dictAreaMap[selectedArea.Trim()];

            lblDistanceValue.Text = dmnAreaMap.Distance.ToString();
            lblFareValue.Text = dmnAreaMap.Fare.ToString();

            SelectedArea = selectedArea;
        }

        private void txtFromLocation_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnGenerateToken_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(SelectedArea);
            form3.Show();
        }

        private void LocationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
