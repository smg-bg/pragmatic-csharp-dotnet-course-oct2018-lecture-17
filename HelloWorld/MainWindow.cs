using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSayHello_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbUsername.Text))
            {
                MessageBox.Show("Username is required!",
                "Validation error...",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                lblMessage.Text = $"$> Hello, { tbUsername.Text }!";
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void btnFormatDisk_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("Are you sure you want to format your computer?",
                "Confirmation...", 
                MessageBoxButtons.YesNoCancel, 
                MessageBoxIcon.Question, 
                MessageBoxDefaultButton.Button3);


            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Opps, you broke everything!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomDialog dialog = new CustomDialog();

            dialog.Show();
        }

        private void btnShowModalForm_Click(object sender, EventArgs e)
        {
            CustomDialog dialog = new CustomDialog();

            if (dialog.ShowDialog() == DialogResult.Ignore)
                MessageBox.Show("It was ignored!");
        }
    }
}
