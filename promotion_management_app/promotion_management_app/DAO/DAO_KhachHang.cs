using MongoDB.Bson;
using MongoDB.Driver;
using promotion_management_app.DTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace promotion_management_app.DAO
{
    internal class DAO_KhachHang
    {
        private readonly IMongoCollection<DTO_KhachHang.KhachHang> _khachHangCollection;

        public DAO_KhachHang()
        {
            var client = new MongoClient(ConnectDatabase.connectionString);
            var database = client.GetDatabase(ConnectDatabase.databaseName);
            _khachHangCollection = database.GetCollection<DTO_KhachHang.KhachHang>("KhachHang"); // Tên collection
        }

        // Thêm khách hàng mới
        public async Task<bool> AddKhachHang(DTO_KhachHang.KhachHang khachHang)
        {
            try
            {
                await _khachHangCollection.InsertOneAsync(khachHang);
                return true;
            }
            catch (Exception ex)
            {             
                Console.WriteLine($"Error while adding customer: {ex.Message}");
                return false;
            }
        }

        // Sửa thông tin khách hàng
        public async Task<bool> UpdateKhachHang(DTO_KhachHang.KhachHang khachHang)
        {
            var filter = Builders<DTO_KhachHang.KhachHang>.Filter.Eq("_id", khachHang._id);
            var result = await _khachHangCollection.ReplaceOneAsync(filter, khachHang);
            return result.IsAcknowledged && result.ModifiedCount > 0;
        }

        // Xóa khách hàng
        public async Task<bool> DeleteKhachHang(ObjectId id)
        {
            var filter = Builders<DTO_KhachHang.KhachHang>.Filter.Eq("_id", id);
            var result = await _khachHangCollection.DeleteOneAsync(filter);
            return result.IsAcknowledged && result.DeletedCount > 0;
        }

        // Tìm khách hàng theo SDT
        public async Task<DTO_KhachHang.KhachHang> FindKhachHangBySDT(string sdt)
        {
            var filter = Builders<DTO_KhachHang.KhachHang>.Filter.Eq("SDT", sdt);
            return await _khachHangCollection.Find(filter).FirstOrDefaultAsync();
        }

        // Lấy danh sách tất cả khách hàng
        public async Task<List<DTO_KhachHang.KhachHang>> GetAllKhachHang()
        {
            return await _khachHangCollection.Find(new BsonDocument()).ToListAsync();
        }
    }
}
