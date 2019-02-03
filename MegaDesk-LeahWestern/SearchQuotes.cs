using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace MegaDesk_LeahWestern
{
    public partial class SearchQuotes : Form
    {
        private const string QUOTEFILE = @"quotes.json";

        public SearchQuotes()
        {
            InitializeComponent();
            List<Desk.Material> Materials = Enum.GetValues(typeof(Desk.Material)).Cast<Desk.Material>().ToList();
            comboBoxMaterial.DataSource = Materials;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            mainMenu returnMainMenu = new mainMenu();
            returnMainMenu.Show();
            this.Close();
        }

        private void comboBoxMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            listViewResults.Clear();

            try
            {
                // grab combo box selection as a string
                string MaterialSelected = comboBoxMaterial.SelectedItem.ToString();

                using (StreamReader sw = new StreamReader(QUOTEFILE))
                {
                    // find and read CSV file if they exist
                    if (!File.Exists(QUOTEFILE))
                    {
                        MessageBox.Show("A Quote file was not found in application Root", "Error Reading File");
                    }
                    else
                    {
                            // add column headings to search output List View
                            // Make sure View properity is set to Details
                            listViewResults.View = View.Details;
                            listViewResults.Columns.Add("Name", 80, HorizontalAlignment.Center);
                            listViewResults.Columns.Add("Date", 70, HorizontalAlignment.Center);
                            listViewResults.Columns.Add("Width", 50, HorizontalAlignment.Center);
                            listViewResults.Columns.Add("Depth", 50, HorizontalAlignment.Center);
                            listViewResults.Columns.Add("Drawers", 60, HorizontalAlignment.Center);
                            listViewResults.Columns.Add("Material", 70, HorizontalAlignment.Center);
                            listViewResults.Columns.Add("Days", 50, HorizontalAlignment.Center);
                            listViewResults.Columns.Add("Total", 70, HorizontalAlignment.Center);

                        using (StreamReader sr = new StreamReader(QUOTEFILE))
                        {
                            while (!sr.EndOfStream)
                            {
                                string line = sr.ReadLine();
                                DeskQuote lineDeskQuote = JsonConvert.DeserializeObject<DeskQuote>(line);
                                if (lineDeskQuote.Desk.deskMaterial.ToString() == MaterialSelected)
                                {
                                    listViewResults.Items.Add(new ListViewItem(new[]
                                    {
                                    lineDeskQuote.customerName,
                                    lineDeskQuote.quoteDate.ToString(),
                                    lineDeskQuote.Desk.width.ToString(),
                                    lineDeskQuote.Desk.depth.ToString(),
                                    lineDeskQuote.Desk.numberOfDrawers.ToString(),
                                    lineDeskQuote.Desk.deskMaterial.ToString(),
                                    lineDeskQuote.rushDays.ToString(),
                                    lineDeskQuote.quoteAmount.ToString()
                                }));
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error with poplulating Results List." + "\n\n" + ex);
            }
        }
    }
}
