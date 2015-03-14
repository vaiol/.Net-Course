using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace NetLaba1
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ProjectName))
            {
                agreePanel.Visible = true;
                menuStrip1.Visible = true;
            }
            else
            {
                if (label28.ForeColor == System.Drawing.SystemColors.MenuHighlight)
                {
                    label28.ForeColor = System.Drawing.SystemColors.ControlText;
                }
                else
                {
                    label28.ForeColor = System.Drawing.SystemColors.MenuHighlight;                    
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            agreePanel.Visible = false;
            menuStrip1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            agreePanel.Visible = false;
            versionPanel.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            versionPanel.Visible = false;
            agreePanel.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            versionPanel.Visible = false;
            termsPanel.Visible = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            termsPanel.Visible = false;
            versionPanel.Visible = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            termsPanel.Visible = false;
            infoPanel.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            infoPanel.Visible = false;
            termsPanel.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            infoPanel.Visible = false;
            teamPanel.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            teamPanel.Visible = false;
            infoPanel.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            teamPanel.Visible = false;
            timePanel.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timePanel.Visible = false;
            teamPanel.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            saveToolStripMenuItem_Click(sender, e);
            timePanel.Visible = false;
            previewToolStripMenuItem_Click(sender, e);
        }

        private void sheetOfAgreementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            agreePanel.Visible = true;
            infoPanel.Visible = false;
            versionPanel.Visible = false;
            termsPanel.Visible = false;
            timePanel.Visible = false;
            teamPanel.Visible = false;
            
        }

        private void versionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            agreePanel.Visible = false;
            infoPanel.Visible = false;
            versionPanel.Visible = true;
            termsPanel.Visible = false;
            timePanel.Visible = false;
            teamPanel.Visible = false;
        }

        private void termsAndDefinitionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            agreePanel.Visible = false;
            infoPanel.Visible = false;
            versionPanel.Visible = false;
            termsPanel.Visible = true;
            timePanel.Visible = false;
            teamPanel.Visible = false;
        }

        private void generalInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            agreePanel.Visible = false;
            infoPanel.Visible = true;
            versionPanel.Visible = false;
            termsPanel.Visible = false;
            timePanel.Visible = false;
            teamPanel.Visible = false;
        }

        private void aboutTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            agreePanel.Visible = false;
            infoPanel.Visible = false;
            versionPanel.Visible = false;
            termsPanel.Visible = false;
            timePanel.Visible = false;
            teamPanel.Visible = true;
        }

        private void timelineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            agreePanel.Visible = false;
            infoPanel.Visible = false;
            versionPanel.Visible = false;
            termsPanel.Visible = false;
            timePanel.Visible = true;
            teamPanel.Visible = false;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void previewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (previewToolStripMenuItem.Text == "Edit")
            {
                previewToolStripMenuItem.Text = "Preview";
                webPanel.Visible = false;
            }
            else
            {
                
                previewToolStripMenuItem.Text = "Edit";
                string path = System.IO.Directory.GetCurrentDirectory() + @"\tmp.html";
                Console.WriteLine(path);
                HTML.GenerateNewHtml();
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.Write(HTML.newHtml);
                }
                webBrowser1.Url = new Uri(path);
                webPanel.Visible = true;
            }
        }

        public string CustomerFirst
        {
            set { customerFirstName.Text = value; }
            get { return customerFirstName.Text; }
        }
        public string CustomerLast
        {
            set { customerLastName.Text = value; }
            get { return customerLastName.Text; }
        }
        public string CustomerJob
        {
            set { customerJob.Text = value; }
            get { return customerJob.Text; }
        }

        public string PerformerFirst
        {
            set { performerFirstName.Text = value; }
            get { return performerFirstName.Text; }
        }
        public string PerformerLast
        {
            set { performLastName.Text = value; }
            get { return performLastName.Text; }
        }
        public string PerformerJob
        {
            set { performJob.Text = value; }
            get { return performJob.Text; }
        }

        public string CalendarTask
        {
            set { timeTask.Text = value; }
            get { return timeTask.Text; }
        }
        public string CalendarDate
        {
            set { dateTimePicker1.Text = value; }
            get
            {
                return dateTimePicker1.Text; 
                
            }
        }

        public string VersionNumeric
        {
            set { versionNumeric.Text = value; }
            get { return versionNumeric.Text; }
        }
        public string VersionDescription
        {
            set { versionDescription.Text = value; }
            get { return versionDescription.Text; }
        }

        public string TeamDescription
        {
            set { teamDesc.Text = value; }
            get { return teamDesc.Text; }
        }
        public string TermDescription
        {
            set { termDesc.Text = value; }
            get { return termDesc.Text; }
        }
        public string TermValue
        {
            set { termValue.Text = value; }
            get { return termValue.Text; }
        }
        public string InfoDescription
        {
            set { infoDesc.Text = value; }
            get { return infoDesc.Text; }
        }

        public string ProjectName
        {
            set { projectName.Text = value; }
            get { return projectName.Text; }
        }


        

        private void updateProgress()
        {
            int count = 0;
            if (!string.IsNullOrEmpty(CustomerFirst))
            {
                count++;
            }
            if (!string.IsNullOrEmpty(CustomerLast))
            {
                count++;
            }
            if (!string.IsNullOrEmpty(CustomerJob))
            {
                count++;
            }
            if (!string.IsNullOrEmpty(PerformerFirst))
            {
                count++;
            }
            if (!string.IsNullOrEmpty(PerformerLast))
            {
                count++;
            }
            if (!string.IsNullOrEmpty(PerformerJob))
            {
                count++;
            }
            if (!string.IsNullOrEmpty(VersionDescription))
            {
                count++;
                count++;
            }
            if (!string.IsNullOrEmpty(TeamDescription))
            {
                count++;
                count++;
            }
            if (!string.IsNullOrEmpty(InfoDescription))
            {
                count++;
                count++;
            }
            if (Program.Spec.tasks.Any())
            {
                count++;
                count++;
            }
            if (Program.Spec.terms.Any())
            {
                count++;
                count++;
            }
            int result = count;
            progressBar1.Value = result;
            progressBar2.Value = result;
            progressBar3.Value = result;
            progressBar4.Value = result;
            progressBar5.Value = result;
            progressBar6.Value = result;
        }

        public void clearAllInfo()
        {
            CustomerFirst = "";
            CustomerLast = "";
            CustomerJob = "";

            PerformerFirst = "";
            PerformerLast = "";
            PerformerJob = "";

            CalendarDate = "";
            CalendarTask = "";

            VersionNumeric = "";
            VersionDescription = "";

            TeamDescription = "";
            InfoDescription = "";

            TermDescription = "";
            TermValue = "";

            ProjectName = "";

            agreePanel.Visible = false;
            infoPanel.Visible = false;
            versionPanel.Visible = false;
            termsPanel.Visible = false;
            timePanel.Visible = false;
            teamPanel.Visible = false;
            webPanel.Visible = false;
            startPanel.Visible = true;
            Program.Spec = new Spec();
            menuStrip1.Visible = false;
            HTML.Path = "";
            testToolStripMenuItem.Text = "|";
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearAllInfo();
        }

        private static string StreamToString(Stream stream)
        {
            stream.Position = 0;
            using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
            {
                return reader.ReadToEnd();
            }
        } 

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            String html = null;
            String name = null;

            openFileDialog1.Filter = "HTML Files (*.html)|*.html";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        name = openFileDialog1.FileName;
                        html = StreamToString(myStream);
                    }
                }
                catch (Exception ex)
                {
                    html = null;
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
            name = name.Replace("\\", "/");
            testToolStripMenuItem.Text += " " + name;
            HTML.Path = @"" + name;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "Example.html";
            saveFileDialog1.Filter = "HTML Files (*.html)|*.html";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                HTML.GenerateNewHtml();
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                    sw.Write(HTML.newHtml);
            }
            string name = saveFileDialog1.FileName;
            name = name.Replace("\\", "/");
            testToolStripMenuItem.Text = "| " + name;
            HTML.Path = @"" + name;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Program.Spec.addTerms(TermValue, TermDescription);
            TermDescription = "";
            TermValue = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Program.Spec.addTasks(CalendarDate, CalendarTask);
            CalendarDate = "";
            CalendarTask = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            updateProgress();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            string path = System.IO.Directory.GetCurrentDirectory() + @"\tmp.html";
            File.Delete(path);
        }
    }
}
