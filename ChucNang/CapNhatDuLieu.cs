using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace KetNoiADO.NET.ChucNang
{
    public partial class CapNhatDuLieu : UserControl
    {
        public CapNhatDuLieu()
        {
            InitializeComponent();
            
        }
        static string sql = "SELECT * FROM NhanVien";
        //Kết nối CSDL có userid và mật khẩu
        static string connStr = "Data Source = DUCLONG-PC\\SQLEXPRESS;Initial Catalog=QLCuaHang; " +
            "User Id = sa; Password = 1";
        SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, connStr);
        DataSet dataSet = new DataSet();

        private void LoadGrid()
        {
            string sql = "SELECT * from NhanVien";
            clConnect cl = new clConnect(); 
            dgv_NhanVien.DataSource = cl.LoadData(sql);
            
            //dataAdapter = new SqlDataAdapter(sql, connStr);
            //dataSet = new DataSet();
            //dataAdapter.Fill(dataSet, "NhanVien");
            //DataView dataView = new DataView(dataSet.Tables["NhanVien"]);
            
            ////Load dữ liệu từ dataView vào GridView
            //dgv_NhanVien.DataSource = dataView;
            
            //Tắt chức năng Sort dữ liệu theo cột
            foreach (DataGridViewColumn dgvc in dgv_NhanVien.Columns)
            {
                dgvc.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        private void CapNhatDuLieu_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void ResetTextBox()
        {
            txt_HoTen.Clear();
            txt_DiaChi.Clear();
            txt_Username.Clear(); 
            txt_Password.Clear();
            txt_Quyen.Text = "1";
            txt_Username_Sua.Clear();
            txt_DiaChi_Sua.Clear();
            txt_Username_Sua.Clear();
            txt_Password_Sua.Clear();
            txt_Quyen_Sua.Clear();
            txt_Xoa.Clear();
            dgv_NhanVien.ClearSelection();
            dgv_NhanVien.CurrentCell = null;
            txt_HoTen.Focus();

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dgv_NhanVien.Rows)
            {
                if (row.Cells[3].Value.ToString() == txt_Username.Text)
                {
                    MessageBox.Show("Username đã tồn tại","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Username.Focus();
                    return;
                }
            }
            clConnect cl = new clConnect();
            string sql = "INSERT INTO NHANVIEN(HoTen,DiaChi,Username,Password,Quyen) VALUES (@HoTen,@DiaChi,@Username,@Password,@Quyen)";
            int n_prm = 5;
            string[] name = new string[n_prm];
            object[] value = new object[n_prm];
            name[0] = "@HoTen"; value[0] = txt_HoTen.Text;
            name[1] = "@DiaChi"; value[1] = txt_DiaChi.Text;
            name[2] = "@Username"; value[2] = txt_Username.Text;
            name[3] = "@Password"; value[3] = txt_Password.Text;
            name[4] = "@Quyen"; value[4] = txt_Quyen.Text;
            
            if (cl.UpdateData(sql, name, value, n_prm) > 0)
            {
                MessageBox.Show("Thêm nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGrid();
                ResetTextBox();
                //ResetText();
            }
            else
            {
                MessageBox.Show("Thêm nhân viên thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //if(txt_Username.Text==""||txt_Password.Text=="")
            //{
            //    MessageBox.Show("Không được để trống Username hoặc Mật khẩu", "Thông báo", MessageBoxButtons.OK, 
            //        MessageBoxIcon.Warning);
            //}
            //Khởi tạo CommanBuilder cho phép cập nhập CSDL thông qua dataAdapter
            //SqlCommandBuilder cb = new SqlCommandBuilder(dataAdapter);
            ////Thêm dữ liệu mới
            //DataTable dataTable = dataSet.Tables["NhanVien"];
            //DataRow dataRow = dataTable.NewRow();
            //dataRow["HoTen"] = txt_HoTen.Text;
            //dataRow["DiaChi"] = txt_DiaChi.Text;
            //dataRow["Username"] = txt_Username.Text;
            //dataRow["Password"] = txt_Password.Text;
            //dataRow["Quyen"] = txt_Quyen.Text;
            //dataTable.Rows.Add(dataRow);
            ////Cập nhật CSDL vào bảng NhanVien
            //dataAdapter.Update(dataSet, "NhanVien");
            //LoadGrid();

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn xóa nhân viên "+txt_HoTen_Sua.Text,"Thông báo",MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                clConnect cl = new clConnect();
                string sql = "DELETE FROM NhanVien WHERE ID = @ID";
                int n_prm = 1;
                string[] name = new string[n_prm];
                object[] value = new object[n_prm];
                name[0] = "@ID"; value[0] = txt_Xoa.Text;
                if (cl.UpdateData(sql, name, value, n_prm) > 0)
                {
                    MessageBox.Show("Xóa nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            //int dong_can_xoa = int.Parse(txt_Xoa.Text);
            //Khởi tạo CommanBuilder cho phép cập nhập CSDL thông qua dataAdapter
            //SqlCommandBuilder cb = new SqlCommandBuilder(dataAdapter);
            ////Xóa dòng
            //DataTable dataTable = dataSet.Tables["NhanVien"];

            

            //try
            //{
            //    dataTable.Rows[ID_sua].Delete();
            //    //Cập nhật CSDL vào bảng NhanVien
            //    dataAdapter.Update(dataSet, "NhanVien");
            //}
            //catch
            //{
            //    MessageBox.Show("Có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            
            LoadGrid();
        }

        private void dgv_NhanVien_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            //Khởi tạo CommanBuilder cho phép cập nhập CSDL thông qua dataAdapter
            SqlCommandBuilder cb = new SqlCommandBuilder(dataAdapter);
            //Sửa dữ liệu
            //DataTable dataTable = dataSet.Tables["NhanVien"];
            ////Lấy vị trí hiện tại của dòng được chọn trên Gridview
            //int ID_sua = dgv_NhanVien.CurrentRow.Index;
            //DataRow dataRow = dataTable.Rows[ID_sua];
            //dataRow["HoTen"] = txt_HoTen_Sua.Text;
            //dataRow["DiaChi"] = txt_DiaChi_Sua.Text;
            //dataRow["Username"] = txt_Username_Sua.Text;
            //dataRow["Password"] = txt_Password_Sua.Text;
            //dataRow["Quyen"] = txt_Quyen_Sua.Text;
            ////Cập nhật CSDL vào bảng NhanVien
            //dataAdapter.Update(dataSet, "NhanVien");

            string tenNV = dgv_NhanVien.SelectedRows[0].Cells["HoTen"].Value.ToString();
            string userName_old = dgv_NhanVien.SelectedRows[0].Cells["Username"].Value.ToString();
            if(txt_Username_Sua.Text!=userName_old)
            {
                foreach (DataGridViewRow row in dgv_NhanVien.Rows)
                {
                    if (row.Cells["Username"].Value.ToString() == txt_Username_Sua.Text)
                    {
                        MessageBox.Show("Username đã tồn tại","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        txt_Username_Sua.Focus();
                        return;
                    }
                }
            }

            if (MessageBox.Show("Bạn có muốn sửa nhân viên " + tenNV, "Thông báo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                clConnect cl = new clConnect();
                string sql = "UPDATE NhanVien SET HoTen = @HoTen, DiaChi = @DiaChi, Username = @Username, Password = @Password, Quyen = @Quyen WHERE ID = @ID";
                int n_prm = 6;
                string[] name = new string[n_prm];
                object[] value = new object[n_prm];
                name[0] = "@HoTen"; value[0] = txt_HoTen_Sua.Text;
                name[1] = "@DiaChi"; value[1] = txt_DiaChi_Sua.Text;
                name[2] = "@Username"; value[2] = txt_Username_Sua.Text;
                name[3] = "@Password"; value[3] = txt_Password_Sua.Text;
                name[4] = "@Quyen"; value[4] = txt_Quyen_Sua.Text;
                name[5] = "@ID"; value[5] = txt_ID.Text;
                if (cl.UpdateData(sql, name, value, n_prm) > 0)
                {
                    MessageBox.Show("Sửa nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetTextBox();
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            LoadGrid();
        }

        private void dgv_NhanVien_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (var brush = new SolidBrush(Color.Black))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(),
                                      e.InheritedRowStyle.Font, brush, e.RowBounds.Location.X + 15,
                                      e.RowBounds.Location.Y + 4
                    );
            }
        }

        int ID_sua = -1;
        private void dgv_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Lấy vị trí hiện tại của dòng được chọn trên Gridview
            try
            {
                ID_sua = e.RowIndex;
                DataGridViewRow row = dgv_NhanVien.Rows[ID_sua];
                //DataTable dataTable = dataSet.Tables["NhanVien"];
                txt_HoTen_Sua.Text = row.Cells["HoTen"].Value.ToString();
                txt_DiaChi_Sua.Text = row.Cells["DiaChi"].Value.ToString();
                txt_Username_Sua.Text = row.Cells["Username"].Value.ToString();
                txt_Password_Sua.Text = row.Cells["Password"].Value.ToString();
                txt_Quyen_Sua.Text = row.Cells["Quyen"].Value.ToString();
                txt_Xoa.Text = row.Cells["ID"].Value.ToString();
                txt_ID.Text = row.Cells["ID"].Value.ToString();
            }
            catch { 
            }
        }
    }
}
