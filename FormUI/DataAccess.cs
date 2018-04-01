using HelperLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Windows.Forms;

namespace FormUI
{
	public class DataAccess
	{


		public List<Person> GetPeopleByLastName(string lastname)
		{
			using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AccessDemoDB")))
			{
				//var output = connection.Query<Person>($"select * from People where LastName = '{ lastname }'").ToList();
				var output = connection.Query<Person>("dbo.People_GetByLastName @LastName", new { LastName = lastname}).ToList();
				return output;
			}
		}

		public void InsertPerson(string firstname, string lastname, string emailaddress, string phonenumber)
		{
			using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AccessDemoDB")))
			{
				//Person newPerson = new Person { FirstName = firstname, LastName = lastname, EmailAddress = emailaddress, PhoneNumber = phonenumber };
				List<Person> people = new List<Person>();

				people.Add(new Person { FirstName = firstname, LastName = lastname, EmailAddress = emailaddress, PhoneNumber = phonenumber });


				//Inser the new person into the database
				connection.Execute("dbo.People_Insert @FirstName, @LastName, @EmailAddress, @PhoneNumber", people);
			}

		}

		public void DeletePerson(int id)
		{
			using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AccessDemoDB")))
			{
				//Inser the new person into the database
				connection.Execute("dbo.People_DeletePerson @ID", new { ID = id});
			}
		}

		public List<Person> GetPeople()
		{
			using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AccessDemoDB")))
			{
				var output = connection.Query<Person>("select * from People").ToList();
				return output;
			}
		}

		public void PopulateListView(ListView listView)
		{
			foreach(var person in GetPeople())
			{
				ListViewItem lsvitem = new ListViewItem(person.ID.ToString());
				lsvitem.SubItems.Add(person.FirstName);
				lsvitem.SubItems.Add(person.LastName);
				lsvitem.SubItems.Add(person.EmailAddress);
				lsvitem.SubItems.Add(person.PhoneNumber);
				listView.Items.Add(lsvitem);
			}
		}

		public int GetCount()
		{
			return GetPeople().Count;
		}
	

	}
}
