namespace SMP.PL
{
    partial class FRM_CAT_ADD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_CAT_ADD));
            this.edt_name = new System.Windows.Forms.TextBox();
            this.lb_titlepage = new System.Windows.Forms.Label();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.pic_cover = new DevExpress.XtraEditors.PictureEdit();
            this.btn_close = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cover.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // edt_name
            // 
            this.edt_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.edt_name.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_name.Location = new System.Drawing.Point(119, 65);
            this.edt_name.Name = "edt_name";
            this.edt_name.Size = new System.Drawing.Size(257, 40);
            this.edt_name.TabIndex = 8;
            this.edt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_titlepage
            // 
            this.lb_titlepage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_titlepage.AutoSize = true;
            this.lb_titlepage.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titlepage.ForeColor = System.Drawing.Color.DimGray;
            this.lb_titlepage.Location = new System.Drawing.Point(184, 22);
            this.lb_titlepage.Name = "lb_titlepage";
            this.lb_titlepage.Size = new System.Drawing.Size(124, 31);
            this.lb_titlepage.TabIndex = 7;
            this.lb_titlepage.Text = "اسم الصنف";
            this.lb_titlepage.Click += new System.EventHandler(this.lb_titlepage_Click);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_add.Appearance.Font = new System.Drawing.Font("Yu Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Appearance.Options.UseFont = true;
            this.btn_add.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.btn_add.Location = new System.Drawing.Point(384, 341);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(129, 70);
            this.btn_add.TabIndex = 10;
            this.btn_add.Text = "إضافة ";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // pic_cover
            // 
            this.pic_cover.EditValue = ((object)(resources.GetObject("pic_cover.EditValue")));
            this.pic_cover.Location = new System.Drawing.Point(119, 123);
            this.pic_cover.Name = "pic_cover";
            this.pic_cover.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pic_cover.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pic_cover.Size = new System.Drawing.Size(257, 213);
            this.pic_cover.TabIndex = 9;
            // 
            // btn_close
            // 
            this.btn_close.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.ImageOptions.Image")));
            this.btn_close.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_close.Location = new System.Drawing.Point(474, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_close.Size = new System.Drawing.Size(50, 50);
            this.btn_close.TabIndex = 6;
            // 
            // FRM_CAT_ADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(525, 413);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.pic_cover);
            this.Controls.Add(this.edt_name);
            this.Controls.Add(this.lb_titlepage);
            this.Controls.Add(this.btn_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_CAT_ADD";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pic_cover.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_close;
        private System.Windows.Forms.TextBox edt_name;
        private DevExpress.XtraEditors.PictureEdit pic_cover;
        private System.Windows.Forms.Label lb_titlepage;
        public DevExpress.XtraEditors.SimpleButton btn_add;
    }
}