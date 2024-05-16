using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuanLySinhVien.Models
{
    public class SinhVien
    {
        public int MaSV { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập họ tên")]
        public string HoTen { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime NgaySinh { get; set; }

        public bool GioiTinh { get; set; } // True: Nam, False: Nu

        public int MaLopSH { get; set; }

        public int MaKhoa { get; set; }

        public int MaTruong { get; set; }

        public virtual LopSinhHoat LopSH { get; set; }
        public virtual Khoa Khoa { get; set; }
        public virtual Truong Truong { get; set; }
    }

    public class LopSinhHoat
    {
        public int MaLopSH { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập tên lớp")]
        public string TenLop { get; set; }

        public int MaKhoa { get; set; }

        public virtual Khoa Khoa { get; set; }
        public virtual ICollection<SinhVien> SinhVien { get; set; }
    }

    public class LopHocPhan
    {
        public int MaLHP { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập tên lớp học phần")]
        public string TenLHP { get; set; }

        public int MaGiaoVien { get; set; }

        public int MaKhoa { get; set; }

        public virtual GiaoVien GiaoVien { get; set; }
        public virtual Khoa Khoa { get; set; }
    }

    public class GiaoVien
    {
        public int MaGiaoVien { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập họ tên")]
        public string HoTen { get; set; }

        public int MaKhoa { get; set; }

        public virtual Khoa Khoa { get; set; }
        public virtual ICollection<LopHocPhan> LopHocPhan { get; set; }
    }

    public class Khoa
    {
        public int MaKhoa { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập tên khoa")]
        public string TenKhoa { get; set; }

        public int MaTruong { get; set; }

        public virtual Truong Truong { get; set; }
        public virtual ICollection<LopSinhHoat> LopSH { get; set; }
        public virtual ICollection<LopHocPhan> LopHP { get; set; }
        public virtual ICollection<GiaoVien> GiaoVien { get; set; }
        public virtual ICollection<SinhVien> SinhVien { get; set; }
    }

    public class Truong
    {
        public int MaTruong { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập tên trường")]
        public string TenTruong { get; set; }

        public virtual ICollection<Khoa> Khoa { get; set; }
        public virtual ICollection<SinhVien> SinhVien { get; set; }
    }
}