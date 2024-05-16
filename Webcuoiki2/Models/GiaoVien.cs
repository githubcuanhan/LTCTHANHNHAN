using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Webcuoiki2.Models
{
    public class GiaoVien
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(255)]
        public string HoTen { get; set; }

        [Required]
        [StringLength(255)]
        public string ChucDanh { get; set; }

        public int KhoaID { get; set; }

        [ForeignKey("KhoaID")]
        public virtual Khoa Khoa { get; set; }

        public virtual ICollection<LopHocPhan> LopHocPhans { get; set; }
    }
}
