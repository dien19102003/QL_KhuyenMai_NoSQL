using MongoDB.Bson.Serialization.Attributes;
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
        public virtual List<SanPham> SanPham { get; set; } = new List<SanPham>();
        [BsonIgnoreIfNull]
        public int?  SoLuongToiThieu { get; set; }
        [BsonIgnoreIfNull]

        //Dành cho hoá đơn
        public decimal?  TongTienToiThieu { get; set; }
    }
}
