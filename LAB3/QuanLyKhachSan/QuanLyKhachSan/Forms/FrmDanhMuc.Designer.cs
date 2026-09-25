namespace QuanLyKhachSan.Forms
{
    partial class FrmDanhMuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDanhMuc));
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Mã = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tên = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VaiTrò = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ĐơnVị = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ĐơnGíaMức = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            resources.ApplyResources(this.linkLabel1, "linkLabel1");
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.TabStop = true;
            // 
            // linkLabel2
            // 
            resources.ApplyResources(this.linkLabel2, "linkLabel2");
            this.linkLabel2.LinkColor = System.Drawing.Color.Black;
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.TabStop = true;
            // 
            // linkLabel3
            // 
            resources.ApplyResources(this.linkLabel3, "linkLabel3");
            this.linkLabel3.LinkColor = System.Drawing.Color.Black;
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.TabStop = true;
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabel4
            // 
            resources.ApplyResources(this.linkLabel4, "linkLabel4");
            this.linkLabel4.LinkColor = System.Drawing.Color.Black;
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.TabStop = true;
            // 
            // linkLabel5
            // 
            resources.ApplyResources(this.linkLabel5, "linkLabel5");
            this.linkLabel5.LinkColor = System.Drawing.Color.Black;
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.TabStop = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // button4
            // 
            resources.ApplyResources(this.button4, "button4");
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mã,
            this.Tên,
            this.VaiTrò,
            this.ĐơnVị,
            this.ĐơnGíaMức});
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            // 
            // Mã
            // 
            resources.ApplyResources(this.Mã, "Mã");
            this.Mã.Name = "Mã";
            // 
            // Tên
            // 
            resources.ApplyResources(this.Tên, "Tên");
            this.Tên.Name = "Tên";
            // 
            // VaiTrò
            // 
            resources.ApplyResources(this.VaiTrò, "VaiTrò");
            this.VaiTrò.Name = "VaiTrò";
            // 
            // ĐơnVị
            // 
            resources.ApplyResources(this.ĐơnVị, "ĐơnVị");
            this.ĐơnVị.Name = "ĐơnVị";
            // 
            // ĐơnGíaMức
            // 
            resources.ApplyResources(this.ĐơnGíaMức, "ĐơnGíaMức");
            this.ĐơnGíaMức.Name = "ĐơnGíaMức";
            // 
            // FrmDanhMuc
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel5);
            this.Controls.Add(this.linkLabel4);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Name = "FrmDanhMuc";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mã;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tên;
        private System.Windows.Forms.DataGridViewTextBoxColumn VaiTrò;
        private System.Windows.Forms.DataGridViewTextBoxColumn ĐơnVị;
        private System.Windows.Forms.DataGridViewTextBoxColumn ĐơnGíaMức;
    }
}