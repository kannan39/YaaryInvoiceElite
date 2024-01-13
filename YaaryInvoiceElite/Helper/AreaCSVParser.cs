using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaaryInvoiceElite.Domain;

namespace YaaryInvoiceElite.Helper
{

    public class AreaDTO
    {
        public Dictionary<string, DmnAreaMap> areaMapDict {  get;set ; }

        public List<DmnAreaMap> lstAreaMap { get; set; }
    }
    public static class AreaCSVParser
    {
        public static AreaDTO GetdmnAreaMap()
        {

            AreaDTO areaDTO = new AreaDTO();

            Dictionary<string, DmnAreaMap> dictAreaMap = new Dictionary<string, DmnAreaMap>();
            List<DmnAreaMap> lstAreaMap = new List<DmnAreaMap>();

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

                    dictAreaMap.Add(dmnAreaMap.Area, dmnAreaMap);
                }
            }

            areaDTO.areaMapDict = dictAreaMap;
            areaDTO.lstAreaMap = lstAreaMap;    
            return areaDTO;
        }
    }
}
