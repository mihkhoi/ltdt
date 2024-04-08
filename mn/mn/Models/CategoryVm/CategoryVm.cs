using Microsoft.AspNetCore.Mvc.Rendering;
using mn.Models;

namespace mn.ViewModels // Thay đổi namespace thành QLBH.ViewModels
{
    public class CategoryVM
    {
        public Category Category { get; set; }
        public IEnumerable<SelectListItem> DanhsachList { get; set; }
    }
}