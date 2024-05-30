
namespace GUI
{
    partial class LapPhieuRut
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
            this.ktxt_tienrut = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Kgrb_in = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.lbl_sodu = new System.Windows.Forms.Label();
            this.Kbtn_signin = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lbl_moso = new System.Windows.Forms.Label();
            this.ktxt_ngayrut = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ktxt_ten = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ktxt_mstk = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Kbtn_checkin = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.Kgrb_in)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kgrb_in.Panel)).BeginInit();
            this.Kgrb_in.Panel.SuspendLayout();
            this.Kgrb_in.SuspendLayout();
            this.SuspendLayout();
            // 
            // ktxt_tienrut
            // 
            this.ktxt_tienrut.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ktxt_tienrut.Location = new System.Drawing.Point(183, 212);
            this.ktxt_tienrut.Name = "ktxt_tienrut";
            this.ktxt_tienrut.Size = new System.Drawing.Size(463, 29);
            this.ktxt_tienrut.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.ktxt_tienrut.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.ktxt_tienrut.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.ktxt_tienrut.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ktxt_tienrut.StateCommon.Border.Rounding = 10;
            this.ktxt_tienrut.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.ktxt_tienrut.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktxt_tienrut.TabIndex = 5;
            this.ktxt_tienrut.Text = "Số tiền rút";
            this.ktxt_tienrut.Enter += new System.EventHandler(this.ktxt_tienrut_Enter);
            this.ktxt_tienrut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ktxt_tienrut_KeyPress);
            this.ktxt_tienrut.Leave += new System.EventHandler(this.ktxt_tienrut_Leave);
            // 
            // Kgrb_in
            // 
            this.Kgrb_in.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Kgrb_in.CaptionOverlap = 0.8D;
            this.Kgrb_in.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.Kgrb_in.Location = new System.Drawing.Point(4, -5);
            this.Kgrb_in.Name = "Kgrb_in";
            // 
            // Kgrb_in.Panel
            // 
            this.Kgrb_in.Panel.Controls.Add(this.lbl_sodu);
            this.Kgrb_in.Panel.Controls.Add(this.Kbtn_signin);
            this.Kgrb_in.Panel.Controls.Add(this.lbl_moso);
            this.Kgrb_in.Panel.Controls.Add(this.ktxt_ngayrut);
            this.Kgrb_in.Panel.Controls.Add(this.ktxt_tienrut);
            this.Kgrb_in.Panel.Controls.Add(this.ktxt_ten);
            this.Kgrb_in.Panel.Controls.Add(this.ktxt_mstk);
            this.Kgrb_in.Panel.Controls.Add(this.Kbtn_checkin);
            this.Kgrb_in.Size = new System.Drawing.Size(867, 467);
            this.Kgrb_in.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.Kgrb_in.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.Kgrb_in.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.Kgrb_in.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.Kgrb_in.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Kgrb_in.StateCommon.Border.Rounding = 10;
            this.Kgrb_in.StateCommon.Border.Width = 3;
            this.Kgrb_in.TabIndex = 19;
            this.Kgrb_in.Values.Heading = "Lập phiếu rút";
            // 
            // lbl_sodu
            // 
            this.lbl_sodu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_sodu.AutoSize = true;
            this.lbl_sodu.BackColor = System.Drawing.Color.Transparent;
            this.lbl_sodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sodu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.lbl_sodu.Location = new System.Drawing.Point(652, 213);
            this.lbl_sodu.Name = "lbl_sodu";
            this.lbl_sodu.Size = new System.Drawing.Size(74, 26);
            this.lbl_sodu.TabIndex = 19;
            this.lbl_sodu.Text = "Số dư";
            // 
            // Kbtn_signin
            // 
            this.Kbtn_signin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Kbtn_signin.Location = new System.Drawing.Point(807, 3);
            this.Kbtn_signin.Name = "Kbtn_signin";
            this.Kbtn_signin.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.Kbtn_signin.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.Kbtn_signin.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.Kbtn_signin.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.Kbtn_signin.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Kbtn_signin.OverrideDefault.Content.Padding = new System.Windows.Forms.Padding(5, 3, -1, -1);
            this.Kbtn_signin.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.Kbtn_signin.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.Kbtn_signin.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kbtn_signin.Size = new System.Drawing.Size(45, 44);
            this.Kbtn_signin.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.Kbtn_signin.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.Kbtn_signin.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.Kbtn_signin.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.Kbtn_signin.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Kbtn_signin.StateCommon.Border.Rounding = 8;
            this.Kbtn_signin.StateCommon.Border.Width = 2;
            this.Kbtn_signin.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5, 3, -1, -1);
            this.Kbtn_signin.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.Kbtn_signin.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.Kbtn_signin.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kbtn_signin.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.Kbtn_signin.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.Kbtn_signin.StateTracking.Border.Color1 = System.Drawing.Color.White;
            this.Kbtn_signin.StateTracking.Border.Color2 = System.Drawing.Color.White;
            this.Kbtn_signin.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Kbtn_signin.StateTracking.Border.Rounding = 8;
            this.Kbtn_signin.StateTracking.Border.Width = 2;
            this.Kbtn_signin.StateTracking.Content.Padding = new System.Windows.Forms.Padding(5, 3, -1, -1);
            this.Kbtn_signin.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.Kbtn_signin.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.Kbtn_signin.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kbtn_signin.TabIndex = 18;
            this.Kbtn_signin.Values.Text = "X";
            this.Kbtn_signin.Click += new System.EventHandler(this.Kbtn_signin_Click);
            // 
            // lbl_moso
            // 
            this.lbl_moso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_moso.AutoSize = true;
            this.lbl_moso.BackColor = System.Drawing.Color.Transparent;
            this.lbl_moso.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_moso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.lbl_moso.Location = new System.Drawing.Point(255, 31);
            this.lbl_moso.Name = "lbl_moso";
            this.lbl_moso.Size = new System.Drawing.Size(342, 55);
            this.lbl_moso.TabIndex = 1;
            this.lbl_moso.Text = "Lập Phiếu Rút";
            // 
            // ktxt_ngayrut
            // 
            this.ktxt_ngayrut.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ktxt_ngayrut.Location = new System.Drawing.Point(486, 113);
            this.ktxt_ngayrut.Name = "ktxt_ngayrut";
            this.ktxt_ngayrut.Size = new System.Drawing.Size(160, 29);
            this.ktxt_ngayrut.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.ktxt_ngayrut.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.ktxt_ngayrut.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.ktxt_ngayrut.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ktxt_ngayrut.StateCommon.Border.Rounding = 10;
            this.ktxt_ngayrut.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.ktxt_ngayrut.TabIndex = 3;
            this.ktxt_ngayrut.Text = "Ngày rút";
            // 
            // ktxt_ten
            // 
            this.ktxt_ten.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ktxt_ten.Location = new System.Drawing.Point(183, 162);
            this.ktxt_ten.Name = "ktxt_ten";
            this.ktxt_ten.ReadOnly = true;
            this.ktxt_ten.Size = new System.Drawing.Size(463, 29);
            this.ktxt_ten.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.ktxt_ten.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.ktxt_ten.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.ktxt_ten.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ktxt_ten.StateCommon.Border.Rounding = 10;
            this.ktxt_ten.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.ktxt_ten.TabIndex = 4;
            this.ktxt_ten.Text = "Tên khách hàng";
            // 
            // ktxt_mstk
            // 
            this.ktxt_mstk.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ktxt_mstk.Location = new System.Drawing.Point(183, 113);
            this.ktxt_mstk.Name = "ktxt_mstk";
            this.ktxt_mstk.Size = new System.Drawing.Size(281, 29);
            this.ktxt_mstk.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.ktxt_mstk.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.ktxt_mstk.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.ktxt_mstk.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ktxt_mstk.StateCommon.Border.Rounding = 10;
            this.ktxt_mstk.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.ktxt_mstk.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktxt_mstk.TabIndex = 2;
            this.ktxt_mstk.Text = "Mã sổ tiết kiệm";
            this.ktxt_mstk.Enter += new System.EventHandler(this.ktxt_mstk_Enter);
            this.ktxt_mstk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ktxt_mstk_KeyPress);
            this.ktxt_mstk.Leave += new System.EventHandler(this.ktxt_mstk_Leave);
            // 
            // Kbtn_checkin
            // 
            this.Kbtn_checkin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Kbtn_checkin.Location = new System.Drawing.Point(369, 269);
            this.Kbtn_checkin.Name = "Kbtn_checkin";
            this.Kbtn_checkin.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.Kbtn_checkin.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.Kbtn_checkin.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.Kbtn_checkin.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.Kbtn_checkin.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Kbtn_checkin.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.Kbtn_checkin.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.Kbtn_checkin.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kbtn_checkin.Size = new System.Drawing.Size(95, 28);
            this.Kbtn_checkin.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.Kbtn_checkin.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.Kbtn_checkin.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.Kbtn_checkin.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.Kbtn_checkin.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Kbtn_checkin.StateCommon.Border.Rounding = 8;
            this.Kbtn_checkin.StateCommon.Border.Width = 2;
            this.Kbtn_checkin.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.Kbtn_checkin.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.Kbtn_checkin.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kbtn_checkin.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.Kbtn_checkin.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.Kbtn_checkin.StateTracking.Border.Color1 = System.Drawing.Color.White;
            this.Kbtn_checkin.StateTracking.Border.Color2 = System.Drawing.Color.White;
            this.Kbtn_checkin.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Kbtn_checkin.StateTracking.Border.Rounding = 8;
            this.Kbtn_checkin.StateTracking.Border.Width = 2;
            this.Kbtn_checkin.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.Kbtn_checkin.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.Kbtn_checkin.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kbtn_checkin.TabIndex = 1;
            this.Kbtn_checkin.Values.Text = "Xác nhận";
            this.Kbtn_checkin.Click += new System.EventHandler(this.Kbtn_checkin_Click);
            // 
            // LapPhieuRut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 464);
            this.Controls.Add(this.Kgrb_in);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LapPhieuRut";
            this.Text = "BaoCao";
            ((System.ComponentModel.ISupportInitialize)(this.Kgrb_in.Panel)).EndInit();
            this.Kgrb_in.Panel.ResumeLayout(false);
            this.Kgrb_in.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Kgrb_in)).EndInit();
            this.Kgrb_in.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ktxt_tienrut;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox Kgrb_in;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Kbtn_signin;
        private System.Windows.Forms.Label lbl_moso;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ktxt_ngayrut;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ktxt_ten;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ktxt_mstk;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Kbtn_checkin;
        private System.Windows.Forms.Label lbl_sodu;
    }
}