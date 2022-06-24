
namespace Course
{
    partial class AddBookPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Title = new System.Windows.Forms.Label();
            this.Author = new System.Windows.Forms.Label();
            this.Genre = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.Published = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.btnAddToCatalogue = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.comboBoxGenres = new System.Windows.Forms.ComboBox();
            this.genresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.catalogDataSet = new Course.CatalogDataSet();
            this.genresTableAdapter = new Course.CatalogDataSetTableAdapters.GenresTableAdapter();
            this.btnAddNewGenre = new System.Windows.Forms.Button();
            this.txtNewGenre = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.Title.Location = new System.Drawing.Point(162, 33);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(37, 17);
            this.Title.TabIndex = 0;
            this.Title.Text = "Title";
            // 
            // Author
            // 
            this.Author.AutoSize = true;
            this.Author.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.Author.Location = new System.Drawing.Point(143, 97);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(56, 17);
            this.Author.TabIndex = 1;
            this.Author.Text = "Author";
            // 
            // Genre
            // 
            this.Genre.AutoSize = true;
            this.Genre.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.Genre.Location = new System.Drawing.Point(148, 167);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(50, 17);
            this.Genre.TabIndex = 2;
            this.Genre.Text = "Genre";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.Price.Location = new System.Drawing.Point(133, 239);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(67, 17);
            this.Price.TabIndex = 3;
            this.Price.Text = "Price($)";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(206, 188);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(246, 2);
            this.panel3.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(205, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 2);
            this.panel1.TabIndex = 13;
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.SystemColors.Control;
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtTitle.Location = new System.Drawing.Point(204, 33);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(246, 20);
            this.txtTitle.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(206, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(246, 2);
            this.panel2.TabIndex = 13;
            // 
            // txtAuthor
            // 
            this.txtAuthor.BackColor = System.Drawing.SystemColors.Control;
            this.txtAuthor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAuthor.Location = new System.Drawing.Point(205, 97);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(246, 20);
            this.txtAuthor.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Location = new System.Drawing.Point(207, 260);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(246, 2);
            this.panel4.TabIndex = 15;
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.SystemColors.Control;
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPrice.Location = new System.Drawing.Point(206, 239);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(246, 20);
            this.txtPrice.TabIndex = 14;
            // 
            // Published
            // 
            this.Published.AutoSize = true;
            this.Published.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.Published.Location = new System.Drawing.Point(77, 305);
            this.Published.Name = "Published";
            this.Published.Size = new System.Drawing.Size(121, 17);
            this.Published.TabIndex = 16;
            this.Published.Text = "Published(Year)";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.Location = new System.Drawing.Point(208, 326);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(246, 2);
            this.panel5.TabIndex = 18;
            // 
            // txtYear
            // 
            this.txtYear.BackColor = System.Drawing.SystemColors.Control;
            this.txtYear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtYear.Location = new System.Drawing.Point(207, 305);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(246, 20);
            this.txtYear.TabIndex = 17;
            // 
            // btnAddToCatalogue
            // 
            this.btnAddToCatalogue.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddToCatalogue.FlatAppearance.BorderSize = 2;
            this.btnAddToCatalogue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToCatalogue.Font = new System.Drawing.Font("Britannic Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCatalogue.Location = new System.Drawing.Point(208, 375);
            this.btnAddToCatalogue.Name = "btnAddToCatalogue";
            this.btnAddToCatalogue.Size = new System.Drawing.Size(242, 38);
            this.btnAddToCatalogue.TabIndex = 19;
            this.btnAddToCatalogue.Text = "Add to catalog";
            this.btnAddToCatalogue.UseVisualStyleBackColor = false;
            this.btnAddToCatalogue.Click += new System.EventHandler(this.btnAddToCatalogue_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.Control;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(72, 25);
            this.btnBack.TabIndex = 20;
            this.btnBack.Text = "<< Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // comboBoxGenres
            // 
            this.comboBoxGenres.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxGenres.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.genresBindingSource, "Genre", true));
            this.comboBoxGenres.DataSource = this.genresBindingSource;
            this.comboBoxGenres.DisplayMember = "Genre";
            this.comboBoxGenres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGenres.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.comboBoxGenres.FormattingEnabled = true;
            this.comboBoxGenres.ItemHeight = 17;
            this.comboBoxGenres.Location = new System.Drawing.Point(207, 162);
            this.comboBoxGenres.MaxDropDownItems = 5;
            this.comboBoxGenres.Name = "comboBoxGenres";
            this.comboBoxGenres.Size = new System.Drawing.Size(246, 25);
            this.comboBoxGenres.TabIndex = 21;
            this.comboBoxGenres.ValueMember = "Genre";
            this.comboBoxGenres.SelectedIndexChanged += new System.EventHandler(this.comboBoxGenres_SelectedIndexChanged);
            // 
            // genresBindingSource
            // 
            this.genresBindingSource.DataMember = "Genres";
            this.genresBindingSource.DataSource = this.catalogDataSet;
            // 
            // catalogDataSet
            // 
            this.catalogDataSet.DataSetName = "CatalogDataSet";
            this.catalogDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // genresTableAdapter
            // 
            this.genresTableAdapter.ClearBeforeFill = true;
            // 
            // btnAddNewGenre
            // 
            this.btnAddNewGenre.BackColor = System.Drawing.Color.White;
            this.btnAddNewGenre.FlatAppearance.BorderSize = 2;
            this.btnAddNewGenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewGenre.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.btnAddNewGenre.Location = new System.Drawing.Point(542, 375);
            this.btnAddNewGenre.Name = "btnAddNewGenre";
            this.btnAddNewGenre.Size = new System.Drawing.Size(242, 38);
            this.btnAddNewGenre.TabIndex = 22;
            this.btnAddNewGenre.Text = "Add new genre";
            this.btnAddNewGenre.UseVisualStyleBackColor = false;
            this.btnAddNewGenre.Click += new System.EventHandler(this.btnAddNewGenre_Click);
            // 
            // txtNewGenre
            // 
            this.txtNewGenre.BackColor = System.Drawing.SystemColors.Control;
            this.txtNewGenre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtNewGenre.Location = new System.Drawing.Point(542, 305);
            this.txtNewGenre.Name = "txtNewGenre";
            this.txtNewGenre.Size = new System.Drawing.Size(246, 20);
            this.txtNewGenre.TabIndex = 23;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel6.Location = new System.Drawing.Point(542, 326);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(246, 2);
            this.panel6.TabIndex = 19;
            // 
            // AddBookPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.txtNewGenre);
            this.Controls.Add(this.btnAddNewGenre);
            this.Controls.Add(this.comboBoxGenres);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAddToCatalogue);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.Published);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Genre);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.Title);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddBookPage";
            this.ShowIcon = false;
            this.Text = "Library Management System";
            this.Load += new System.EventHandler(this.addBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Author;
        private System.Windows.Forms.Label Genre;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label Published;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Button btnAddToCatalogue;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox comboBoxGenres;
        private CatalogDataSet catalogDataSet;
        private System.Windows.Forms.BindingSource genresBindingSource;
        private CatalogDataSetTableAdapters.GenresTableAdapter genresTableAdapter;
        private System.Windows.Forms.Button btnAddNewGenre;
        private System.Windows.Forms.TextBox txtNewGenre;
        private System.Windows.Forms.Panel panel6;
    }
}