using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QlyDVCuoi
{
    internal class CSDL
    {
        SqlConnection conn;
        private void openConnect()
        {
            conn = new SqlConnection(@"Data Source=DESKTOP-N64K7CG;Initial Catalog=QLY_TiemCuoi;Integrated Security=True;Encrypt=False");
            conn.Open();
        }
        private void closeConnect()
        {
            conn.Close();
        }
        public void DN()
        {
            openConnect();

        }
        public DataTable DS1()
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "SELECT * FROM KhachHang";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(bang);
            closeConnect();
            return bang;
        }
        public DataTable DS2()
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "SELECT * FROM ds_CDVCT";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(bang);
            closeConnect();
            return bang;
        }
        public DataTable DS3()
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "SELECT * FROM HoaDon";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(bang);
            closeConnect();
            return bang;
        }
        public DataTable DS4()
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "SELECT Ma_Don, Ma_DV, So_Luong, Don_Gia, Tong_Tien FROM ChiTietHoaDon";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(bang);
            closeConnect();
            return bang;
        }
        public DataTable Do_DL_cbMaDon()
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "select * from HoaDon";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(bang);
            closeConnect();
            return bang;
        }
        public DataTable Do_DL_cbTenDV()
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "select * from ds_CDVCT";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(bang);
            closeConnect();
            return bang;
        }
        public void ThemHD(string maD, string maDV, DateTime ngayThue, string tenKH, string maKH)
        {
            openConnect();
            string sqlInsert = "INSERT INTO HoaDon VALUES(@maD, @maDV, @ngayThue, @tenKH, @maKH)";
            SqlCommand cmdInsert = new SqlCommand(sqlInsert, conn);
            cmdInsert.Parameters.AddWithValue("maD", maD);
            cmdInsert.Parameters.AddWithValue("maDV", maDV);
            cmdInsert.Parameters.AddWithValue("ngayThue", ngayThue);
            cmdInsert.Parameters.AddWithValue("tenKH", tenKH);
            cmdInsert.Parameters.AddWithValue("maKH", maKH);
            cmdInsert.ExecuteNonQuery();
            closeConnect();
        }
        public void ThemCTHD(string maD, string maDV, int soLg, float dGia)
        {
            openConnect();
            string sqlInsert = "INSERT INTO ChiTietHoaDon VALUES(@maD, @maDV, @soLg, @dGia, @soLg * @dGia)";
            SqlCommand cmdInsert = new SqlCommand(sqlInsert, conn);
            cmdInsert.Parameters.AddWithValue("maD", maD);
            cmdInsert.Parameters.AddWithValue("maDV", maDV);
            cmdInsert.Parameters.AddWithValue("soLg", soLg);
            cmdInsert.Parameters.AddWithValue("dGia", dGia);
            cmdInsert.ExecuteNonQuery();
/*
            string sqlUpdate = "UPDATE ChiTietHoaDon SET Tong_Tien = So_Luong * Don_Gia WHERE Ma_D = @maD AND Ma_DV = @maDV";
            SqlCommand cmdUpdate = new SqlCommand(sqlUpdate, conn);
            cmdUpdate.Parameters.AddWithValue("maD", maD);
            cmdUpdate.Parameters.AddWithValue("maDV", maDV);
            cmdUpdate.ExecuteNonQuery();*/

            closeConnect();
        }

        public void ChoThueDV(string maDV, string tenDV, int donGia)
        {
            openConnect();
            string sqlInsert = "INSERT INTO ds_CDVCT VALUES(@maDV, @tenDV, @donGia)";
            SqlCommand cmdInsert = new SqlCommand(sqlInsert, conn);
            cmdInsert.Parameters.AddWithValue("maDV", maDV);
            cmdInsert.Parameters.AddWithValue("tenDV", tenDV);
            cmdInsert.Parameters.AddWithValue("donGia", donGia);
            cmdInsert.ExecuteNonQuery();
            closeConnect();
        }
        public void ThaydoiKH(string tenKH, string diaChi, int soDT, string maKH)
        {
            openConnect();
            string sqlUpdate = "UPDATE KhachHang SET Ten_KH = @hoTen, Dia_Chi = @diaChi, SoDienThoai = @soDT WHERE Ma_KH = @maKH";
            SqlCommand cmd = new SqlCommand(sqlUpdate, conn);
            cmd.Parameters.AddWithValue("@hoTen", tenKH);
            cmd.Parameters.AddWithValue("@diaChi", diaChi);
            cmd.Parameters.AddWithValue("@soDT", soDT);
            cmd.Parameters.AddWithValue("@maKH", maKH);
            cmd.ExecuteNonQuery();
            closeConnect();
        }
        public void ThaydoiHDDV(string maDV, DateTime ngayThue, string hoTen, string maKH, string maDon)
        {
            openConnect();
            string sqlUpdate = "UPDATE HoaDon SET Ma_DV = @maDV, Ngay_Thue = @ngayThue, Ten_KH = @hoTen WHERE Ma_KH = @maKH AND Ma_Don = @maDon";
            SqlCommand cmd = new SqlCommand(sqlUpdate, conn);
            cmd.Parameters.AddWithValue("@maDV", maDV);
            cmd.Parameters.AddWithValue("@ngayThue", ngayThue);
            cmd.Parameters.AddWithValue("@hoTen", hoTen);
            cmd.Parameters.AddWithValue("@maKH", maKH);
            cmd.Parameters.AddWithValue("@maDon", maDon);
            cmd.ExecuteNonQuery();
            closeConnect();
        }
        public DataTable ThayDoi()
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "SELECT KhachHang.Ma_KH, KhachHang.Ten_KH, KhachHang.Dia_Chi, KhachHang.SoDienThoai, HoaDon.Ma_Don, HoaDon.Ma_DV, HoaDon.Ngay_Thue, HoaDon.Ten_KH, ds_CDVCT.Ten_DV FROM HoaDon JOIN KhachHang ON HoaDon.Ma_KH = KhachHang.Ma_KH JOIN ds_CDVCT ON HoaDon.Ma_DV = ds_CDVCT.Ma_DV";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(bang);
            closeConnect();
            return bang;
        }
        public DataTable HopDong()
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "SELECT HoaDon.Ma_Don, HoaDon.Ma_DV, ds_CDVCT.Ten_DV, HoaDon.Ten_KH, ChiTietHoaDon.So_Luong, ChiTietHoaDon.Don_Gia, HoaDon.Ngay_Thue, ChiTietHoaDon.Tong_Tien FROM ChiTietHoaDon JOIN ds_CDVCT ON ChiTietHoaDon.Ma_DV = ds_CDVCT.Ma_DV JOIN HoaDon ON ChiTietHoaDon.Ma_Don = HoaDon.Ma_Don";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(bang);
            closeConnect();
            return bang;
        }
        public DataTable TableKtra()
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "SELECT ds.*, tt.Trang_Thai FROM ds_CDVCT ds LEFT JOIN TrangThaiDichVu tt ON ds.Ma_DV = tt.Ma_DV;";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(bang);
            closeConnect();
            return bang;
        }
        public DataTable BcaoNgay()
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "SELECT DATEPART(DAY, Ngay_Thue) AS Ngay FROM HoaDon;";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(bang);
            closeConnect();
            return bang;
        }
        public DataTable ThongKe()
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql ="SELECT \r\n    HoaDon.Ma_Don, \r\n    HoaDon.Ma_DV, \r\n    HoaDon.Ngay_Thue, \r\n    HoaDon.Ten_KH,\r\n    KhachHang.Dia_Chi,\r\n    KhachHang.SoDienThoai,\r\n    ds_CDVCT.Ten_DV,\r\n    ds_CDVCT.Don_Gia,\r\n    TrangThaiDichVu.Trang_Thai,\r\n    ChiTietHoaDon.So_Luong,\r\n    ChiTietHoaDon.Tong_Tien\r\nFROM \r\n    HoaDon\r\nJOIN \r\n    KhachHang ON HoaDon.Ma_KH = KhachHang.Ma_KH\r\nJOIN \r\n    TrangThaiDichVu ON HoaDon.Ma_DV = TrangThaiDichVu.Ma_DV\r\nJOIN \r\n    ds_CDVCT ON HoaDon.Ma_DV = ds_CDVCT.Ma_DV\r\nJOIN \r\n    ChiTietHoaDon ON HoaDon.Ma_Don = ChiTietHoaDon.Ma_Don;\r\n";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(bang);
            closeConnect();
            return bang;
        }
        public DataTable BaoCaoThang(int thang, int nam)
        {

            DataTable bang = new DataTable();
            openConnect();
            string sql = "DECLARE @Thang INT = "+thang+"; DECLARE @Nam INT = "+nam+"; SELECT * FROM HoaDon"+" WHERE DATEPART(MONTH, Ngay_Thue) = @Thang AND DATEPART(YEAR, Ngay_Thue) = @Nam;";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(bang);
            closeConnect();
            return bang;

        }
        public DataTable BaoCaoNam(int nam)
        {

            DataTable bang = new DataTable();
            openConnect();
            string sql = "DECLARE @Nam INT = " + nam + "; SELECT * FROM HoaDon" + " WHERE DATEPART(YEAR, Ngay_Thue) = @Nam;";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(bang);
            closeConnect();
            return bang;

        }
        public DataTable BaoCaoNgay(int ngay,int thang, int nam)
        {

            DataTable bang = new DataTable();
            openConnect();
            string sql = "DECLARE @Ngay INT = " + ngay +";DECLARE @Thang INT = " + thang + "; DECLARE @Nam INT = " + nam + "; SELECT * FROM HoaDon" + " WHERE DATEPART(DAY, Ngay_Thue) = @Ngay AND DATEPART(MONTH, Ngay_Thue) = @Thang AND DATEPART(YEAR, Ngay_Thue) = @Nam;";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(bang);
            closeConnect();
            return bang;

        }
        public DataTable BcaoNam()
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "SELECT DATEPART(DAY, Ngay_Thue) AS Ngay FROM HoaDon;";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(bang);
            closeConnect();
            return bang;
        }
        public DataTable TimHopDong(string maDon)
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "SELECT HoaDon.Ma_Don, HoaDon.Ma_DV, ds_CDVCT.Ten_DV, HoaDon.Ten_KH, ChiTietHoaDon.So_Luong, ChiTietHoaDon.Don_Gia, HoaDon.Ngay_Thue, ChiTietHoaDon.Tong_Tien FROM ChiTietHoaDon JOIN ds_CDVCT ON ChiTietHoaDon.Ma_DV = ds_CDVCT.Ma_DV JOIN HoaDon ON ChiTietHoaDon.Ma_Don = HoaDon.Ma_Don WHERE HoaDon.Ma_Don = '"+maDon+"'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(bang);
            closeConnect();
            return bang;
        }
        public DataTable HienthiTenDV(string ma)
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "SELECT Ten_DV FROM ds_CDVCT WHERE Ma_DV = '" + ma + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(bang);
            closeConnect();
            return bang;
        }
        public DataTable TkiemDVTheoMa(string maDV)
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "select * from  ds_CDVCT where Ma_DV like '%" + maDV + "%' ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(bang);
            closeConnect();
            return bang;
        }
        public DataTable TkiemDVTheoTen(string tenDV)
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "select * from  ds_CDVCT where Ten_DV like '%" + tenDV + "%' ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(bang);
            closeConnect();
            return bang;
        }
        public DataTable TkiemKHTheoMa(string maKH)
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "select * from  KhachHang where Ma_KH like '%" + maKH + "%'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(bang);
            closeConnect();
            return bang;
        }
        public DataTable TkiemKHTheoTen(string tenKH)
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "select * from  KhachHang where Ten_KH like '%" + tenKH + "%'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(bang);
            closeConnect();
            return bang;
        }
        public void xoaHD(string maHD)
        {
            openConnect();
            string sql = "DELETE HoaDon WHERE Ma_Don = @maHD ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("maHD", maHD);
            cmd.ExecuteNonQuery();
            closeConnect();
        }
        public Boolean DN(string userName, string passWord)
        {
            Boolean kiemTra = false;
            openConnect();
            string sql = "SELECT * FROM Qly_Taikhoan WHERE username = @userName AND password = @passWord";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("userName", userName);
            cmd.Parameters.AddWithValue("passWord", passWord);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                kiemTra = true;
            }
            closeConnect();
            return kiemTra;
        }
        public void DkyTaikhoan(string username, string password)
        {
            openConnect();
            string sqlInsert = "INSERT INTO Qly_Taikhoan VALUES (@userName, @passWord)";
            SqlCommand cmdInsert = new SqlCommand(sqlInsert, conn);
            cmdInsert.Parameters.AddWithValue("userName", username);
            cmdInsert.Parameters.AddWithValue("passWord", password);
            cmdInsert.ExecuteNonQuery();
            closeConnect();
        }
        public Boolean kTraTK(string id)
        {
            Boolean kiemTra = false;
            openConnect();
            string sql = "SELECT * from Qly_Taikhoan WHERE username = @id";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("id", id);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                kiemTra = true;
            }
            closeConnect();
            return kiemTra;
        }
        public Boolean kTraKH(string id)
        {
            Boolean kiemTra = false;
            openConnect();
            string sql = "SELECT * from KhachHang WHERE Ma_KH = @id";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("id", id);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                kiemTra = true;
            }
            closeConnect();
            return kiemTra;
        }
        public Boolean kTraDV(string id)
        {
            Boolean kiemTra = false;
            openConnect();
            string sql = "SELECT * from ds_CDVCT WHERE Ma_DV = @id";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("id", id);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                kiemTra = true;
            }
            closeConnect();
            return kiemTra;
        }
        public void xoaTaikhoan(string userName)
        {
            openConnect();
            string sql = "DELETE Qly_Taikhoan WHERE username = @userName ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("username", userName);
            cmd.ExecuteNonQuery();
            closeConnect();
        }
    }
}
