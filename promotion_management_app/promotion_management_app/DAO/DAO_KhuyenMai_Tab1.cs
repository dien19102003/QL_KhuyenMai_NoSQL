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
        internal List<KhuyenMai> GetListKhuyenMai()
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

    }
}
