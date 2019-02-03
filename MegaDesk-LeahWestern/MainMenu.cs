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
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
        }

        private void addQuote_Click(object sender, EventArgs e)
        {
            AddQuote addNewQuoteForm = new AddQuote();
            addNewQuoteForm.Tag = this;
            addNewQuoteForm.Show(this);
            Hide();
        }

        private void viewQuote_Click(object sender, EventArgs e)
        {
            ViewAllQuotes viewAllQuoteForm = new ViewAllQuotes();
            viewAllQuoteForm.Tag = this;
            viewAllQuoteForm.Show(this);
            Hide();
        }

        private void searchQuote_Click(object sender, EventArgs e)
        {
            SearchQuotes searchQuoteForm = new SearchQuotes();
            searchQuoteForm.Tag = this;
            searchQuoteForm.Show(this);
            Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
