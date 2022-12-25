using System.ComponentModel.DataAnnotations;

namespace EmailManagement.Models
{
    // Presents Group on front end
    public class GroupModel
    {
        public int Id { get; set; }
        [StringLength(50, ErrorMessage =" I will not allow more than 50 chars")]
        public string Title { get; set; } = string.Empty;
        [StringLength(150)]
        public string Description { get; set; } = string.Empty;
    }
}