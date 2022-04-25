using System;
using System.Drawing;
using System.Windows.Forms;
using Course.View;
using Course.Presenter;
namespace Course
{
    public partial class EditBooks : Form, IEditBook
    {
        private string dataTitle;
        private string dataAuthor;
        private string dataGenre;
        private string dataPrice;
        private string dataYear;
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

        public string DataTitleText
        {
            get { return dataTitle; }
            set { dataTitle = value; }
        }
        public string DataAuthorText
        {
            get { return dataAuthor; }
            set { dataAuthor = value; }
        }
        public string DataGenreText
        {
            get { return dataGenre; }
            set { dataGenre = value; }
        }
        public string DataPriceText
        {
            get { return dataPrice; }
            set { dataPrice = value; }
        }
        public string DataPublicationYearText
        {
            get { return dataYear; }
            set { dataYear = value; }
        }

        public EditBooks() => InitializeComponent();

        private void editBooks_Load(object sender, EventArgs e)
        {
            EditBookPresenter edit = new EditBookPresenter(this);
            edit.DrawTable(dataGridView1, comboBox1);
            comboBox1.ForeColor = Color.Black;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) => dataGridView1.AutoSize = true;

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminPage adminPage = new AdminPage();
            Hide();
            adminPage.Show();
        }

        private void txtSearchInEdit_KeyUp(object sender, KeyEventArgs e)
        {
            EditBookPresenter edit = new EditBookPresenter(this);
            edit.SearchInfo(dataGridView1, _selectedState);
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
            edit.SaveChanges();
            edit.DrawTable(dataGridView1, comboBox1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dataTitle = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                dataAuthor = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                dataGenre = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                dataPrice = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                dataYear = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch (Exception) { }
            EditBookPresenter edit = new EditBookPresenter(this);
            edit.ShowCell();
        }
    }
}
