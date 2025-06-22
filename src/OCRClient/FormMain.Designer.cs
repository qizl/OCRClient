namespace OCRClient
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pageHeader1 = new AntdUI.PageHeader();
            uploadDragger1 = new AntdUI.UploadDragger();
            txtOutput = new AntdUI.Input();
            SuspendLayout();
            // 
            // pageHeader1
            // 
            pageHeader1.Dock = DockStyle.Top;
            pageHeader1.Location = new Point(0, 0);
            pageHeader1.Name = "pageHeader1";
            pageHeader1.ShowButton = true;
            pageHeader1.Size = new Size(900, 40);
            pageHeader1.TabIndex = 0;
            pageHeader1.Text = "OCR Client";
            // 
            // uploadDragger1
            // 
            uploadDragger1.Dock = DockStyle.Top;
            uploadDragger1.Location = new Point(0, 40);
            uploadDragger1.Name = "uploadDragger1";
            uploadDragger1.Size = new Size(900, 161);
            uploadDragger1.TabIndex = 1;
            uploadDragger1.Text = "点击或拖拽上传图片文件";
            uploadDragger1.DragChanged += uploadDragger1_DragChanged;
            // 
            // txtOutput
            // 
            txtOutput.Dock = DockStyle.Fill;
            txtOutput.Location = new Point(0, 201);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.Size = new Size(900, 399);
            txtOutput.TabIndex = 2;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 600);
            Controls.Add(txtOutput);
            Controls.Add(uploadDragger1);
            Controls.Add(pageHeader1);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.PageHeader pageHeader1;
        private AntdUI.UploadDragger uploadDragger1;
        private AntdUI.Input txtOutput;
    }
}
