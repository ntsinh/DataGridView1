using System.Data;

namespace DataGridView2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        int indexrow;
        private void dgvSp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            dt.Columns.Add("Id", typeof(string));
            dt.Columns.Add("Tên Sp", typeof(string));
            dt.Columns.Add("Giá", typeof(float));
            dt.Columns.Add("Số Lượng", typeof(int));
            dt.Rows.Add("01", "Sp1", 10000, 12);
            dt.Rows.Add("02", "Sp2", 13000, 17);
            dt.Rows.Add("03", "Sp3", 112000, 21);
            dt.Rows.Add("04", "Sp4", 15000, 51);
            dgvSp.DataSource = dt;

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            dt.Rows.Add(txtId.Text, txtTen.Text, txtGia.Text, txtSl.Text);
            Clear();
        }

        private void dgvSp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow row = dgvSp.Rows[e.RowIndex];
            string id = row.Cells[0].Value.ToString();
            string tenSp = row.Cells[1].Value.ToString();
            float gia = float.Parse(row.Cells[2].Value.ToString());
            string soLuong = row.Cells[3].Value.ToString();
            txtId.Text = id;
            txtTen.Text = tenSp;
            txtGia.Text = gia.ToString();
            txtSl.Text = soLuong;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            indexrow = dgvSp.CurrentCell.RowIndex;
            dgvSp.Rows.RemoveAt(indexrow);
            Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            indexrow = dgvSp.CurrentCell.RowIndex;
            DataGridViewRow newDatarow = dgvSp.Rows[indexrow];
            newDatarow.Cells[0].Value = txtId.Text;
            newDatarow.Cells[1].Value = txtTen.Text;
            newDatarow.Cells[2].Value = txtGia.Text;
            newDatarow.Cells[3].Value = txtSl.Text;
            Clear();
        }
        public void Clear()
        {
            txtId.Text = "";
            txtTen.Text = "";
            txtGia.Text = "";
            txtSl.Text = "";
        }
    }
}