using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VNR_InsternShip_BuiVanLuat.Entity
{
    [Table("MonHoc")]
    public class MonHoc
    {
        [Key]
        public int ID { get; set; }


        [Column(TypeName = "NVARCHAR")]
        [MaxLength(100)]
        public string? TenMonHoc { get; set; }

        [Column(TypeName = "NVARCHAR")]
        [MaxLength(100)]
        public string? MoTa { get; set; }

        public int KhoaHocID { get; set; }
        public KhoaHoc KhoaHoc { get; set; }
    }
}
