namespace PDFtoImage
{
    partial class PDFtoImage
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
            OFD = new OpenFileDialog();
            SFD = new SaveFileDialog();
            btnOpen = new Button();
            btnSFD = new Button();
            txtOFN = new TextBox();
            txtSFN = new TextBox();
            btnConvert = new Button();
            SuspendLayout();
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(12, 12);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(122, 34);
            btnOpen.TabIndex = 0;
            btnOpen.Text = "&Open PDF...";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += BtnOpen_Click;
            // 
            // btnSFD
            // 
            btnSFD.Location = new Point(12, 52);
            btnSFD.Name = "btnSFD";
            btnSFD.Size = new Size(122, 34);
            btnSFD.TabIndex = 1;
            btnSFD.Text = "&Save As...";
            btnSFD.UseVisualStyleBackColor = true;
            btnSFD.Click += BtnSFD_Click;
            // 
            // txtOFN
            // 
            txtOFN.Location = new Point(140, 12);
            txtOFN.Name = "txtOFN";
            txtOFN.ReadOnly = true;
            txtOFN.Size = new Size(1102, 31);
            txtOFN.TabIndex = 2;
            // 
            // txtSFN
            // 
            txtSFN.Location = new Point(140, 52);
            txtSFN.Name = "txtSFN";
            txtSFN.ReadOnly = true;
            txtSFN.Size = new Size(1102, 31);
            txtSFN.TabIndex = 3;
            // 
            // btnConvert
            // 
            btnConvert.DialogResult = DialogResult.OK;
            btnConvert.Location = new Point(1120, 89);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(122, 34);
            btnConvert.TabIndex = 4;
            btnConvert.Text = "Convert";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += BtnConvert_Click;
            // 
            // PDFtoImage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1254, 131);
            Controls.Add(btnConvert);
            Controls.Add(txtSFN);
            Controls.Add(txtOFN);
            Controls.Add(btnSFD);
            Controls.Add(btnOpen);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PDFtoImage";
            Text = "PDF to Image Converter";
            Load += PDFtoImage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog OFD;
        private SaveFileDialog SFD;
        private Button btnOpen;
        private Button btnSFD;
        private TextBox txtOFN;
        private TextBox txtSFN;
        private Button btnConvert;
    }
}
