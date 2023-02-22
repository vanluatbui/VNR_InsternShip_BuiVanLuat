using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VNR_InsternShip_BuiVanLuat.Entity
{
    [Table("KhoaHoc")]
    public class KhoaHoc
    {
        public KhoaHoc()
        {
            // Một khoá học có nhiều môn học
            MonHocs = new List<MonHoc>();
        }

        [Key]
        public int ID { get; set; }

        [Column(TypeName = "NVARCHAR")]
        [MaxLength(100)]
        public string? TenKhoaHoc { get; set; }

        // Một khoá học có nhiều môn học
        public List<MonHoc> MonHocs { get; set; }
    }
}
