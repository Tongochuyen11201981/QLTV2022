using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV2022
{
    public partial class Frm_Docgia : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable com2dt = new DataTable();
        String sql, constr;
        Boolean addnewflag = false;
        public Frm_Docgia()
        {
            InitializeComponent();
        }

        private void Frm_Docgia_Load(object sender, EventArgs e)
        {
            constr = @"Data Source=LENOVO;Initial Catalog=QLTV;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            sql = " Select MADG, HOTENDG, GIOITINH, NGAYSINH, SODIENTHOAIDG From DOCGIA";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            grDMDG.DataSource = dt;
            NapCT();
            
        }
        public void NapCT()
        {
            int i = grDMDG.CurrentRow.Index;
            txtMaDG.Text = grDMDG.Rows[i].Cells["MADG"].Value.ToString();
            txtHoten.Text = grDMDG.Rows[i].Cells["HOTENDG"].Value.ToString();
            comGioitinh.Text = grDMDG.Rows[i].Cells["GIOITINH"].Value.ToString();
            dateTimePicker1.Text = grDMDG.Rows[i].Cells["NGAYSINH"].Value.ToString();
            txtSDT.Text = grDMDG.Rows[i].Cells["SODIENTHOAIDG"].Value.ToString();
        }
        private void gb1_Enter(object sender, EventArgs e)
        {

        }

        private void grDMDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void btnDau_Click(object sender, EventArgs e)
        {
            grDMDG.ClearSelection();
            grDMDG.CurrentCell = grDMDG[0, 0];
            NapCT();
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            int i = grDMDG.CurrentRow.Index;
            if (i > 0)
            {
                grDMDG.CurrentCell = grDMDG[0, i - 1];
                NapCT();
            }
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            int i = grDMDG.CurrentRow.Index;
            if (i < grDMDG.RowCount - 1)
            {
                grDMDG.CurrentCell = grDMDG[0, i + 1];
                NapCT();
            }
        }

        private void btnCuoi_Click(object sender, EventArgs e)
        {
            grDMDG.ClearSelection();
            grDMDG.CurrentCell = grDMDG[0, grDMDG.RowCount - 1];
            NapCT();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            sql = "Select MADG, HOTENDG, GIOITINH, NGAYSINH, SODIENTHOAIDG From tblDMHH";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            grDMDG.DataSource = dt;
            NapCT();


            grDMDG.CurrentCell = grDMDG[0, grDMDG.RowCount - 1];
            NapCT();
            MessageBox.Show("Hãy nhập nội dung bản ghi mới, kết thúc bấm Cập nhật!");
            txtMaDG.Focus();
            addnewflag = true;
            btnLuu.Enabled = true;

        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi hiện thời?Y/N", "Xác nhận " +
                "yêu cầu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                sql = "Delete from tblDMHH where MaHH='" + txtMaDG.Text + "'";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                grDMDG.Rows.RemoveAt(grDMDG.CurrentRow.Index);
                NapCT();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (addnewflag == false)
            {
                int i = grDMDG.CurrentRow.Index;
                //chỗ này là cập nhật sửa chữa
                for (i = 0; i < grDMDG.RowCount - 1; i++)
                {
                    txtMaDG.Text = grDMDG.Rows[i].Cells["MADG"].Value.ToString();
                    txtHoten.Text = grDMDG.Rows[i].Cells["HOTENDG"].Value.ToString();
                    comGioitinh.Text = grDMDG.Rows[i].Cells["GIOITINH"].Value.ToString();
                    dateTimePicker1.Text = grDMDG.Rows[i].Cells["NGAYSINH"].Value.ToString();
                    txtSDT.Text = grDMDG.Rows[i].Cells["SODIENTHOAIDG"].Value.ToString();
                    sql = "update DOCGIA set SODIENTHOAIDG=" + txtSDT.Text + "," +
                        " HOTENDG=N'" + txtHoten.Text + "'GIOITINH=N'" + comGioitinh.Text + "'," +
                        "NGAYSINH=N'" + dateTimePicker1.Text + "'Where MADG='" + txtMaDG.Text + "'";
                    cmd.Connection = conn;
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Đã cập nhật thành công!", "Thông báo");


            }
            else
            {
                // chỗ này là cập nhật thêm mới
                addnewflag = false;
                sql = "Insert into DOCGIA (MADG, HOTENDG, GIOITINH, NGAYSINH, SODIENTHOAIDG)" +
                    " Values ('" + txtMaDG.Text + "', '" + txtHoten.Text + "',N'" +
                    comGioitinh.Text + "',N'" + dateTimePicker1.Text + "'," + txtSDT.Text + ",N'" + "')";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                int i = grDMDG.CurrentRow.Index;
                grDMDG.Rows[i].Cells["MADG"].Value = txtMaDG.Text;
                grDMDG.Rows[i].Cells["HOTENDG"].Value = txtHoten.Text;
                grDMDG.Rows[i].Cells["GIOITINH"].Value = comGioitinh.Text;
                grDMDG.Rows[i].Cells["NGAYSINH"].Value = dateTimePicker1.Text;
                grDMDG.Rows[i].Cells["SODIENTHOAIDG"].Value = txtSDT.Text;
            }
            btnLuu.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hãy thực hiện mọi sửa đổi mong muốn trên ô lưới, " +
                "kết thúc bấm nút Cập nhật", "Thông báo", MessageBoxButtons.OK);
            btnLuu.Enabled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grDMDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
    }
}
