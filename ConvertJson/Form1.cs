using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace ConvertJson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private string text = "";
        private OpenFileDialog openFileDialog = new OpenFileDialog();
        private void btn_path_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Json file| *.json";
            openFileDialog.Title = "Chọn file json";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                path.Text = openFileDialog.FileName;
                int d = 0;

                FileStream file = new FileStream(@path.Text, FileMode.Open, FileAccess.ReadWrite);
                text = new StreamReader(file).ReadToEnd();
                file.Close();
                if (text[0] != '[')
                {
                    int z = text.Length;
                    for (int i = text.Length - 1; i >= 0; i--)
                    {
                        if (d < 3)
                        {
                            if (text[i] == '}')
                            {
                                d++;
                            }
                        }
                        else { text = text.Remove(i, z - i - 3); break; }
                    }
                    text = text.Remove(0, 1);
                    text = "[" + text;
                    text = text.Remove(text.Length - 1, 1);
                    text = text + "]";

                    for (int i = 0; i < text.Length - 3; i++)
                    {
                        if ("" + text[i] + text[i + 2] == "\"" + "\"")
                        {
                            text = text.Remove(i, 5);
                            i = i - 5;
                        }
                    }

                    File.WriteAllText(path.Text, text);
                    MessageBox.Show("Chọn nơi lưu file Excel");
                    saveDialog();
                    

                }
                else
                {
                    MessageBox.Show("Chọn nơi lưu file Excel");
                    saveDialog();
                    btn_open.Enabled = true;
                }
            }

        }

        private void btn_copy_Click(object sender, EventArgs e)        {
            System.Diagnostics.Process.Start(@tb.Text);
        }

        public static void jsonStringToCSV(string jsonContent, string pathSave)
        {
            //used NewtonSoft json nuget package
            XmlNode xml = JsonConvert.DeserializeXmlNode("{records:{record:" + jsonContent + "}}");
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.LoadXml(xml.InnerXml);
            XmlReader xmlReader = new XmlNodeReader(xml);
            DataSet dataSet = new DataSet();
            dataSet.ReadXml(xmlReader);
            DataTable dataTable = dataSet.Tables[0];

            //Datatable to CSV
            List<string> lines = new List<string>();
            string[] columnNames = dataTable.Columns.Cast<DataColumn>().
                                              Select(column => column.ColumnName).
                                              ToArray();
            string header = string.Join(",", columnNames);
            lines.Add(header);
            EnumerableRowCollection<string> valueLines = dataTable.AsEnumerable()
                               .Select(row => string.Join(",", row.ItemArray));
            lines.AddRange(valueLines);
            File.WriteAllLines(@pathSave, lines);
        }

        void saveDialog()
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog
            {
                Filter = "Excel file|*.csv",
                Title = "Lưu file excel"
            };
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                jsonStringToCSV(text, saveFileDialog1.FileName);

            }
            tb.Text = saveFileDialog1.FileName;
        }



    }
}
