using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lesson88
{
    public partial class Lab08Form : Form
    {
        public string UserName { get; set; }
        public float UserAge { get; set; }

        /// <summary>
        /// This is the cunstructor for LabF08Form
        /// </summary>
        public Lab08Form() 
        {
            InitializeComponent();
        }

        private void ClearForm()
        {
            NameTextBox.Clear();
            AgeTextBox.Clear();
            SubmitButton.Enabled = false;
           
        }

        /// <summary>
        /// This is the Event Handler for the AgeTextBox Text Change Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AgeTextBox_TextChanged(object sender, EventArgs e)
        {
          
                //simple input validation
                try
                {
                    float.Parse(AgeTextBox.Text);
                    SubmitButton.Enabled = true;
                }
                catch
                {
                    SubmitButton.Enabled = false;
                }
            

        }
        /// <summary>
        /// This is the Event Handler For the LAb08Form 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lab08Form_Load(object sender, EventArgs e)
        {
            ClearForm();
        }
           

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            UserName = NameTextBox.Text;

            UserAge = float.Parse(AgeTextBox.Text);

            OutputLabel.Text = NameTextBox.Text + " " + AgeTextBox.Text;
            ClearForm();

        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            SubmitButton.Enabled = (NameTextBox.Text.Length < 2) ? false : true;
        }
    }
}
