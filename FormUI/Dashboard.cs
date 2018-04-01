using HelperLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{

	public partial class Dashboard : Form
	{
		List<Person> people = new List<Person>();
		DataAccess db = new DataAccess();
	
		public Dashboard()
		{
			InitializeComponent();
			UpdateBinding();
			db.PopulateListView(listView1);
			lblcount.Text = $"Count: {db.GetCount()}";
		}

		private void UpdateBinding()
		{
			lstPeopleFound.DataSource = people;
			lstPeopleFound.DisplayMember = "FullInfo";
		}

		private void btnsearch_Click(object sender, EventArgs e)
		{
			if(txtsearch.Text.Length != 0)
			{
				people = db.GetPeopleByLastName(txtsearch.Text);
				UpdateBinding();
			}
			else
			{
				MessageBox.Show("Please enter required information");
			}
		}

		private void btnsave_Click(object sender, EventArgs e)
		{
			if(txtfirstname.Text.Length != 0 && txtlastname.Text.Length != 0 && txtemail.Text.Length != 0)
			{
				db.InsertPerson(txtfirstname.Text, txtlastname.Text, txtemail.Text, txtphone.Text);
				MessageBox.Show($"{ txtfirstname.Text } added to the database");
				db.PopulateListView(listView1);
				lblcount.Text = $"Count: {db.GetCount()}";
				//Clear textboxes
				txtfirstname.Text = "";
				txtlastname.Text = "";
				txtemail.Text = "";
				txtphone.Text = "";
			}
			else
			{
				MessageBox.Show("Please enter data");
			}
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{
		
		}

		private void Dashboard_Load(object sender, EventArgs e)
		{
			db.PopulateListView(listView1);
		}

		private void btndelete_Click(object sender, EventArgs e)
		{

			if (listView1.SelectedItems.Count > 0)
			{
				// Displays the MessageBox.
				DialogResult result = MessageBox.Show("This operation cannot be undone. Are you sure you want to proceed?", "Deletion Operation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

				if (result == System.Windows.Forms.DialogResult.Yes)
				{
					ListViewItem lsvitem = listView1.SelectedItems[0];
					int id = Convert.ToInt32(lsvitem.SubItems[0].Text);
					 
					//Call DeletePerson Method
					db.DeletePerson(id);
					MessageBox.Show("Item has been deleted");

					db.PopulateListView(listView1);
					lblcount.Text = $"Count: {db.GetCount()}";

				}
			}
			else
			{
				MessageBox.Show("Please select an item");
			}
		}
	}
}
