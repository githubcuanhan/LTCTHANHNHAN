using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Webcuoiki2.Models
{
    public class Khoa
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(255)]
        public string TenKhoa { get; set; }

        public virtual ICollection<SinhVien> SinhViens { get; set; }

        public virtual ICollection<LopSinhHoat> LopSinhHoats { get; set; }

        public virtual ICollection<GiaoVien> GiaoViens { get; set; }
    }

}
