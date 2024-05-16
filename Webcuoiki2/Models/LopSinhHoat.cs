using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Webcuoiki2.Models
{
    public class LopSinhHoat
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(255)]
        public string TenLop { get; set; }

        public int KhoaID { get; set; }

        [ForeignKey("KhoaID")]
        public virtual Khoa Khoa { get; set; }

        public virtual ICollection<SinhVien> SinhViens { get; set; }
    }
