using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASPMVCWebAppPracticing.Models
{
    public class Students
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("ชื่อนักศึกษา")]
        public string Name { get; set; }
        [DisplayName("คะแนนทั้งหมด")]
        [Range(0, 100)] 
        public int Score { get; set; }

    }
}
