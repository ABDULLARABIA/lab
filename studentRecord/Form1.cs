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
namespace studentRecord
{
    public partial class studentGradeForm1 : Form
    {
        public studentGradeForm1()
        {
            InitializeComponent();
        }

        private void studentGradeForm1_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader inFile;

                inFile = File.OpenText(@"C:\Users\aubh.lab\Desktop\stIDs.txt");

                while (!inFile.EndOfStream)
                {
                    idsComboBox.Items.Add(inFile.ReadLine());
                }
                idsComboBox.Text = "Select";
                inFile.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("error in opening the file","Error");
            }
        }
    }
}
