using MongoDB.Driver;
using promotion_management_app.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
