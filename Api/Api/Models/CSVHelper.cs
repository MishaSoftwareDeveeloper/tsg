using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;

namespace Api.Models
{
    public class CSVHelper
    {

        private DataTable ConvertCSVtoDataTable(string strFilePath)
        {
            DataTable dt = new DataTable();
            using (StreamReader sr = new StreamReader(strFilePath))
            {
                string[] headers = sr.ReadLine().Split(',');
                foreach (string header in headers)
                {
                    dt.Columns.Add(header);
                }
                while (!sr.EndOfStream)
                {
                    string[] rows = sr.ReadLine().Split(',');
                    DataRow dr = dt.NewRow();
                    for (int i = 0; i < headers.Length; i++)
                    {
                        dr[i] = rows[i];
                    }
                    dt.Rows.Add(dr);
                }

            }
            return dt;
        }

        private EnumData.Sensor getSensor(string name)
        {
            EnumData.Sensor sensor = 0;
            switch (name)
            {
                case "IKONOS":
                    sensor = EnumData.Sensor.IKONOS;
                    break;
                case "OGEN":
                    sensor = EnumData.Sensor.OGEN;
                    break;
                case "GEOEYE":
                    sensor = EnumData.Sensor.GEOEYE;
                    break;
                case "OFEK":
                    sensor = EnumData.Sensor.OFEK;
                    break;
            }
            return sensor;
        }


        public List<ImageMetadata> getMetadata()
        {
            List<ImageMetadata> output = new List<ImageMetadata>();
            //Get local path of project
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images_metadata.csv");
            DataTable csv = this.ConvertCSVtoDataTable(path);

            int increment = 0; //Increment id
            ImageMetadata imgData;
            try
            {
                foreach (DataRow item in csv.Rows)
                {
                    increment += 1;
                    imgData = new ImageMetadata
                    {
                        id = increment,
                        name = item["Name"].ToString(),
                        sensor = this.getSensor(item["Sensor"].ToString()),
                        x = Convert.ToDouble(item["X"]),
                        y = Convert.ToDouble(item["Y"]),
                        ClipX = Convert.ToDouble(item["ClipX"]),
                        ClipY = Convert.ToDouble(item["ClipY"]),
                        ClipW = Convert.ToDouble(item["ClipW"]),
                        ClipH = Convert.ToDouble(item["ClipH"]),
                    };
                    output.Add(imgData);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: get metadata {ex.Message}");
            }




            return output;

        }


    }
}