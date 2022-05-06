using System;
using System.Drawing;
using System.Windows.Forms;
using Course.View;
using Course.Model;
using Course.Presenter;
using System.Linq;
namespace Course
{
    public partial class EditBooks : Form, IEditBook
    {
        private string _selectedState;

        public string SearchText
        {
            get { return txtSearchInEdit.Text; }
            set { txtSearchInEdit.Text = value; }
        }
        public string TitleText
        {
            get { return txtTitle.Text; }
            set { txtTitle.Text = value; }
        }
        public string AuthorText
        {
            get { return txtAuthor.Text; }
            set { txtAuthor.Text = value; }
        }
        public string GenreText
        {
            get { return txtGenre.Text; }
            set { txtGenre.Text = value; }
        }
        public string PriceText
        {
            get { return txtPrice.Text; }
            set { txtPrice.Text = value; }
        }
        public string PublicationYearText
        {
            get { return txtYear.Text; }
            set { txtYear.Text = value; }
        }
        public int localId { get; set; }
        public int userID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public EditBooks() => InitializeComponent();

        private void editBooks_Load(object sender, EventArgs e)
        {
            EditBookPresenter edit = new EditBookPresenter(this);
            edit.DrawTable(dataGridView, comboBox1);
            comboBox1.ForeColor = Color.Black;
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) => dataGridView.AutoSize = true;

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminPage adminPage = new AdminPage();
            Hide();
            adminPage.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) => _selectedState = comboBox1.SelectedItem.ToString();

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

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            EditBookPresenter edit = new EditBookPresenter(this);
            edit.ID = localId;
            edit.SaveChanges(dataGridView);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EditBookPresenter edit = new EditBookPresenter(this);
            edit.ShowCell(dataGridView,e);
            localId = edit.ID;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            EditBookPresenter edit = new EditBookPresenter(this);
            edit.SearchInfo(dataGridView, _selectedState);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            EditBookPresenter edit = new EditBookPresenter(this);
            edit.ReloadTable(dataGridView);
        }
    }
}
