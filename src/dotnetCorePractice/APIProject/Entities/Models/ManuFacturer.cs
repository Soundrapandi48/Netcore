using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIProject.Entities.Models
{
    [Table("ManuFacturer")]
    public class ManuFacturer
    {
        [DefaultValue("NEWID()")]
        public Guid GuidId { get; set; }
        [Key]
        [Required]
        [StringLength(10)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [MaxLength(10,ErrorMessage ="Manufacturer name cannot exceed 10 characters")]
        public string Name { get; set; }
        public string Description { get; set; }
        public string upduser   { get; set; }
        [DefaultValue(typeof(DateTime),"")]
        public DateTime updtime { get; set; }
    }
}
