using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.IO;
using System.Windows.Forms;

namespace Hdurum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            XmlTextReader reader = new XmlTextReader("https://www.mgm.gov.tr/FTPDATA/analiz/sonSOA.xml");
            DataSet data = new DataSet();
            data.ReadXml(reader);
            dataGridView1.DataSource = data.Tables[1];
            TextWriter writer = new StreamWriter(@"Text.txt");

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    writer.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                }
                writer.WriteLine("");
                writer.WriteLine("-----------------------------------------------------");
            }
            writer.Close();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            XmlTextReader reader = new XmlTextReader("https://www.mgm.gov.tr/FTPDATA/analiz/sonSOA.xml");
            DataSet data = new DataSet();
            data.ReadXml(reader);
            dataGridView1.DataSource = data.Tables[1];
            TextWriter writer = new StreamWriter(@"Text.txt");

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    writer.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                }
                writer.WriteLine("");
                writer.WriteLine("-----------------------------------------------------");
            }
            writer.Close();
            MessageBox.Show("Veriler Güncellendi");
        }
    }
}

