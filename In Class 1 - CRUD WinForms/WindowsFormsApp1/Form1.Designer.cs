
namespace WindowsFormsApp1
{
    partial class MemberProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberProfile));
            this.dataGrid_DispRec = new System.Windows.Forms.DataGridView();
            this.regIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.authenticateDataSet1 = new WindowsFormsApp1.AuthenticateDataSet1();
            this.authenticateDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.authenticateDataSet = new WindowsFormsApp1.AuthenticateDataSet();
            this.btn_displayAll = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.txt_reg = new System.Windows.Forms.TextBox();
            this.txt_firstName = new System.Windows.Forms.TextBox();
            this.txt_lastName = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.profDetailsTableAdapter = new WindowsFormsApp1.AuthenticateDataSet1TableAdapters.ProfDetailsTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_DispRec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authenticateDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authenticateDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authenticateDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_DispRec
            // 
            this.dataGrid_DispRec.AutoGenerateColumns = false;
            this.dataGrid_DispRec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_DispRec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.regIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.dataGrid_DispRec.DataSource = this.profDetailsBindingSource;
            this.dataGrid_DispRec.Location = new System.Drawing.Point(159, 429);
            this.dataGrid_DispRec.Name = "dataGrid_DispRec";
            this.dataGrid_DispRec.RowHeadersWidth = 51;
            this.dataGrid_DispRec.RowTemplate.Height = 24;
            this.dataGrid_DispRec.Size = new System.Drawing.Size(720, 151);
            this.dataGrid_DispRec.TabIndex = 0;
            this.dataGrid_DispRec.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_DispRec_CellContentClick);
            // 
            // regIDDataGridViewTextBoxColumn
            // 
            this.regIDDataGridViewTextBoxColumn.DataPropertyName = "RegID";
            this.regIDDataGridViewTextBoxColumn.HeaderText = "RegID";
            this.regIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.regIDDataGridViewTextBoxColumn.Name = "regIDDataGridViewTextBoxColumn";
            this.regIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // profDetailsBindingSource
            // 
            this.profDetailsBindingSource.DataMember = "ProfDetails";
            this.profDetailsBindingSource.DataSource = this.authenticateDataSet1;
            // 
            // authenticateDataSet1
            // 
            this.authenticateDataSet1.DataSetName = "AuthenticateDataSet1";
            this.authenticateDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // authenticateDataSetBindingSource
            // 
            this.authenticateDataSetBindingSource.DataSource = this.authenticateDataSet;
            this.authenticateDataSetBindingSource.Position = 0;
            // 
            // authenticateDataSet
            // 
            this.authenticateDataSet.DataSetName = "AuthenticateDataSet";
            this.authenticateDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_displayAll
            // 
            this.btn_displayAll.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_displayAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_displayAll.Location = new System.Drawing.Point(419, 591);
            this.btn_displayAll.Name = "btn_displayAll";
            this.btn_displayAll.Size = new System.Drawing.Size(211, 45);
            this.btn_displayAll.TabIndex = 1;
            this.btn_displayAll.Text = "Display all records";
            this.btn_displayAll.UseVisualStyleBackColor = false;
            this.btn_displayAll.Click += new System.EventHandler(this.btn_displayAll_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insert.Location = new System.Drawing.Point(269, 334);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(100, 45);
            this.btn_insert.TabIndex = 2;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = false;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_delete.Enabled = false;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(542, 334);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(100, 45);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(683, 334);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(100, 45);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_update.Enabled = false;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(403, 334);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(100, 45);
            this.btn_update.TabIndex = 5;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(844, 377);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(100, 45);
            this.btn_search.TabIndex = 6;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(213, 389);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(616, 22);
            this.txt_search.TabIndex = 7;
            // 
            // txt_reg
            // 
            this.txt_reg.Location = new System.Drawing.Point(236, 138);
            this.txt_reg.Name = "txt_reg";
            this.txt_reg.Size = new System.Drawing.Size(581, 22);
            this.txt_reg.TabIndex = 8;
            // 
            // txt_firstName
            // 
            this.txt_firstName.Location = new System.Drawing.Point(236, 175);
            this.txt_firstName.Name = "txt_firstName";
            this.txt_firstName.Size = new System.Drawing.Size(581, 22);
            this.txt_firstName.TabIndex = 9;
            // 
            // txt_lastName
            // 
            this.txt_lastName.Location = new System.Drawing.Point(236, 208);
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.Size = new System.Drawing.Size(581, 22);
            this.txt_lastName.TabIndex = 10;
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(236, 240);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(578, 86);
            this.txt_address.TabIndex = 11;
            this.txt_address.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Reg ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(110, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(132, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Address";
            // 
            // profDetailsTableAdapter
            // 
            this.profDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(192)))), ((int)(((byte)(216)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btn_displayAll);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_address);
            this.panel1.Controls.Add(this.txt_lastName);
            this.panel1.Controls.Add(this.txt_firstName);
            this.panel1.Controls.Add(this.txt_reg);
            this.panel1.Controls.Add(this.txt_search);
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.btn_insert);
            this.panel1.Controls.Add(this.dataGrid_DispRec);
            this.panel1.Location = new System.Drawing.Point(90, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1019, 647);
            this.panel1.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(336, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(493, 98);
            this.label5.TabIndex = 16;
            this.label5.Text = "Nova Trail";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(227, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 110);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // MemberProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1197, 645);
            this.Controls.Add(this.panel1);
            this.Name = "MemberProfile";
            this.Text = "JoeyA";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_DispRec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authenticateDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authenticateDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authenticateDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid_DispRec;
        private System.Windows.Forms.BindingSource authenticateDataSetBindingSource;
        private AuthenticateDataSet authenticateDataSet;
        private System.Windows.Forms.Button btn_displayAll;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.TextBox txt_reg;
        private System.Windows.Forms.TextBox txt_firstName;
        private System.Windows.Forms.TextBox txt_lastName;
        private System.Windows.Forms.RichTextBox txt_address;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private AuthenticateDataSet1 authenticateDataSet1;
        private System.Windows.Forms.BindingSource profDetailsBindingSource;
        private AuthenticateDataSet1TableAdapters.ProfDetailsTableAdapter profDetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn regIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
    }
}

