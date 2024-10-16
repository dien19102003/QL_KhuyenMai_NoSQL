using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
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
        public List<string> GetCollectionNames()
        {
            return db.ListCollectionNames().ToList();
        }

        public void BackupFullDatabase(string backupPath)
        {
            try
            {
                var collections = db.ListCollectionNames().ToList();
                var backupData = new Dictionary<string, List<BsonDocument>>();

                foreach (var collectionName in collections)
                {
                    var collection = db.GetCollection<BsonDocument>(collectionName);
                    var documents = collection.Find(new BsonDocument()).ToList();
                    backupData[collectionName] = documents;
                }

                File.WriteAllText(backupPath, backupData.ToJson());
                MessageBox.Show("Sao lưu toàn bộ cơ sở dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi sao lưu dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void BackupCollection(string backupPath, string collectionName)
        {
            try
            {
                var collection = db.GetCollection<BsonDocument>(collectionName);
                var documents = collection.Find(new BsonDocument()).ToList();
                var backupData = new Dictionary<string, List<BsonDocument>>
            {
                { collectionName, documents }
            };

                File.WriteAllText(backupPath, backupData.ToJson());
                MessageBox.Show($"Sao lưu collection {collectionName} thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi sao lưu dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RestoreFullDatabase(string backupPath)
        {
            try
            {
                var backupJson = File.ReadAllText(backupPath);
                var backupData = BsonSerializer.Deserialize<Dictionary<string, List<BsonDocument>>>(backupJson);

                foreach (var collectionName in backupData.Keys)
                {
                    var collection = db.GetCollection<BsonDocument>(collectionName);
                    var documents = backupData[collectionName];

                    collection.DeleteMany(new BsonDocument());
                    if (documents.Any())
                    {
                        collection.InsertMany(documents);
                    }
                }

                MessageBox.Show("Phục hồi toàn bộ cơ sở dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi phục hồi dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RestoreCollection(string backupPath, string collectionName)
        {
            try
            {
                var backupJson = File.ReadAllText(backupPath);
                var backupData = BsonSerializer.Deserialize<Dictionary<string, List<BsonDocument>>>(backupJson);

                if (!backupData.ContainsKey(collectionName))
                {
                    throw new Exception($"Không tìm thấy dữ liệu sao lưu cho collection {collectionName}");
                }

                var collection = db.GetCollection<BsonDocument>(collectionName);
                var documents = backupData[collectionName];

                collection.DeleteMany(new BsonDocument());
                if (documents.Any())
                {
                    collection.InsertMany(documents);
                }

                MessageBox.Show($"Phục hồi collection {collectionName} thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi phục hồi dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
