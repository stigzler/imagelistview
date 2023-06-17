
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
            this.StartupFolderTB = new System.Windows.Forms.TextBox();
            this.StartupFolderBT = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Startup Folder:";
            // 
            // StartupFolderTB
            // 
            this.StartupFolderTB.Location = new System.Drawing.Point(108, 23);
            this.StartupFolderTB.Name = "StartupFolderTB";
            this.StartupFolderTB.ReadOnly = true;
            this.StartupFolderTB.Size = new System.Drawing.Size(276, 20);
            this.StartupFolderTB.TabIndex = 3;
            // 
            // StartupFolderBT
            // 
            this.StartupFolderBT.Image = global::Manina.Windows.Forms.Properties.Resources.folder;
            this.StartupFolderBT.Location = new System.Drawing.Point(390, 21);
            this.StartupFolderBT.Name = "StartupFolderBT";
            this.StartupFolderBT.Size = new System.Drawing.Size(36, 23);
            this.StartupFolderBT.TabIndex = 4;
            this.StartupFolderBT.UseVisualStyleBackColor = true;
            this.StartupFolderBT.Click += new System.EventHandler(this.StartupFolderBT_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StartupFolderBT);
            this.Controls.Add(this.StartupFolderTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Settings";
            this.Text = "Settings";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button OkBT;
        private System.Windows.Forms.Button CancelBT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox StartupFolderTB;
        private System.Windows.Forms.Button StartupFolderBT;
    }
}