using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;
using System.IO;

namespace mcr_2._0
{
    public partial class mainForm : Form
    {

        //Draggable form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        //Draggable form
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Rounding the corners of the form
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        //Rounding form
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int HeightEllipse
        );

        public mainForm()
        {
            InitializeComponent();

            //Rounding form
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            pnlNav.Height = btnSearch.Height;
            pnlNav.Top = btnSearch.Top;
            pnlNav.Left = btnSearch.Left;
            btnSearch.BackColor = Color.FromArgb(45, 106, 79);
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            //loads the search form as soon as the application is opened
            showForm(new searchForm());
        }

        //this is a method to open the other forms; used for the sidebar buttons
        public void showForm(Object Form)
        {
            pnlForms.Controls.Clear();
            Form frm = Form as Form;
            frm.TopLevel = false;
            pnlForms.Controls.Add(frm);
            pnlForms.Tag = frm;
            frm.Show();
        }

        //making the form draggable
        private void pnlDrag_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //close form
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //minimise form
        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //HOME BUTTON
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //opening the form
            showForm(new searchForm());

            //to move the nav bar, change the button color on click
            pnlNav.Height = btnSearch.Height;
            pnlNav.Top = btnSearch.Top;
            pnlNav.Left = btnSearch.Left;
            btnSearch.BackColor = Color.FromArgb(45, 106, 79);

            
        }
        private void btnSearch_Leave(object sender, EventArgs e)
        {
            btnSearch.BackColor = Color.FromArgb(27, 67, 50);
        }


        //ALL ITEMS BUTTON
        private void btnAll_Click(object sender, EventArgs e)
        {
            //opening All Items Form
            showForm(new allForm());

            //to change the default color of the home button
            btnSearch.BackColor = Color.FromArgb(27, 67, 50);

            //to move the nav bar, change the button color on click
            pnlNav.Height = btnAll.Height;
            pnlNav.Top = btnAll.Top;
            pnlNav.Left = btnAll.Left;
            btnAll.BackColor = Color.FromArgb(45, 106, 79);
        }
        private void btnAll_Leave(object sender, EventArgs e)
        {
            //change the button back to normal after another button is clicked
            btnAll.BackColor = Color.FromArgb(27, 67, 50);
        }


        //SETTINGS BUTTON
        private void btnSettings_Click(object sender, EventArgs e)
        {

            //opening the settings form
            showForm(new settingsForm());

            //to change the default color of the home button
            btnSearch.BackColor = Color.FromArgb(27, 67, 50);

            //to move the nav bar, change the button color on click
            pnlNav.Height = btnSettings.Height;
            pnlNav.Top = btnSettings.Top;
            pnlNav.Left = btnSettings.Left;
            btnSettings.BackColor = Color.FromArgb(45, 106, 79);
        }
        private void btnSettings_Leave(object sender, EventArgs e)
        {
            //change the button back to normal after another button is clicked
            btnSettings.BackColor = Color.FromArgb(27, 67, 50);
        }

    }
}
