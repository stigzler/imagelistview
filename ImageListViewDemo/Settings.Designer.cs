
namespace Manina.Windows.Forms
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.OkBT = new System.Windows.Forms.Button();
            this.CancelBT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.OverlayImageWNUM = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.OverlayImageHNUM = new System.Windows.Forms.NumericUpDown();
            this.OverlayImgSizePN = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OverlayImageWNUM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OverlayImageHNUM)).BeginInit();
            this.OverlayImgSizePN.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.OkBT);
            this.flowLayoutPanel1.Controls.Add(this.CancelBT);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 399);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 29);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // OkBT
            // 
            this.OkBT.Location = new System.Drawing.Point(722, 3);
            this.OkBT.Name = "OkBT";
            this.OkBT.Size = new System.Drawing.Size(75, 23);
            this.OkBT.TabIndex = 0;
            this.OkBT.Text = "OK";
            this.OkBT.UseVisualStyleBackColor = true;
            this.OkBT.Click += new System.EventHandler(this.OkBT_Click);
            // 
            // CancelBT
            // 
            this.CancelBT.Location = new System.Drawing.Point(641, 3);
            this.CancelBT.Name = "CancelBT";
            this.CancelBT.Size = new System.Drawing.Size(75, 23);
            this.CancelBT.TabIndex = 1;
            this.CancelBT.Text = "Cancel";
            this.CancelBT.UseVisualStyleBackColor = true;
            this.CancelBT.Click += new System.EventHandler(this.CancelBT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Overlay Image Dimentions (WxH in px):";
            // 
            // OverlayImageWNUM
            // 
            this.OverlayImageWNUM.Location = new System.Drawing.Point(200, 6);
            this.OverlayImageWNUM.Name = "OverlayImageWNUM";
            this.OverlayImageWNUM.Size = new System.Drawing.Size(60, 20);
            this.OverlayImageWNUM.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "X";
            // 
            // OverlayImageHNUM
            // 
            this.OverlayImageHNUM.Location = new System.Drawing.Point(286, 6);
            this.OverlayImageHNUM.Name = "OverlayImageHNUM";
            this.OverlayImageHNUM.Size = new System.Drawing.Size(60, 20);
            this.OverlayImageHNUM.TabIndex = 5;
            // 
            // OverlayImgSizePN
            // 
            this.OverlayImgSizePN.AutoSize = true;
            this.OverlayImgSizePN.Controls.Add(this.label1);
            this.OverlayImgSizePN.Controls.Add(this.OverlayImageHNUM);
            this.OverlayImgSizePN.Controls.Add(this.OverlayImageWNUM);
            this.OverlayImgSizePN.Controls.Add(this.label2);
            this.OverlayImgSizePN.Location = new System.Drawing.Point(87, 106);
            this.OverlayImgSizePN.Name = "OverlayImgSizePN";
            this.OverlayImgSizePN.Size = new System.Drawing.Size(352, 33);
            this.OverlayImgSizePN.TabIndex = 6;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OverlayImgSizePN);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OverlayImageWNUM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OverlayImageHNUM)).EndInit();
            this.OverlayImgSizePN.ResumeLayout(false);
            this.OverlayImgSizePN.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button OkBT;
        private System.Windows.Forms.Button CancelBT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown OverlayImageWNUM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown OverlayImageHNUM;
        private System.Windows.Forms.Panel OverlayImgSizePN;
    }
}