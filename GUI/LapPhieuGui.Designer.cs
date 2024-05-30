
using System;

namespace GUI
{
    partial class LapPhieuGui
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
            this.components = new System.ComponentModel.Container();
            this.Kgrb_in = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.Klbl_sodu = new System.Windows.Forms.Label();
            this.Kdtp_thangnam = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Kbtn_signin = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lbl_moso = new System.Windows.Forms.Label();
            this.Ktxt_sotien = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Ktxt_tenkhach = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Ktxt_maso = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Kbtn_checkin = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Kgrb_in)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kgrb_in.Panel)).BeginInit();
            this.Kgrb_in.Panel.SuspendLayout();
            this.Kgrb_in.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
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
            this.Kgrb_in.Panel.Controls.Add(this.Klbl_sodu);
            this.Kgrb_in.Panel.Controls.Add(this.Kdtp_thangnam);
            this.Kgrb_in.Panel.Controls.Add(this.label5);
            this.Kgrb_in.Panel.Controls.Add(this.label4);
            this.Kgrb_in.Panel.Controls.Add(this.label1);
            this.Kgrb_in.Panel.Controls.Add(this.Kbtn_signin);
            this.Kgrb_in.Panel.Controls.Add(this.lbl_moso);
            this.Kgrb_in.Panel.Controls.Add(this.Ktxt_sotien);
            this.Kgrb_in.Panel.Controls.Add(this.Ktxt_tenkhach);
            this.Kgrb_in.Panel.Controls.Add(this.Ktxt_maso);
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
            this.Kgrb_in.TabIndex = 18;
            this.Kgrb_in.Values.Heading = "Lập phiếu gửi";
            // 
            // Klbl_sodu
            // 
            this.Klbl_sodu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Klbl_sodu.AutoSize = true;
            this.Klbl_sodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Klbl_sodu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.Klbl_sodu.Location = new System.Drawing.Point(543, 259);
            this.Klbl_sodu.Name = "Klbl_sodu";
            this.Klbl_sodu.Size = new System.Drawing.Size(0, 16);
            this.Klbl_sodu.TabIndex = 32;
            // 
            // Kdtp_thangnam
            // 
            this.Kdtp_thangnam.CausesValidation = false;
            this.Kdtp_thangnam.CustomFormat = "dd/MM/yyyy";
            this.Kdtp_thangnam.Enabled = false;
            this.Kdtp_thangnam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Kdtp_thangnam.Location = new System.Drawing.Point(445, 202);
            this.Kdtp_thangnam.Name = "Kdtp_thangnam";
            this.Kdtp_thangnam.Size = new System.Drawing.Size(200, 28);
            this.Kdtp_thangnam.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.Kdtp_thangnam.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.Kdtp_thangnam.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.Kdtp_thangnam.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Kdtp_thangnam.StateCommon.Border.Rounding = 10;
            this.Kdtp_thangnam.StateCommon.Border.Width = 3;
            this.Kdtp_thangnam.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.Kdtp_thangnam.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kdtp_thangnam.TabIndex = 30;
            this.Kdtp_thangnam.ValueNullable = new System.DateTime(2023, 5, 6, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.label5.Location = new System.Drawing.Point(29, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Tên khách hàng:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.label4.Location = new System.Drawing.Point(29, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Nhập số tiền gửi:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.label1.Location = new System.Drawing.Point(29, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Mã sổ tiết kiệm cần gửi:";
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
            this.lbl_moso.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_moso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.lbl_moso.Location = new System.Drawing.Point(255, 31);
            this.lbl_moso.Name = "lbl_moso";
            this.lbl_moso.Size = new System.Drawing.Size(341, 55);
            this.lbl_moso.TabIndex = 6;
            this.lbl_moso.Text = "Lập Phiếu Gửi";
            // 
            // Ktxt_sotien
            // 
            this.Ktxt_sotien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Ktxt_sotien.Location = new System.Drawing.Point(209, 251);
            this.Ktxt_sotien.Name = "Ktxt_sotien";
            this.Ktxt_sotien.Size = new System.Drawing.Size(296, 29);
            this.Ktxt_sotien.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.Ktxt_sotien.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.Ktxt_sotien.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.Ktxt_sotien.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Ktxt_sotien.StateCommon.Border.Rounding = 10;
            this.Ktxt_sotien.StateCommon.Content.Color1 = System.Drawing.Color.CornflowerBlue;
            this.Ktxt_sotien.TabIndex = 2;
            // 
            // Ktxt_tenkhach
            // 
            this.Ktxt_tenkhach.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Ktxt_tenkhach.Enabled = false;
            this.Ktxt_tenkhach.Location = new System.Drawing.Point(209, 202);
            this.Ktxt_tenkhach.Name = "Ktxt_tenkhach";
            this.Ktxt_tenkhach.Size = new System.Drawing.Size(214, 29);
            this.Ktxt_tenkhach.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.Ktxt_tenkhach.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.Ktxt_tenkhach.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.Ktxt_tenkhach.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Ktxt_tenkhach.StateCommon.Border.Rounding = 10;
            this.Ktxt_tenkhach.StateCommon.Content.Color1 = System.Drawing.Color.CornflowerBlue;
            this.Ktxt_tenkhach.TabIndex = 2;
            // 
            // Ktxt_maso
            // 
            this.Ktxt_maso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Ktxt_maso.Location = new System.Drawing.Point(209, 153);
            this.Ktxt_maso.Name = "Ktxt_maso";
            this.Ktxt_maso.Size = new System.Drawing.Size(436, 27);
            this.Ktxt_maso.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.Ktxt_maso.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.Ktxt_maso.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.Ktxt_maso.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Ktxt_maso.StateCommon.Border.Rounding = 10;
            this.Ktxt_maso.StateCommon.Content.Color1 = System.Drawing.Color.CornflowerBlue;
            this.Ktxt_maso.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ktxt_maso.TabIndex = 2;
            this.Ktxt_maso.TextChanged += new System.EventHandler(this.Ktxt_maso_TextChanged);
            // 
            // Kbtn_checkin
            // 
            this.Kbtn_checkin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Kbtn_checkin.Location = new System.Drawing.Point(380, 304);
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
            this.Kbtn_checkin.TabIndex = 5;
            this.Kbtn_checkin.Values.Text = "Xác nhận";
            this.Kbtn_checkin.Click += new System.EventHandler(this.Kbtn_checkin_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // LapPhieuGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(874, 464);
            this.Controls.Add(this.Kgrb_in);
            this.DoubleBuffered = true;
            this.Name = "LapPhieuGui";
            this.Text = "QuanLyTaiKhoan";
            ((System.ComponentModel.ISupportInitialize)(this.Kgrb_in.Panel)).EndInit();
            this.Kgrb_in.Panel.ResumeLayout(false);
            this.Kgrb_in.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Kgrb_in)).EndInit();
            this.Kgrb_in.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox Kgrb_in;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Kbtn_signin;
        private System.Windows.Forms.Label lbl_moso;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox Ktxt_sotien;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox Ktxt_tenkhach;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Kbtn_checkin;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox Ktxt_maso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker Kdtp_thangnam;
        private System.Windows.Forms.Label Klbl_sodu;
    }
}