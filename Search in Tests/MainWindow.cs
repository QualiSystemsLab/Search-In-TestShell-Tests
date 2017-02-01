using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.XPath;

namespace Search_in_Tests
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            exportBtn.Enabled = false;
            groupBox1.Enabled = false;
            searchBtn.Enabled = false;

            DataTable dt = new DataTable();
            dt.Columns.Add("Test Name", typeof(String));
            dt.Columns.Add("Test Path", typeof(String));
            dt.Columns.Add("Name", typeof(bool));
            dt.Columns.Add("Description", typeof(bool));
            dt.Columns.Add("Variables", typeof(bool));
            dt.Columns.Add("Variable Description", typeof(bool));
            dt.Columns.Add("Steps", typeof(bool));
            dt.Columns.Add("Step Description", typeof(bool));
            dt.Columns.Add("Method", typeof(bool));

            dataGridView1.DataSource = null;
            
            if (localChk.Checked)
            {
                string rootPath = localRoot.Text;
                string []files;

                if (localSubfolders.Checked == false)
                {
                    files = Directory.GetFiles(rootPath,"*.tstest");
                }
                else
                {
                    files = Directory.GetFiles(rootPath, "*.tstest", SearchOption.AllDirectories);                    
                }

                progressBar1.Maximum = files.Length;
                progressBar1.Minimum = 0;
                progressBar1.Value = 0;

                foreach (string f in files)
                {
                    progressBar1.Value++;
                    if (f.EndsWith("tstest") == false) continue;

                    string test = null;
                    bool name = false;
                    bool description = false;
                    bool variable = false;
                    bool step = false;
                    bool vardesc = false;
                    bool stepdesc = false;
                    bool method = false;

                    AnalyzeTest(f, ref test, ref name, ref description, ref step, ref vardesc, ref stepdesc, ref method);

                    if (name || description || variable || step || vardesc || stepdesc || method)
                    {
                        dt.Rows.Add(new object[] { Path.GetFileNameWithoutExtension(f), f, name, description, variable, vardesc, step, stepdesc, method });
                    }

                }
            }
            if (sharedChk.Checked)
            {

            }

            dataGridView1.DataSource = dt;

            if (dt.Rows.Count > 0) exportBtn.Enabled = true;
            groupBox1.Enabled = true;
            searchBtn.Enabled = true;
        }

        private void AnalyzeTest(string f, ref string test, ref bool name, ref bool description, ref bool step, ref bool vardesc, ref bool stepdesc, ref bool method)
        {
            test = File.ReadAllText(f).Replace("xmlns=\"http://www.qualisystems.com/\"", "");

            XmlDocument xmldoc = new XmlDocument();
            xmldoc.LoadXml(test);

            if (nameChk.Checked)
            {
                if (Path.GetFileNameWithoutExtension(f).Contains(searchString.Text))
                {
                    name = true;
                }
            }

            if (descriptionChk.Checked)
            {
                string s = test.Substring(test.IndexOf("Key=\"Description") + 25);
                s = s.Substring(0, s.IndexOf("\">"));
                s = s.Replace("_x0020_", " ").Replace("_x000D_", "\r").Replace("_x000A_", "\n");

                if (s.Contains(searchString.Text))
                {
                    description = true;
                }
            }

            if (varChk.Checked)
            {
                string s = test.Substring(test.IndexOf("<Array Key=\"Variables\" ElementType=\"IVariable\">"));
                s = s.Substring(0, s.IndexOf("<List Key=\"Steps\" ElementType=\"Step\">"));
                s = s.Replace("_x0020_", " ").Replace("_x000D_", "\r").Replace("_x000A_", "\n");

                Regex r = new Regex("<String Key=\"Name\" Value=\".*" + searchString.Text + ".*\">");
                if (r.IsMatch(s))
                {
                    description = true;
                }
            }

            if (varDscrChk.Checked)
            {
                string s = test.Substring(test.IndexOf("<Array Key=\"Variables\" ElementType=\"IVariable\">"));
                s = s.Substring(0, s.IndexOf("<List Key=\"Steps\" ElementType=\"Step\">"));
                s = s.Replace("_x0020_", " ").Replace("_x000D_", "\r").Replace("_x000A_", "\n");

                Regex r = new Regex("<String Key=\"Description\" Value=\".*" + searchString.Text + ".*\">");
                if (r.IsMatch(s))
                {
                    vardesc = true;
                }
            }

            if (stepsChk.Checked)
            {
                string s = test.Substring(test.IndexOf("<List Key=\"Steps\" ElementType=\"Step\">"));
                s = s.Substring(0, s.IndexOf("</TestInfo>"));
                s = s.Replace("_x0020_", " ").Replace("\r", "").Replace("\n", "").Replace("\t", "").Replace("_x000D_", "\r").Replace("_x000A_", "\n");

                Regex r = new Regex("Key=\"Tool\">.*?Key=\"Name\" Value=\"(.*?)\"");
                MatchCollection mc = r.Matches(s);
                foreach (Match m in mc)
                {
                    if (m.Groups[1].ToString().Contains(searchString.Text))
                    {
                        step = true;
                    }
                }

            }

            if (stepsDscrChk.Checked)
            {
                string s = test.Substring(test.IndexOf("<List Key=\"Steps\" ElementType=\"Step\">"));
                s = s.Substring(0, s.IndexOf("</TestInfo>"));
                s = s.Replace("_x0020_", " ").Replace("\r", "").Replace("\n", "").Replace("\t", "").Replace("_x000D_", "\r").Replace("_x000A_", "\n");

                Regex r = new Regex("Key=\"Tool\">.*?Key=\"Description\" Value=\"(.*?)\"");
                MatchCollection mc = r.Matches(s);
                foreach (Match m in mc)
                {
                    if (m.Groups[1].ToString().Contains(searchString.Text))
                    {
                        stepdesc = true;
                    }
                }

            }

            if (methodChk.Checked)
            {
                XmlNodeList nodes = xmldoc.SelectNodes("//MetadataMethodInfo[@Key=\"MethodInfo\"]/String[@Key=\"Name\"]/@Value");
                foreach (XmlNode node in nodes)
                {
                    if (node != null && node.Value.Contains(searchString.Text))
                    {
                        method = true;
                        break;
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            localRoot.Text = Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + @"\TestShell Files\Tests";
        }

        private void browseLocal_Click(object sender, EventArgs e)
        {
            if (localRoot.Text.Length > 0)
                folderBrowserDialog1.SelectedPath = localRoot.Text;
            else
                folderBrowserDialog1.SelectedPath = Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + @"\TestShell Files\Tests";

            folderBrowserDialog1.ShowNewFolderButton = false;
            
            if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                localRoot.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "CSV Files (*.csv)|";
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string filename = saveFileDialog1.FileName;
                if (filename.ToLower().EndsWith(".csv") == false)
                    filename += ".csv";

                SaveDataGridViewToCSV(filename);
            }
        }

        private void SaveDataGridViewToCSV(string filename)
        {
            // Save the current state of the clipboard so we can restore it after we are done
            IDataObject objectSave = Clipboard.GetDataObject();

            // Choose whether to write header. Use EnableWithoutHeaderText instead to omit header.
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            // Select all the cells
            dataGridView1.SelectAll();
            // Copy (set clipboard)
            Clipboard.SetDataObject(dataGridView1.GetClipboardContent());
            // Paste (get the clipboard and serialize it to a file)
            File.WriteAllText(filename, Clipboard.GetText(TextDataFormat.CommaSeparatedValue));

            // Restore the current state of the clipboard so the effect is seamless
            if (objectSave != null) // If we try to set the Clipboard to an object that is null, it will throw...
            {
                Clipboard.SetDataObject(objectSave);
            }
        }
        
    }
}
