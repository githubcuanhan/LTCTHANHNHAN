using Microsoft.EntityFrameworkCore;
using Webcuoiki2.Models;
using Webcuoiki2;
namespace Webcuoiki2.Data
{
    public class QuanLySinhVienContext : DbContext
    {
        public QuanLySinhVienContext() : base("name=QuanLySinhVien") { }

        public DbSet<SinhVien> SinhViens { get; set; }
        public DbSet<LopSinhHoat> LopSinhHoats { get; set; }
        public DbSet<LopHocPhan> LopHocPhans { get; set; }
        public DbSet<GiaoVien> GiaoViens { get; set; }
        public DbSet<Khoa> Khoa { get; set; }
        public DbSet<Truong> Truong { get; set; }
    }
}