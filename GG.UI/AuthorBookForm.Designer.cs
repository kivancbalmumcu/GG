namespace GG.UI
{
    partial class AuthorBookForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dateTimePickerPublishedDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.textPublisherId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textPageCount = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textInternationalStandardBookNumber = new System.Windows.Forms.TextBox();
            this.textBookId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textLastname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textMiddlename = new System.Windows.Forms.TextBox();
            this.textFirstname = new System.Windows.Forms.TextBox();
            this.textAuthorId = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonMainMenu = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(776, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 168);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(776, 150);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // dateTimePickerPublishedDate
            // 
            this.dateTimePickerPublishedDate.Location = new System.Drawing.Point(428, 401);
            this.dateTimePickerPublishedDate.Name = "dateTimePickerPublishedDate";
            this.dateTimePickerPublishedDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerPublishedDate.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(363, 456);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "PublisherId";
            // 
            // textPublisherId
            // 
            this.textPublisherId.Location = new System.Drawing.Point(428, 453);
            this.textPublisherId.Name = "textPublisherId";
            this.textPublisherId.Size = new System.Drawing.Size(200, 20);
            this.textPublisherId.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(359, 430);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Page Count";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(343, 404);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Published Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(387, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "InternationalStandardBookNumber";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(381, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "BookId";
            // 
            // textPageCount
            // 
            this.textPageCount.Location = new System.Drawing.Point(428, 427);
            this.textPageCount.Name = "textPageCount";
            this.textPageCount.Size = new System.Drawing.Size(200, 20);
            this.textPageCount.TabIndex = 16;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(428, 375);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(200, 20);
            this.textName.TabIndex = 15;
            // 
            // textInternationalStandardBookNumber
            // 
            this.textInternationalStandardBookNumber.Location = new System.Drawing.Point(428, 349);
            this.textInternationalStandardBookNumber.Name = "textInternationalStandardBookNumber";
            this.textInternationalStandardBookNumber.Size = new System.Drawing.Size(200, 20);
            this.textInternationalStandardBookNumber.TabIndex = 14;
            // 
            // textBookId
            // 
            this.textBookId.Enabled = false;
            this.textBookId.Location = new System.Drawing.Point(428, 323);
            this.textBookId.Name = "textBookId";
            this.textBookId.Size = new System.Drawing.Size(200, 20);
            this.textBookId.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 405);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Last Name";
            // 
            // textLastname
            // 
            this.textLastname.Location = new System.Drawing.Point(87, 402);
            this.textLastname.Name = "textLastname";
            this.textLastname.Size = new System.Drawing.Size(100, 20);
            this.textLastname.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 379);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Middle Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 353);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "First Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 327);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "AuthorId";
            // 
            // textMiddlename
            // 
            this.textMiddlename.Location = new System.Drawing.Point(87, 376);
            this.textMiddlename.Name = "textMiddlename";
            this.textMiddlename.Size = new System.Drawing.Size(100, 20);
            this.textMiddlename.TabIndex = 27;
            // 
            // textFirstname
            // 
            this.textFirstname.Location = new System.Drawing.Point(87, 350);
            this.textFirstname.Name = "textFirstname";
            this.textFirstname.Size = new System.Drawing.Size(100, 20);
            this.textFirstname.TabIndex = 26;
            // 
            // textAuthorId
            // 
            this.textAuthorId.Enabled = false;
            this.textAuthorId.Location = new System.Drawing.Point(87, 324);
            this.textAuthorId.Name = "textAuthorId";
            this.textAuthorId.Size = new System.Drawing.Size(100, 20);
            this.textAuthorId.TabIndex = 25;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 450);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 33;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonMainMenu
            // 
            this.buttonMainMenu.Location = new System.Drawing.Point(174, 450);
            this.buttonMainMenu.Name = "buttonMainMenu";
            this.buttonMainMenu.Size = new System.Drawing.Size(75, 23);
            this.buttonMainMenu.TabIndex = 35;
            this.buttonMainMenu.Text = "Main Menu";
            this.buttonMainMenu.UseVisualStyleBackColor = true;
            this.buttonMainMenu.Click += new System.EventHandler(this.buttonMainMenu_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(93, 450);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 36;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(12, 479);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(776, 150);
            this.dataGridView3.TabIndex = 37;
            // 
            // AuthorBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 641);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonMainMenu);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textLastname);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textMiddlename);
            this.Controls.Add(this.textFirstname);
            this.Controls.Add(this.textAuthorId);
            this.Controls.Add(this.dateTimePickerPublishedDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textPublisherId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textPageCount);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textInternationalStandardBookNumber);
            this.Controls.Add(this.textBookId);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AuthorBookForm";
            this.Text = "Author Book";
            this.Load += new System.EventHandler(this.AuthorBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DateTimePicker dateTimePickerPublishedDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textPublisherId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textPageCount;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textInternationalStandardBookNumber;
        private System.Windows.Forms.TextBox textBookId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textLastname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textMiddlename;
        private System.Windows.Forms.TextBox textFirstname;
        private System.Windows.Forms.TextBox textAuthorId;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonMainMenu;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridView dataGridView3;
    }
}