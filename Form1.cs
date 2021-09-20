using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GradAssessment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SharedClass obj = new SharedClass();

        private void button1_Click(object sender, EventArgs e)
        {
            string P1 = txtPlayer1.Text;
            string P2 = txtPlayer2.Text;
            obj.CheckIfNameIsValid(P1);
            obj.CheckIfNameIsValid(P2);



           MessageBox.Show(obj.CheckIfGoodMatch(P1, P2, obj.GetPercentageMatch(P1, P2)));

        }

        private void btnQ2_Click(object sender, EventArgs e)
        {
            obj.ReadCsv(txtPath.Text);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fbd = new OpenFileDialog() )
            {
                fbd.Filter = "CSV Files (.csv)|*.csv";
                if (fbd.ShowDialog()==DialogResult.OK)
                {
                    txtPath.Text = fbd.FileName;
                }
            }
        }
    }
}
