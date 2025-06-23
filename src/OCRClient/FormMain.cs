using OpenCvSharp;
using Sdcb.OpenVINO.PaddleOCR;
using Sdcb.OpenVINO.PaddleOCR.Models;
using Sdcb.OpenVINO.PaddleOCR.Models.Online;

namespace OCRClient
{
    public partial class FormMain : AntdUI.Window
    {
        public FormMain()
        {
            InitializeComponent();

            this.uploadDragger1.Multiselect = false;
            this.uploadDragger1.Filter = "图片文件|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            //if (Keys.Escape == keyData)
            //{
            //    this.Close();
            //}

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void uploadDragger1_DragChanged(object sender, AntdUI.StringsEventArgs e)
        {
            var filePath = e.Value.FirstOrDefault();
            this.output($"选择图片：{Path.GetFileName(filePath)}");

            Task.Run(() => this.recognizeText(filePath));
        }

        private void output(string text)
        {
            this.Invoke(() =>
            {
                this.txtOutput.AppendText($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} {text}{Environment.NewLine}");
                this.txtOutput.ScrollToEnd();
            });
        }

        private void recognizeText(string imageFilePath)
        {
            this.output($"正在识别文字...");

            FullOcrModel model = OnlineFullModels.ChineseV4.DownloadAsync().Result;

            using Mat src = Cv2.ImRead(imageFilePath);
            using PaddleOcrAll all = new(model)
            {
                AllowRotateDetection = true,
                Enable180Classification = true,
            };

            PaddleOcrResult result = all.Run(src);
            this.output($"识别结果：{Environment.NewLine}{result.Text}");
        }
    }
}
