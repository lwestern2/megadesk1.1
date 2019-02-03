using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace MegaDesk_LeahWestern
{
    public partial class AddQuote : Form
    {
        #region declare variables
        public string customerName = String.Empty;
        int width = 0;
        int depth = 0;
        int drawers = 0;
        int rushDays = 0;
        int QuoteTotal = 0;
        Desk.Material Material;
        private const string QUOTEFILE = @"quotes.json";
        #endregion

        public AddQuote()
        {
            InitializeComponent();
            List<Desk.Material> Materials = Enum.GetValues(typeof(Desk.Material)).Cast<Desk.Material>().ToList();
            boxMaterial.DataSource = Materials;
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

        private void submitButton_Click(object sender, EventArgs e)
        {
            try
            {
                customerName = boxName.Text;
                width = int.Parse(boxWidth.Text);
                depth = int.Parse(boxDepth.Text);
                drawers = int.Parse(boxDrawer.Text);
                Material = (Desk.Material)boxMaterial.SelectedValue;

                // Get rush order days base on radio box selections
                if (radioNone.Checked)
                {
                    rushDays = 0;
                }
                if (radio3.Checked)
                {
                    rushDays = 3;
                }
                if (radio5.Checked)
                {
                    rushDays = 5;
                }
                if (radio7.Checked)
                {
                    rushDays = 7;
                }

                // create new deskOrder and calcQuote
                DeskQuote NewQuote = new DeskQuote(customerName, DateTime.Now, width, depth, drawers, Material, rushDays);
                QuoteTotal = NewQuote.CalcQuote();

                //build string to quote save to file
                string DeskFileWrite = customerName + "," + DateTime.Now + "," + width + "," + depth + "," + drawers + "," + Material + "," + rushDays + "," + QuoteTotal;

                // ask how to do this without making all of the properties public because I know they are in and can be used
                // I just have no idea how to get the Serializer to get them when they are "private".
                string jsonWrite = JsonConvert.SerializeObject(NewQuote);

                if (!File.Exists(QUOTEFILE))
                {
                    using (StreamWriter sw = File.CreateText(QUOTEFILE)) { }
                }
                else
                {
                    using (StreamWriter swa = File.AppendText(QUOTEFILE)) { swa.WriteLine(DeskFileWrite); }

                    MessageBox.Show("Quote Submitted");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
