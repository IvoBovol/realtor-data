using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
///Hussein Abed Work

namespace BlazorServerCRUD.Data
{
    public class Request
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
    }
}
