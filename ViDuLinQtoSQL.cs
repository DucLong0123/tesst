using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KetNoiADO.NET
{
    public partial class ViDuLinQtoSQL : Form
    {
        public ViDuLinQtoSQL()
        {
            InitializeComponent();
        }
        
        QLCuaHangDataContext DB = new QLCuaHangDataContext();

        private void ViDuLinQtoSQL_Load(object sender, EventArgs e)
        {
            LoadMatHang();

            //string userName = "admin"; //txt_Username.Text
            //string password = "123"; //txt_Password.Text
            //NhanVien nhanvien = DB.NhanViens.Where(nv => nv.Username == userName && nv.Password == password).FirstOrDefault(); //Trả về 1 đối tượng đầu tiên, hoặc null (nếu không tồn tại)
            //if(nhanvien != null )
            //{
            //    //Đăng nhập thành công
            //}
            //else
            //{  
            //    //Đăng nhập thất bại
            //}

        }

        private void LoadMatHang()
        {
            dgv_MatHang.DataSource = DB.MatHangs.ToList();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            //Tạo mới 1 đối tượng
            MatHang mh = new MatHang();
            //Gán dữ liệu cho đối tượng
            mh.TenHang = txt_TenHang.Text;
            try
            {
                mh.SoLuong = int.Parse(txt_SoLuong.Text);
                mh.DonGia = int.Parse(txt_DonGia.Text);
            }
            catch {
                MessageBox.Show("Giá trị Số lượng/Đơn giá vào phải là kiểu số");
                return;
            }
            //Thêm đối tượng vào DataContext --> bảng
            DB.MatHangs.InsertOnSubmit(mh);

            //Cập nhật CSDL
            try
            {
                DB.SubmitChanges();
                MessageBox.Show("Thêm mặt hàng thành công");

                //Load lại bảng
                LoadMatHang();
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi xảy ra!");
                return;
            }

            
        }
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            //Tìm mặt hàng cần xóa theo txt_IDXoa
            MatHang mhcanxoa = DB.MatHangs.Where(mh => mh.MaHang == int.Parse(txt_IDXoa.Text)).FirstOrDefault();

            //Xóa mặt hàng trong DataContext
            if (mhcanxoa != null)
            {
                DB.MatHangs.DeleteOnSubmit(mhcanxoa);
            }
            else return;

            //Cập nhật CSDL
            try
            {
                DB.SubmitChanges();
                MessageBox.Show("Xóa mặt hàng thành công");

                //Load lại bảng
                LoadMatHang();
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi xảy ra!");
                return;
            }

        }

        private void txt_IDSua_TextChanged(object sender, EventArgs e)
        {
            try
            {
                MatHang mhsua = DB.MatHangs.Where(mh => mh.MaHang == int.Parse(txt_IDSua.Text)).FirstOrDefault();
                if(mhsua != null)
                {
                    txt_TenHang_Sua.Text = mhsua.TenHang;
                    txt_SoLuong_Sua.Text = mhsua.SoLuong.ToString();
                    txt_DonGia_Sua.Text = mhsua.DonGia.ToString();
                }
                
            }
            catch (Exception)
            {
                return;
            }

        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            MatHang mhsua = DB.MatHangs.Where(mh => mh.MaHang == int.Parse(txt_IDSua.Text)).FirstOrDefault();
            if(mhsua != null)
            {
                mhsua.TenHang = txt_TenHang_Sua.Text;
                mhsua.SoLuong = int.Parse(txt_SoLuong_Sua.Text);
                mhsua.DonGia = int.Parse(txt_DonGia_Sua.Text);
                DB.SubmitChanges();
                LoadMatHang();
            }
        }

        private void txt_SoLuong_Sua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_DonGia_Sua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
