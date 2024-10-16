using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace promotion_management_app
{
    internal class ConnectDatabase
    {
        public static string connectionString = "mongodb://localhost:27017"; // Thay bằng địa chỉ và port của MongoDB Server
        public static string databaseName = "QL_ChuongTrinhKhuyenMai"; // Thay bằng tên database

        private IMongoDatabase db;

        public ConnectDatabase()
        {
            var client = new MongoClient(connectionString);
            db = client.GetDatabase(databaseName);
        }

        // Hàm lấy dữ liệu từ collection MongoDB
        public List<BsonDocument> GetPromotionData()
        {
            var collection = db.GetCollection<BsonDocument>("ChuongTrinhKhuyenMai");
            return collection.Find(new BsonDocument()).ToList();
        }
    }
}
