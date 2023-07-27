namespace DataGridView2
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
            dgvSp = new DataGridView();
            label1 = new Label();
            txtId = new TextBox();
            label2 = new Label();
            txtTen = new TextBox();
            label3 = new Label();
            txtGia = new TextBox();
            label4 = new Label();
            txtSl = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSp).BeginInit();
            SuspendLayout();
            // 
            // dgvSp
            // 
            dgvSp.BackgroundColor = SystemColors.ButtonHighlight;
            dgvSp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSp.Location = new Point(263, 12);
            dgvSp.Name = "dgvSp";
            dgvSp.ReadOnly = true;
            dgvSp.RowTemplate.Height = 25;
            dgvSp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSp.Size = new Size(379, 303);
            dgvSp.TabIndex = 0;
            dgvSp.CellClick += dgvSp_CellClick;
            dgvSp.CellContentClick += dgvSp_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 1;
            label1.Text = "Id";
            // 
            // txtId
            // 
            txtId.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtId.Location = new Point(91, 12);
            txtId.Name = "txtId";
            txtId.Size = new Size(166, 27);
            txtId.TabIndex = 2;
            txtId.TextChanged += txtId_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 55);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên Sp";
            // 
            // txtTen
            // 
            txtTen.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtTen.Location = new Point(91, 52);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(166, 27);
            txtTen.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 96);
            label3.Name = "label3";
            label3.Size = new Size(31, 20);
            label3.TabIndex = 1;
            label3.Text = "Giá";
            // 
            // txtGia
            // 
            txtGia.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtGia.Location = new Point(91, 93);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(166, 27);
            txtGia.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 136);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 1;
            label4.Text = "Số Lượng";
            // 
            // txtSl
            // 
            txtSl.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtSl.Location = new Point(91, 133);
            txtSl.Name = "txtSl";
            txtSl.Size = new Size(166, 27);
            txtSl.TabIndex = 2;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.DarkOrange;
            btnThem.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.Location = new Point(12, 179);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(245, 35);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.DarkOrange;
            btnSua.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSua.Location = new Point(12, 227);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(245, 35);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Red;
            btnXoa.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoa.Location = new Point(12, 274);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(245, 35);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 321);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(txtSl);
            Controls.Add(label4);
            Controls.Add(txtGia);
            Controls.Add(label3);
            Controls.Add(txtTen);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Controls.Add(dgvSp);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSp).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSp;
        private Label label1;
        private TextBox txtId;
        private Label label2;
        private TextBox txtTen;
        private Label label3;
        private TextBox txtGia;
        private Label label4;
        private TextBox txtSl;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
    }
}