using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assigment_C_
{
    public partial class problem_1 : Form
    {
        private Dictionary<string, string> books = new Dictionary<string, string>()
        {
         {"Gone with the wind", "Margaret Mitchell"},
        {"Roots ","Alex Helay"},
        {"Atles Shrugged","Ayan Rand"}
        };

        public problem_1()
        {
            InitializeComponent();
            PopulateBookList();
        }
        private void PopulateBookList()
        {
            comboBox1.Items.AddRange(books.Keys.ToArray());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selctedBook = comboBox1.SelectedItem as string;

            if(selctedBook != null)
            {
                MessageBox.Show("Select Book ");
            }
            else if(books.ContainsKey(selctedBook))
            { 
            Authorlbl.Text = books[selctedBook];
            }
            else { Authorlbl.Text = "Author not Found"; }
        }
    }
}
