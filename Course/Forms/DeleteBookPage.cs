using System;
using System.Windows.Forms;
using System.Drawing;
using Course.View;
using Course.Presenter;
namespace Course
{
    public partial class DeleteBookPage : Form, IDeleteBook
    {
        private string _selectedState { get; set; }
        private int _ID { get; set; }
        public string SearchText
        {
            get { return txtSearchInDelete.Text; }
            set { txtSearchInDelete.Text = value; }
        }

        public int userID { get => _ID; set => _ID = value; }

        public DeleteBookPage() => InitializeComponent();

        private void deleteBook_Load(object sender, EventArgs e)
        {
            booksTableAdapter.Fill(catalogDataSet.Books);
            DeleteBookPresenter deleteBookPresenter = new DeleteBookPresenter(this);
            deleteBookPresenter.DrawTable(dataGridView, comboBox);
            comboBox.ForeColor = Color.Black;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminPage adminPage = new AdminPage();
            Hide();
            adminPage.Show();
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
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) => _selectedState = comboBox.SelectedItem.ToString();

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            DeleteBookPresenter deleteBookPresenter = new DeleteBookPresenter(this);
            deleteBookPresenter.DeleteBook();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var idDelCell = dataGridView.Rows[e.RowIndex].Cells[0].Value;
                _ID = (int)idDelCell;
            }
            catch (Exception) { }
        }

        private void btnExit_Click(object sender, EventArgs e) => Application.Exit();

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DeleteBookPresenter deleteBookPresenter = new DeleteBookPresenter(this);
            deleteBookPresenter.SearchInfo(dataGridView, _selectedState);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            DeleteBookPresenter deleteBookPresenter = new DeleteBookPresenter(this);
            deleteBookPresenter.ReloadTable(dataGridView);
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) => dataGridView.AutoSize = true;
    }
}

