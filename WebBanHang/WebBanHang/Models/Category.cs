using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebBanHang.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        [Required, StringLength(50)]
        [DisplayName("Tên loại")]
        public string Name { get; set; }
        
    }
}
