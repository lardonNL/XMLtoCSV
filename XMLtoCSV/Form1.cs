using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.XPath;
using System.Xml;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace XMLtoCSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (true)
            {
                XMLDirectory_Textbox.Text = @"D:\VisualStudioProjects\XMLtoCSV\XMLtoCSV\bin\Debug\files\aba-20190920.a2a.xml";
                XSLTDirectory_Textbox.Text = @"D:\VisualStudioProjects\XMLtoCSV\XMLtoCSV\bin\Debug\files\A2A.xslt";
                CSVFile_TextBox.Text = @"test";
            }
        }

        private void SelectXML_Button_Click(object sender, EventArgs e)
        {
            XML_OpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            if (XML_OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                XMLDirectory_Textbox.Text = XML_OpenFileDialog.FileName;
            }
        }

        private void SelectXSLT_Button_Click(object sender, EventArgs e)
        {
            XSLT_OpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            if (XSLT_OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                XSLTDirectory_Textbox.Text = XSLT_OpenFileDialog.FileName;
            }
        }

        private void Convert_Button_Click(object sender, EventArgs e)
        {
            if (Empty_Checks() == false)
            {
                return;
            }
            if (Files_Exist() == false)
            {
                return;
            }
            Convert();
        }

        private bool Empty_Checks()
        {
            if (XMLDirectory_Textbox.Text == "")
            {

                MessageBox.Show("Error, No XML file specified.");
                return false;
            }

            if (XSLTDirectory_Textbox.Text == "")
            {
                MessageBox.Show("Error, No XSLT file specified.");
                return  false;
            }

            if (CSVFile_TextBox.Text == "")
            {
                MessageBox.Show("Error, No name for output file specified.");
                return false;
            }
            return true;
        }

        private bool Files_Exist()
        {
            if (!File.Exists(XMLDirectory_Textbox.Text))
            {
                MessageBox.Show("Error, XML file does not exist.");
                return false;
            }
            if (!File.Exists(XSLTDirectory_Textbox.Text))
            {
                MessageBox.Show("Error, XSLT file does not exist.");
                return false;
            }
            return true;
        }

        private string Convert()
        {
            string xmlfile = XMLDirectory_Textbox.Text;
            string xsltFile = XSLTDirectory_Textbox.Text;
            string result = string.Empty;
            var xpathDoc = new XPathDocument(xmlfile);
            var xsltTransform = new System.Xml.Xsl.XslCompiledTransform();

            xsltTransform.Load(xsltFile);
            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    var writer = new XmlTextWriter(ms, Encoding.UTF8);
                    using (var rd = new StreamReader(ms))
                    {
                        var argList = new System.Xml.Xsl.XsltArgumentList();
                        xsltTransform.Transform(xpathDoc, argList, writer);
                        ms.Position = 0;
                        result = rd.ReadToEnd();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }

            Path.GetDirectoryName(XMLDirectory_Textbox.Text);

            Write_To_File(result, Path.GetDirectoryName(XMLDirectory_Textbox.Text));
            return result;
        }

        private void Write_To_File(string lines, string directory)
        {
            System.Diagnostics.Debug.Write(lines);
            MessageBox.Show(lines);
            //return;

            // MessageBox.Show(directory);
            string CombinedPath = System.IO.Path.Combine(directory, CSVFile_TextBox.Text + ".csv");
            var list = new List<string>();

            try
            {
                list.Add(lines);
                //using (var sr = new StreamReader("files/a.txt"))
                //{
                //    string line;
                //    while ((line = sr.ReadLine()) != null)
                //    {
                //        list.Add(line);
                //    }
                //}
                System.IO.File.WriteAllLines(System.IO.Path.GetFullPath(CombinedPath), list);
                MessageBox.Show("Het bestand is succesvol aangemaakt.");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }
    }
}
