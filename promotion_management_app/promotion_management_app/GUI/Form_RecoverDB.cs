using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace promotion_management_app.GUI
{
    public partial class Form_RecoverDB : Form
    {
        private ConnectDatabase dbConnection;
        public Form_RecoverDB()
        {
            InitializeComponent();
            dbConnection = new ConnectDatabase();
            LoadCollections();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoadCollections()
        {
            comboBoxCollections.Items.Clear();
            comboBoxCollections.Items.Add("Toàn bộ cơ sở dữ liệu");
            comboBoxCollections.Items.AddRange(dbConnection.GetCollectionNames().ToArray());
            comboBoxCollections.SelectedIndex = 0;
        }

        private void btnSaoLuu_Click(object sender, EventArgs e)
        {
            if (comboBoxCollections.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn đối tượng cần sao lưu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "JSON files (*.json)|*.json";
                saveFileDialog.Title = "Chọn nơi lưu file sao lưu";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedOption = comboBoxCollections.SelectedItem.ToString();
                    if (selectedOption == "Toàn bộ cơ sở dữ liệu")
                    {
                        dbConnection.BackupFullDatabase(saveFileDialog.FileName);
                    }
                    else
                    {
                        dbConnection.BackupCollection(saveFileDialog.FileName, selectedOption);
                    }
                }
            }
        }

        private void btnPhucHoi_Click(object sender, EventArgs e)
        {
            if (comboBoxCollections.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn đối tượng cần phục hồi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "JSON files (*.json)|*.json";
                openFileDialog.Title = "Chọn file sao lưu để phục hồi";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedOption = comboBoxCollections.SelectedItem.ToString();
                    if (selectedOption == "Toàn bộ cơ sở dữ liệu")
                    {
                        if (MessageBox.Show("Bạn có chắc chắn muốn phục hồi toàn bộ cơ sở dữ liệu? Hành động này sẽ ghi đè lên tất cả dữ liệu hiện tại.", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            dbConnection.RestoreFullDatabase(openFileDialog.FileName);
                        }
                    }
                    else
                    {
                        if (MessageBox.Show($"Bạn có chắc chắn muốn phục hồi collection {selectedOption}? Hành động này sẽ ghi đè lên dữ liệu hiện tại của collection.", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            dbConnection.RestoreCollection(openFileDialog.FileName, selectedOption);
                        }
                    }
                }
            }
        }
    }
}
