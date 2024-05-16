using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Webcuoiki2.Models
{
    public class LopHocPhan
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(255)]
        public string TenLopHocPhan { get; set; }

        public int GiaoVienID { get; set; }

        [ForeignKey("GiaoVienID")]
        public virtual GiaoVien GiaoVien { get; set; }
    }
}
