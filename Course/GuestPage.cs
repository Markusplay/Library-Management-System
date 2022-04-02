using System;
using System.Drawing;
using System.Windows.Forms;
using Course.Presenter;
using Course.View;
namespace Course
{
    public partial class GuestPage : Form, IGuest
    {
        private string selectedState;
        public string SearchText
        {
            get { return txtSearchInEdit.Text; }
            set { txtSearchInEdit.Text = value; }
        }
        public GuestPage()
        {
            InitializeComponent();
        }
        private void GuestPage_Load(object sender, EventArgs e)
        {
            GuestPresenter guestPresenter = new GuestPresenter(this);
            guestPresenter.DrawTable(dataGridView1, comboBox1);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.AutoSize = true;
        }
        private void txtSearchInEdit_Enter(object sender, EventArgs e)
        {
            if (txtSearchInEdit.Text == "Search term")
            {
                txtSearchInEdit.Text = "";
                txtSearchInEdit.ForeColor = Color.Black;
            }
        }
        private void txtSearchInEdit_Leave(object sender, EventArgs e)
        {
            if (txtSearchInEdit.Text == "")
            {
                txtSearchInEdit.Text = "Search term";
                txtSearchInEdit.ForeColor = Color.Gray;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedState = comboBox1.SelectedItem.ToString();
            if (selectedState != "Default Title")
                comboBox1.ForeColor = Color.Black;
            txtSearchInEdit.Text = "Search term";
            txtSearchInEdit.ForeColor = Color.Gray;
        }

        private void txtSearchInEdit_KeyUp(object sender, KeyEventArgs e)
        {
            GuestPresenter guestPresenter = new GuestPresenter(this);
            guestPresenter.SearchInfo(dataGridView1, selectedState);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginPage login = new LoginPage();
            Hide();
            login.Show();
        }

        private void btnExit_Click(object sender, EventArgs e) => Application.Exit();
    }
}
