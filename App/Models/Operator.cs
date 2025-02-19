using System.ComponentModel.DataAnnotations;

namespace MacroApp.Models
{
    public class Operator
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Function { get; set; }
        public int XValue { get; set; }
        public int YValue { get; set; }
        public int ThreadValue { get; set; }

    }
}
