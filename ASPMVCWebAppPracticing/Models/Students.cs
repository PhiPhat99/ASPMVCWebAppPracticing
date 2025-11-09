using System.ComponentModel.DataAnnotations;

namespace ASPMVCWebAppPracticing.Models
{
    public class Students
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Scores { get; set; }

    }
}
