using System;
using System.Windows.Forms;
using System.Drawing;
using Course.View;
using Course.Presenter;
namespace Course
{
    public partial class DeleteBook : Form, IDeleteBook
    {
        private string _selectedState;
        private string _Title;
        private string _Author;
        private string _Genre;
        private string _Price;
        private string _PublicationYear;
        public string TitleText
        {
            get { return _Title; }

            set { _Title = value; }
        }
        public string AuthorText
        {
            get { return _Author; }
            set { _Author = value; }
        }
        public string GenreText
        {
            get { return _Genre; }
            set { _Genre = value; }
        }
        public string PriceText
        {
            get { return _Price; }
            set { _Price = value; }
        }
        public string PublicationYearText
        {
            get { return _PublicationYear; }
            set { _PublicationYear = value; }
        }
        public string SearchText
        {
            get { return txtSearchInDelete.Text; }
            set { txtSearchInDelete.Text = value; }
        }
        public DeleteBook()
        {
            InitializeComponent();
        }

        private void deleteBook_Load(object sender, EventArgs e)
        {
            DeleteBookPresenter deleteBookPresenter = new DeleteBookPresenter(this);
            deleteBookPresenter.DrawTable(dataGridView1, comboBox1);
            comboBox1.ForeColor = Color.Black;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminPage adminPage = new AdminPage();
            Hide();
            adminPage.Show();
        }

        private void txtSearchInDelete_KeyUp(object sender, KeyEventArgs e)
        {
            DeleteBookPresenter deleteBookPresenter = new DeleteBookPresenter(this);
            deleteBookPresenter.SearchInfo(dataGridView1, _selectedState);
        }

        private void txtSearchInDelete_Enter(object sender, EventArgs e)
        {
            if (txtSearchInDelete.Text == "Search term")
            {
                txtSearchInDelete.Text = "";
                txtSearchInDelete.ForeColor = Color.Black;
            }
        }

        private void txtSearchInDelete_Leave(object sender, EventArgs e)
        {
            if (txtSearchInDelete.Text == "")
            {
                txtSearchInDelete.Text = "Search term";
                txtSearchInDelete.ForeColor = Color.Gray;
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)=> _selectedState = comboBox1.SelectedItem.ToString();
        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            DeleteBookPresenter deleteBookPresenter = new DeleteBookPresenter(this);
            deleteBookPresenter.DeleteBook(dataGridView1);
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                _Title = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                _Author = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                _Genre = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                _Price = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                _PublicationYear = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch (Exception)
            { }
        }
        private void btnExit_Click(object sender, EventArgs e) => Application.Exit();
    }
}

