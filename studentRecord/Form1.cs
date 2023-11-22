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
        StreamWriter outputFile;
        StreamReader inputFile;
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
                MessageBox.Show("error in opening the file :D","Error");
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    outputFile = File.AppendText(saveFileDialog.FileName);
                }
            }
            catch
            {
                MessageBox.Show("error in creating the file :(");
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (studentGradesTabControl.SelectedTab == gradesTab)
                {
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        outputFile = File.AppendText(openFileDialog.FileName);
                    }
                }
                else
                {
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        inputFile = File.OpenText(openFileDialog.FileName);
                    }
                }
            }
            catch
            {
                MessageBox.Show("error in opening the file");
            }
        }

        private void btSaveRecord_Click(object sender, EventArgs e)
        {
            try
            {
                if (idsComboBox.SelectedIndex != -1)
                {
                    outputFile.WriteLine(idsComboBox.SelectedItem.ToString() + 
                        ", " + tbQuiz1.Text + 
                        ", " + tbQuiz2.Text + 
                        ", " + tbProject.Text + 
                        ", " + tbMajorTest.Text + 
                        ", " + tbFinalExam.Text );

                }
            }
            catch
            {
                MessageBox.Show("error while saving the record into the file", "Error");
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            outputFile.Close();
            MessageBox.Show("The file is saved", "Saved");
            tbQuiz1.Text = "";
            tbQuiz2.Text = "";
            tbProject.Text = "";
            tbMajorTest.Text = "";
            tbFinalExam.Text = "";
            idsComboBox.SelectedIndex = -1;
        }

        private void btGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                while (!inputFile.EndOfStream)
                {
                    lBoxStudentGradeReport.Items.Add(inputFile.ReadLine());
                }
            }
            catch
            {
                MessageBox.Show("Error in reading from the file", "Error :(");
            }
        }
    }
}
