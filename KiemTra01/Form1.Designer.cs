using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace KiemTra01

{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            btnThem = new Button();
            btnXoa = new Button();
            btnThanhtoan = new Button();
            dataGridViewCart = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            label4 = new Label();
            lblTongGiaTri = new TextBox();
            dataGridView1 = new DataGridView();
            txtName = new DataGridViewTextBoxColumn();
            txtGia = new DataGridViewTextBoxColumn();
            txtSoluong = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(486, 17);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(138, 148);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(151, 354);
            btnThem.Margin = new Padding(3, 2, 3, 2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(115, 22);
            btnThem.TabIndex = 7;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(389, 354);
            btnXoa.Margin = new Padding(3, 2, 3, 2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(115, 22);
            btnXoa.TabIndex = 8;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThanhtoan
            // 
            btnThanhtoan.Location = new Point(661, 354);
            btnThanhtoan.Margin = new Padding(3, 2, 3, 2);
            btnThanhtoan.Name = "btnThanhtoan";
            btnThanhtoan.Size = new Size(115, 22);
            btnThanhtoan.TabIndex = 9;
            btnThanhtoan.Text = "Thanh toán";
            btnThanhtoan.UseVisualStyleBackColor = true;
            btnThanhtoan.Click += btnThanhtoan_Click;
            // 
            // dataGridViewCart
            // 
            dataGridViewCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCart.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridViewCart.Location = new Point(83, 193);
            dataGridViewCart.Margin = new Padding(3, 2, 3, 2);
            dataGridViewCart.Name = "dataGridViewCart";
            dataGridViewCart.RowHeadersWidth = 51;
            dataGridViewCart.Size = new Size(541, 142);
            dataGridViewCart.TabIndex = 10;
            dataGridViewCart.CellContentClick += dataGridViewCart_CellContentClick_1;
            // 
            // Column1
            // 
            Column1.HeaderText = "Name";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Giá";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Số lượng";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Tổng giá trị";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(645, 247);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 12;
            label4.Text = "Tổng:";
            // 
            // lblTongGiaTri
            // 
            lblTongGiaTri.Location = new Point(697, 239);
            lblTongGiaTri.Margin = new Padding(3, 2, 3, 2);
            lblTongGiaTri.Name = "lblTongGiaTri";
            lblTongGiaTri.Size = new Size(156, 23);
            lblTongGiaTri.TabIndex = 11;
            lblTongGiaTri.TextChanged += lblTongGiaTri_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { txtName, txtGia, txtSoluong });
            dataGridView1.Location = new Point(83, 17);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(397, 148);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // txtName
            // 
            txtName.HeaderText = "Name";
            txtName.MinimumWidth = 6;
            txtName.Name = "txtName";
            txtName.Width = 125;
            // 
            // txtGia
            // 
            txtGia.HeaderText = "Giá";
            txtGia.MinimumWidth = 6;
            txtGia.Name = "txtGia";
            txtGia.Width = 125;
            // 
            // txtSoluong
            // 
            txtSoluong.HeaderText = "Số lượng";
            txtSoluong.MinimumWidth = 6;
            txtSoluong.Name = "txtSoluong";
            txtSoluong.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 396);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(lblTongGiaTri);
            Controls.Add(dataGridViewCart);
            Controls.Add(btnThanhtoan);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCart).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnThem;
        private Button btnXoa;
        private Button btnThanhtoan;
        private DataGridView dataGridViewCart;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Label label4;
        private TextBox lblTongGiaTri;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn txtName;
        private DataGridViewTextBoxColumn txtGia;
        private DataGridViewTextBoxColumn txtSoluong;
    }
}
