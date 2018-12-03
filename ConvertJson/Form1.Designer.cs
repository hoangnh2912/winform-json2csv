namespace ConvertJson
{
    partial class Form1
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
            this.path = new System.Windows.Forms.TextBox();
            this.btn_path = new System.Windows.Forms.Button();
            this.tb = new System.Windows.Forms.TextBox();
            this.btn_open = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // path
            // 
            this.path.Enabled = false;
            this.path.Location = new System.Drawing.Point(195, 12);
            this.path.Multiline = true;
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(301, 37);
            this.path.TabIndex = 0;
            // 
            // btn_path
            // 
            this.btn_path.Location = new System.Drawing.Point(529, 12);
            this.btn_path.Name = "btn_path";
            this.btn_path.Size = new System.Drawing.Size(109, 29);
            this.btn_path.TabIndex = 1;
            this.btn_path.Text = "Chọn file json";
            this.btn_path.UseVisualStyleBackColor = true;
            this.btn_path.Click += new System.EventHandler(this.btn_path_Click);
            // 
            // tb
            // 
            this.tb.Enabled = false;
            this.tb.Location = new System.Drawing.Point(195, 67);
            this.tb.Multiline = true;
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(301, 37);
            this.tb.TabIndex = 2;
            // 
            // btn_open
            // 
            this.btn_open.Enabled = false;
            this.btn_open.Location = new System.Drawing.Point(529, 67);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(109, 29);
            this.btn_open.TabIndex = 1;
            this.btn_open.Text = "Mở";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_copy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Đường dẫn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "File đã xử lý";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 132);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.btn_path);
            this.Controls.Add(this.path);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xử lý json";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox path;
        private System.Windows.Forms.Button btn_path;
        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

