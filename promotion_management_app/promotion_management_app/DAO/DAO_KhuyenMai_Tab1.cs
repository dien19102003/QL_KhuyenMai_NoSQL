using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using promotion_management_app.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static promotion_management_app.DTO.DTO_SanPham;

namespace promotion_management_app.DAO
{
    public class DAO_KhuyenMai_Tab1
    {
        private readonly IMongoCollection<KhuyenMai> _KhuyenMaiCollection;

        public DAO_KhuyenMai_Tab1()
        {
            var client = new MongoClient(ConnectDatabase.connectionString);
            var database = client.GetDatabase(ConnectDatabase.databaseName);
            _KhuyenMaiCollection = database.GetCollection<KhuyenMai>("KhuyenMai"); // Tên collection
        }

        internal IMongoCollection<KhuyenMai> GetCollectionKhuyenMai()
        {
            var client = new MongoClient(ConnectDatabase.connectionString);
            var database = client.GetDatabase(ConnectDatabase.databaseName);
            return database.GetCollection<KhuyenMai>("KhuyenMai");
        }

        // Lấy tất cả khuyến mãi
        public List<KhuyenMai> GetListKhuyenMai()
        {
            var collection = GetCollectionKhuyenMai(); // lấy collection từ MongoDB

            // Projection (only include the fields you need)
            var projection = Builders<KhuyenMai>.Projection
                .Include(x => x.MaKM)
                .Include(x => x.TenKM)
                .Include(x => x.MaLoaiKM)
                .Include(x => x.NgayBatDau)
                .Include(x => x.NgayKetThuc)
                .Include(x => (float)x.GiamGia)
                .Include(x => x.DieuKien.TongTienToiThieu)
                .Include(x => x.DieuKien.SoLuongToiThieu)
                .Include(x => x.DieuKien.SanPham)
                .Include(x => x.QuaTang)
                .Include(x => x.Voucher);
            var khuyenMaiList = collection.Find(Builders<KhuyenMai>.Filter.Empty)
                .Project<KhuyenMai>(projection)
                .ToList();
            TimeZoneInfo vietNamTimeZone = TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time");

            foreach (var km in khuyenMaiList)
            {              
                km.NgayBatDau = TimeZoneInfo.ConvertTimeFromUtc(km.NgayBatDau, vietNamTimeZone);
                km.NgayKetThuc = TimeZoneInfo.ConvertTimeFromUtc(km.NgayKetThuc, vietNamTimeZone);
                km.GiamGia = (float)Math.Round(km.GiamGia, 2);
            }

            return khuyenMaiList;
        }


        //Thêm khuyến mãi 
        public async Task<bool> AddKhuyenMai(KhuyenMai khuyenMai)
        {
            try
            {
                await _KhuyenMaiCollection.InsertOneAsync(khuyenMai);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while adding customer: {ex.Message}");
                return false;
            }
        }
        // Cập nhật khuyến mãi
        public async Task<bool> UpdateKhuyenMai(KhuyenMai khuyenMai)
        {
            try
            {
                var filter = Builders<KhuyenMai>.Filter.Eq(x => x.MaKM, khuyenMai.MaKM);             
                var update = Builders<KhuyenMai>.Update
                    .Set(x => x.TenKM, khuyenMai.TenKM)
                    .Set(x => x.MaLoaiKM, khuyenMai.MaLoaiKM)
                    .Set(x => x.NgayBatDau, khuyenMai.NgayBatDau)
                    .Set(x => x.NgayKetThuc, khuyenMai.NgayKetThuc)
                    .Set(x => x.GiamGia, khuyenMai.GiamGia)
                    .Set(x => x.DieuKien, khuyenMai.DieuKien)
                    .Set(x => x.QuaTang, khuyenMai.QuaTang) 
                    .Set(x => x.Voucher, khuyenMai.Voucher); 
            
                var result = await _KhuyenMaiCollection.UpdateOneAsync(filter, update);              
                return result.ModifiedCount > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while updating khuyen mai: {ex.Message}");
                return false;
            }
        }


        //Delete Km
        // Hàm xóa một khuyến mãi dựa trên MaKM
        public async Task<bool> DeleteKhuyenMai(string maKM)
        {
            try
            {
                var filter = Builders<KhuyenMai>.Filter.Eq(x => x.MaKM, maKM);
                var result = await _KhuyenMaiCollection.DeleteOneAsync(filter);
                return result.DeletedCount > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while deleting promotion: {ex.Message}");
                return false;
            }
        }
        //Tìm dựa trên mã voucher
        public KhuyenMai GetValidKhuyenMaiByGiftCode(string giftCode)
        {
            var filter = Builders<KhuyenMai>.Filter.Eq(x => x.Voucher.GiftCode, giftCode);
            var khuyenMai = _KhuyenMaiCollection.Find(filter).FirstOrDefault();

            if (khuyenMai != null)
            {
                // Lấy ngày hiện tại
                DateTime currentDate = DateTime.Now;

                // Kiểm tra điều kiện ngày hiện tại nằm trong khoảng từ Ngày bắt đầu đến Ngày kết thúc của Voucher
                if (khuyenMai.Voucher != null &&
                    currentDate >= khuyenMai.Voucher.NgayBatDau &&
                    currentDate <= khuyenMai.Voucher.NgayKetThuc)
                {
                    // Chuyển đổi múi giờ nếu cần
                    TimeZoneInfo vietNamTimeZone = TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time");
                    khuyenMai.NgayBatDau = TimeZoneInfo.ConvertTimeFromUtc(khuyenMai.NgayBatDau, vietNamTimeZone);
                    khuyenMai.NgayKetThuc = TimeZoneInfo.ConvertTimeFromUtc(khuyenMai.NgayKetThuc, vietNamTimeZone);
                    khuyenMai.GiamGia = (float)Math.Round(khuyenMai.GiamGia, 2);

                    return khuyenMai;
                }
            }

            // Nếu không tìm thấy hoặc điều kiện ngày không phù hợp, trả về null
            return null;
        }
    }
}
