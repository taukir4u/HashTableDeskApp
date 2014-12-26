using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HashTableDeskApp
{
    public partial class BookInfoUI : Form
    {

        public BookInfoUI()
        {
            InitializeComponent();
        }

        Hashtable bookInfo = new Hashtable();

        private void addButton_Click(object sender, EventArgs e)
        {
            
            if (bookInfo.ContainsKey(isbnTextBox.Text) != true)
            {
                bookInfo.Add(isbnTextBox.Text, bookInfoTextBox.Text);
                MessageBox.Show("Save succesfully");
            }
            else
            {
                MessageBox.Show("Already exists");
            }
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            String book = (string) bookInfo[findIsbnTextBox.Text];
            if (book != null)
            {
                findBookTextBox.Text = book;
            }

            else
            {
                MessageBox.Show("Book is not found");
            }
        }
    }
}
