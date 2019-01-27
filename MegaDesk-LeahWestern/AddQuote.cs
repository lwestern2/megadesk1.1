using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_LeahWestern
{
    public partial class AddQuote : Form
    {
        #region declare variables
        public string customerName = String.Empty;
        double width = 0;
        double depth = 0;
        int drawers = 0;
        int rushDays = 0;
        #endregion

        public AddQuote()
        {
            InitializeComponent();
            //UserClosing = false;

        }

        private void BoxWidth_Validating(object sender, CancelEventArgs e)
        {
            if (int.TryParse(boxWidth.Text, out int WidthInput) == true)
            {
                if (WidthInput < Desk.MINWIDTH || WidthInput > Desk.MAXWIDTH)
                {
                    MessageBox.Show("Please enter a width from " + Desk.MINWIDTH + " to " + Desk.MAXWIDTH + " inches");
                    boxWidth.Text = String.Empty;
                    boxWidth.BackColor = Color.DarkRed;
                    boxWidth.Focus();
                }
                else
                {
                    boxWidth.BackColor = System.Drawing.SystemColors.Window;
                }
            }
            else if (int.TryParse(boxWidth.Text, out WidthInput) == false && boxWidth.Text.Length != 0)
            {
                MessageBox.Show("Please enter a number");
                boxWidth.Text = String.Empty;
                boxWidth.BackColor = Color.DarkRed;
                boxWidth.Focus();
            }
            else
            {
                boxWidth.BackColor = System.Drawing.SystemColors.Window;
            }
        }

        private void cancelQuoteButton_Click(object sender, EventArgs e)
        {
            mainMenu returnMainMenu = new mainMenu();
            returnMainMenu.Show();
            this.Close();
        }

        //public bool UserClosing { get; set; }

        private void BoxDepth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) == false && Char.IsDigit(e.KeyChar) == false)
            {
                MessageBox.Show("Please enter a number");
                e.Handled = true;
                boxDepth.BackColor = Color.DarkRed;
                boxDepth.Focus();
            }
            else
            {
                boxDepth.BackColor = System.Drawing.SystemColors.Window;
            }
        }
    }
}
