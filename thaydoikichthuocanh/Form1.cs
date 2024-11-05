namespace thaydoikichthuocanh
{
    public partial class Form1 : Form
    {
        private string inputFolder;    // Folder chứa ảnh đầu vào
        private string outputFolder;   // Folder chứa ảnh đầu ra sau chuyển đổi
        private int newWidth;          // Kích thước X đầu ra
        private int newHeight;         // Kích thước Y đầu ra

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_chonfolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    inputFolder = folderDialog.SelectedPath;
                    txt_linkfolderchon.Text = inputFolder;  // Hiển thị đường dẫn trong text box
                }
            }
        }

        private void btn_xuatfolderdachay_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    outputFolder = folderDialog.SelectedPath;
                    txt_linkfolderxuat.Text = outputFolder;  // Hiển thị đường dẫn trong text box
                }
            }
        }

        private void btn_kichthuoc1_Click(object sender, EventArgs e)
        {

        }

        private void btn_kichthuoc2_Click(object sender, EventArgs e)
        {

        }

        private void txt_linkfolderchon_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_linkfolderxuat_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_kthuoc1_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txt_kthuoc1.Text, out int width))
            {
                newWidth = width;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số nguyên hợp lệ cho kích thước X!");
            }
        }

        private void btn_tienhanh_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(inputFolder) || string.IsNullOrEmpty(outputFolder))
            {
                MessageBox.Show("Vui lòng chọn thư mục đầu vào và đầu ra!");
                return;
            }

            if (newWidth <= 0 || newHeight <= 0)
            {
                MessageBox.Show("Vui lòng nhập kích thước hợp lệ cho ảnh đầu ra!");
                return;
            }

            try
            {
                foreach (string filePath in Directory.GetFiles(inputFolder))
                {
                    // Chỉ xử lý các tệp ảnh
                    if (Path.GetExtension(filePath).ToLower() == ".jpg" ||
                        Path.GetExtension(filePath).ToLower() == ".jpeg" ||
                        Path.GetExtension(filePath).ToLower() == ".png" ||
                        Path.GetExtension(filePath).ToLower() == ".bmp")
                    {
                        using (Image img = Image.FromFile(filePath))
                        {
                            // Chuyển đổi kích thước ảnh
                            using (Bitmap resizedImage = new Bitmap(img, new Size(newWidth, newHeight)))
                            {
                                string outputFilePath = Path.Combine(outputFolder, Path.GetFileNameWithoutExtension(filePath) + "_converted.jpg");
                                resizedImage.Save(outputFilePath, System.Drawing.Imaging.ImageFormat.Jpeg);
                            }
                        }
                    }
                }

                MessageBox.Show("Chuyển đổi ảnh thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }
    


        private void txt_kichthuoc2_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txt_kichthuoc2.Text, out int height))
            {
                newHeight = height;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số nguyên hợp lệ cho kích thước Y!");
            }
        }
    }
}

