using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASPMVCWebAppPracticing.Models
{
    public class Students
    {
        [Key]
        [Required(ErrorMessage = "กรุณาป้อนรหัสนักศึกษา")]
        [DisplayName("รหัสนักศึกษา")]
        public string StudentId { get; set; }

        [Required(ErrorMessage = "กรุณาป้อนชื่อ - สกุลของนักศึกษาให้ครบ")]
        [DisplayName("ชื่อนักศึกษา")]
        public string Name { get; set; }

        [Required(ErrorMessage = "กรุณาป้อนค่าคะแนนสอบ")]
        [DisplayName("คะแนนทั้งหมด")]
        [Range(0, 100, ErrorMessage = "กรุณาป้อนค่าคะแนนสอบในช่วง 0-100")]
        public int? Score { get; set; }

        [DisplayName("ผลการเรียน")]
        public string? Grade { get; set; }
    }
}
