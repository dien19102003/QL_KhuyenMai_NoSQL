using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace promotion_management_app.DTO
{
    public class Voucher
    {
        public string GiftCode {  get; set; }
        public float GiamGia {  get; set; }
        public DateTime NgayBatDau {  get; set; }
        public DateTime NgayKetThuc { get; set; }
    }
}
