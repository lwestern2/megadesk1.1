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

        public string CustomerName { get; private set; }
        public int DeskWidth { get; private set; }
        public int DeskDepth { get; private set; }
        public int Drawers { get; private set; }
        internal Desk.Material Material { get; private set; }
        public int RushDays { get; private set; }
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
                CustomerName = boxName.Text;
                DeskWidth = int.Parse(boxWidth.Text);
                DeskDepth = int.Parse(boxDepth.Text);
                Drawers = int.Parse(boxDrawer.Text);
                Material = (Desk.Material)boxMaterial.SelectedValue;

                // Get rush order days base on radio box selections
                if (radioNone.Checked)
                {
                    RushDays = 0;
                }
                if (radio3.Checked)
                {
                    RushDays = 3;
                }
                if (radio5.Checked)
                {
                    RushDays = 5;
                }
                if (radio7.Checked)
                {
                    RushDays = 7;
                }

                // create new deskOrder and calcQuote
                DeskQuote NewQuote = new DeskQuote(CustomerName, DateTime.Now, DeskWidth, DeskDepth, Drawers, Material, RushDays);
                int QuoteTotal = NewQuote.CalcQuote();

                //build string to quote save to file
                string DeskFileWrite = CustomerName + "," + DateTime.Now + "," + DeskWidth + "," + DeskDepth + "," + Drawers + "," + Material + "," + RushDays + "," + QuoteTotal;

                // ask how to do this without making all of the properties public because I know they are in and can be used
                // I just have no idea how to get the Serializer to get them when they are "private".
                string jsonFile = @"quotes.json";

                if (!File.Exists(jsonFile))
                {
                    using (StreamWriter sw = File.CreateText(jsonFile)) { sw.WriteLine(DeskFileWrite); }
                }
                else
                {
                    using (StreamWriter swa = File.AppendText(jsonFile)) { swa.WriteLine(jsonFile); }

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
