using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static promotion_management_app.DTO.DTO_SanPham;

namespace promotion_management_app.DTO
{
    public class DieuKien
    {
        //Dành cho sản phẩm
        public virtual ICollection<SanPham> SanPhams { get; set; } = null;
        public int  SoLuongToiThieu { get; set; }

        //Dành cho hoá đơn
        public decimal  TongTienToiThieu { get; set; }
    }
}
