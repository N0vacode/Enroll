using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enroll.src
{
    // Class For general services, or uses on many clases.
    public class Services
    {


        public static void LoadDataToGridView(String filePath, DataGridView dataGridView)
        {


            DataTable data = new DataTable();
            string[] lines = System.IO.File.ReadAllLines(filePath);
            if (lines.Length > 0)
            {

                // first line to create header
                string firstLine = lines[0];
                string[] headerLabels = firstLine.Split(',');
                foreach (string headerWord in headerLabels)
                {
                    data.Columns.Add(new DataColumn(headerWord));
                }
                //For Data
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] dataWords = lines[i].Split(',');
                    DataRow dr = data.NewRow();
                    int columnIndex = 0;
                    foreach (string headerWord in headerLabels)
                    {
                        dr[headerWord] = dataWords[columnIndex++];
                    }
                    data.Rows.Add(dr);
                }

            }

            if (data.Rows.Count > 0)
            {

                dataGridView.DataSource = data;

            }

        }

        public static void InsertValuesToDataBase(String filePath, String data) {
            // Read Daba Base From Path
            StreamWriter saveData = File.AppendText(filePath);
            // Write Data On File
            saveData.WriteLine(data);

            // Close File
            saveData.Close();
        }

        public static bool IsEmpty(String obj) => String.IsNullOrEmpty(obj);

        public static void LoadDataToComboBox(String pathDataBase, ComboBox comboBox, int index)
        {
            StreamReader sr = new StreamReader(pathDataBase);
            List<string> entity = new List<string>();
            int lineNumber = 1;
            while (!sr.EndOfStream)
            {
                var EachRow = sr.ReadLine();
                var Columns = EachRow.Split(',');
                if (lineNumber != 1)
                {
                    entity.Add(Columns[index]);
                }
                lineNumber++;
            }
            entity = entity.Distinct().ToList();
            foreach (var projectName in entity)
            {
                comboBox.Items.Add(projectName);
            }
        }

    }
}
