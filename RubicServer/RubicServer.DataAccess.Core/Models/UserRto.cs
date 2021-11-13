using System.ComponentModel.DataAnnotations.Schema;

namespace RubicServer.DataAccess.Core.Models
{   
    [Table("User")]
    public class UserRto
    {
        [key] public int id { get; set; }
    }
}
