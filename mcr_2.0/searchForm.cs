using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;


namespace mcr_2
{
    public partial class searchForm : Form
    {
        public searchForm()
        {
            InitializeComponent();
        }

        //Connecting to the database
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand command;
        MySqlDataAdapter da;

        void showLbl()
        {
            lblItemname.Show();
            lblItemIng.Show();
            lblName.Show();
            lblIng.Show();
        }

        void hideLbl()
        {

            lblError.Show();
            lblItemname.Hide();
            lblItemIng.Hide();
            lblName.Hide();
            lblIng.Hide();

        }

        void searchClick()
        {

            //To remove the error message so it's not there the whole time
            lblError.Text = "";

            //try catch in case the item searched is not in the database
            try
            {
                string selectQuery = "SELECT * FROM mc_recipes_project.items WHERE Name = '" + txtSearch.Text + "'";

                command = new MySqlCommand(selectQuery, connection);

                da = new MySqlDataAdapter(command);

                DataTable table = new DataTable();

                da.Fill(table);

                showLbl();

                lblName.Text = table.Rows[0][1].ToString();
                lblIng.Text = table.Rows[0][3].ToString();

                byte[] img = (byte[])table.Rows[0][4];

                MemoryStream ms = new MemoryStream(img);
                picItem.Image = Image.FromStream(ms);

                da.Dispose();
            }

            catch (IndexOutOfRangeException)
            {

                lblError.Text = "Sorry that Item cannot be found";

                hideLbl();
                //picItem.Image = mcr_2.Properties.Resources.Empty_crafting_table;


            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                hideLbl();
                lblError.Text = "It seems the database is not connected...";
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //calling the connect to db and search method
            searchClick();
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            //this just gets rid of what is put there by me and nothing else the user inputs
            if (txtSearch.Text.Trim() == "Search...")

            {

                txtSearch.Text = "";

            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchClick();
            }
        }
    }
}
