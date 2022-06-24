using System;
using System.Drawing;
using System.Windows.Forms;
using Course.Presenter;
using Course.View;
namespace Course
{
    public partial class GuestPage : Form, IGuestPage, IWishList
    {

        private string _selectedState;
        private int _currentId;
        private int _wishId;
        public string SearchText
        {
            get { return txtSearch.Text; }
            set { txtSearch.Text = value; }
        }

        public int userID
        {
            get { return _currentId; }
            set { _currentId = value; }
        }

        public int GuestID { get; set; }
        public int WishID { get; set; }
        public string TitleText { get; set; }
        public string AuthorText { get; set; }
        public string GenreText { get; set; }
        public string PriceText { get; set; }
        public string PublicationYearText { get; set; }

        public GuestPage(int newID)
        {
            InitializeComponent();
            _currentId = newID;
            lblId.Text += newID.ToString();
        }

        private void GuestPage_Load(object sender, EventArgs e)
        {
            booksTableAdapter.Fill(catalogDataSet.Books);
            wishListTableAdapter.Fill(catalogDataSet.WishList);
            GuestPresenter guestPresenter = new GuestPresenter(this);
            guestPresenter.DrawTable(dataGridView, comboBox);
            guestPresenter.RefreshWishList(dataGridViewWishList, _currentId);
            comboBox.ForeColor = Color.Black;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) => dataGridView.AutoSize = true;

        private void txtSearchInEdit_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search term")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearchInEdit_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Search term";
                txtSearch.ForeColor = Color.Gray;
            }
        }

        private void btnExit_Click(object sender, EventArgs e) => Application.Exit();

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GuestPresenter guestPresenter = new GuestPresenter(this);
            guestPresenter.SearchInfo(dataGridView, _selectedState);

        }

        private void ToLogin_Click(object sender, EventArgs e)
        {
            LoginPage login = new LoginPage();
            Hide();
            login.Show();
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedState = comboBox.SelectedItem.ToString();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            GuestPresenter guestPresenter = new GuestPresenter(this);
            guestPresenter.ReloadTable(dataGridView);
        }

        private void btnAddWish_Click(object sender, EventArgs e)
        {
            GuestPresenter guestPresenter = new GuestPresenter(this);
            guestPresenter.SetAddInfo(this);
            if (!guestPresenter.BookExistInWishlist())
            {
                guestPresenter.AddBookToWishList();
            }
        }

        private void btnDeleteWish_Click(object sender, EventArgs e)
        {
            GuestPresenter guestPresenter = new GuestPresenter(this);
            guestPresenter.DeleteBookWishList(_wishId);
        }

        private void btnRefreshWish_Click(object sender, EventArgs e)
        {  
            GuestPresenter guestPresenter = new GuestPresenter(this);
            guestPresenter.RefreshWishList(dataGridViewWishList, _currentId);
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GuestPresenter guestPresenter = new GuestPresenter(this);
            guestPresenter.SetAddInfo(this);
            guestPresenter.TakeCatalogInfo(dataGridView, e, _currentId);
        }

        private void dataGridViewWishList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var idDelCell = dataGridViewWishList.Rows[e.RowIndex].Cells[0].Value;
                _wishId = (int)idDelCell;
            }
            catch (Exception) { }
        }

        private void dataGridViewWishList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewWishList.AutoSize = true;
        }
    }
}
