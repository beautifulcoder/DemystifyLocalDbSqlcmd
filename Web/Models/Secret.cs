using System.ComponentModel.DataAnnotations;

namespace DemystifyLocalDbSqlcmd.Models
{
    public class Secret
    {
        public int Id { get; set; }
        [StringLength(16, ErrorMessage = "Max 16")]
        public string Message { get; set; }
    }
}
