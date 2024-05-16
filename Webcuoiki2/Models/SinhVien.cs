using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Webcuoiki2.Models
{
    public class SinhVien
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(255)]
        public string HoTen { get; set; }

        [Required]
        public DateTime NgaySinh { get; set; }

        public int LopSinhHoatID { get; set; }

        public int KhoaID { get; set; }

        [ForeignKey("LopSinhHoatID")]
        public virtual LopSinhHoat LopSinhHoat { get; set; }

        [ForeignKey("KhoaID")]
        public virtual Khoa Khoa { get; set; }
    }