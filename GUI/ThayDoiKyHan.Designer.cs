namespace GUI
{
    partial class ThayDoiKyHan
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
            this.kryptonDataGridView1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kgrb_in = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.kryptonComboBox1 = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.Ktxt_maso = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Kbtn_checkin = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label1 = new System.Windows.Forms.Label();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ktxt_kyhanthem = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ktxt_laisuat = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ktxt_tien = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Kbtn_signin = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kgrb_in)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kgrb_in.Panel)).BeginInit();
            this.Kgrb_in.Panel.SuspendLayout();
            this.Kgrb_in.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonDataGridView1
            // 
            this.kryptonDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.kryptonDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kryptonDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column5});
            this.kryptonDataGridView1.Location = new System.Drawing.Point(388, 3);
            this.kryptonDataGridView1.Name = "kryptonDataGridView1";
            this.kryptonDataGridView1.RowHeadersWidth = 51;
            this.kryptonDataGridView1.Size = new System.Drawing.Size(465, 267);
            this.kryptonDataGridView1.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.kryptonDataGridView1.StateCommon.Background.Color2 = System.Drawing.Color.White;
            this.kryptonDataGridView1.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.kryptonDataGridView1.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.White;
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Border.Width = 3;
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Content.Color2 = System.Drawing.Color.White;
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonDataGridView1.TabIndex = 27;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Maloaitietkiem";
            this.Column1.HeaderText = "Mã Loại Tiết Kiệm";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Kyhan";
            this.Column4.HeaderText = "Kỳ Hạn";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Sotienguitoithieu";
            this.Column5.HeaderText = "Tiền Gửi Tối Thiểu";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Kgrb_in
            // 
            this.Kgrb_in.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Kgrb_in.CaptionOverlap = 0.8D;
            this.Kgrb_in.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.Kgrb_in.Location = new System.Drawing.Point(3, -16);
            this.Kgrb_in.Name = "Kgrb_in";
            // 
            // Kgrb_in.Panel
            // 
            this.Kgrb_in.Panel.Controls.Add(this.kryptonGroupBox1);
            this.Kgrb_in.Panel.Controls.Add(this.Kbtn_signin);
            this.Kgrb_in.Panel.Controls.Add(this.kryptonDataGridView1);
            this.Kgrb_in.Size = new System.Drawing.Size(871, 477);
            this.Kgrb_in.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.Kgrb_in.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.Kgrb_in.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.Kgrb_in.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.Kgrb_in.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Kgrb_in.StateCommon.Border.Rounding = 10;
            this.Kgrb_in.StateCommon.Border.Width = 3;
            this.Kgrb_in.TabIndex = 32;
            this.Kgrb_in.Values.Heading = "Check In";
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.label4);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonComboBox1);
            this.kryptonGroupBox1.Panel.Controls.Add(this.Ktxt_maso);
            this.kryptonGroupBox1.Panel.Controls.Add(this.Kbtn_checkin);
            this.kryptonGroupBox1.Panel.Controls.Add(this.label1);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonButton1);
            this.kryptonGroupBox1.Panel.Controls.Add(this.ktxt_kyhanthem);
            this.kryptonGroupBox1.Panel.Controls.Add(this.ktxt_laisuat);
            this.kryptonGroupBox1.Panel.Controls.Add(this.ktxt_tien);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(379, 440);
            this.kryptonGroupBox1.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonGroupBox1.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonGroupBox1.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.kryptonGroupBox1.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.kryptonGroupBox1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonGroupBox1.StateCommon.Border.Rounding = 10;
            this.kryptonGroupBox1.StateCommon.Border.Width = 3;
            this.kryptonGroupBox1.TabIndex = 34;
            this.kryptonGroupBox1.Values.Heading = "Chỉnh sửa";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.label4.Location = new System.Drawing.Point(95, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 20);
            this.label4.TabIndex = 57;
            this.label4.Text = "Thay đổi tiền gửi tối thiểu";
            // 
            // kryptonComboBox1
            // 
            this.kryptonComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kryptonComboBox1.DropDownWidth = 121;
            this.kryptonComboBox1.Location = new System.Drawing.Point(44, 101);
            this.kryptonComboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonComboBox1.Name = "kryptonComboBox1";
            this.kryptonComboBox1.Size = new System.Drawing.Size(274, 21);
            this.kryptonComboBox1.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.kryptonComboBox1.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.kryptonComboBox1.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonComboBox1.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Blue;
            this.kryptonComboBox1.StateCommon.DropBack.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.kryptonComboBox1.StateCommon.DropBack.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.kryptonComboBox1.TabIndex = 56;
            // 
            // Ktxt_maso
            // 
            this.Ktxt_maso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Ktxt_maso.Location = new System.Drawing.Point(44, 137);
            this.Ktxt_maso.Name = "Ktxt_maso";
            this.Ktxt_maso.Size = new System.Drawing.Size(158, 29);
            this.Ktxt_maso.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.Ktxt_maso.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.Ktxt_maso.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.Ktxt_maso.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Ktxt_maso.StateCommon.Border.Rounding = 10;
            this.Ktxt_maso.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.Ktxt_maso.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ktxt_maso.TabIndex = 54;
            this.Ktxt_maso.Text = "Tiền Gửi Tối Thiểu";
            this.Ktxt_maso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Ktxt_maso.Enter += new System.EventHandler(this.Ktxt_maso_Enter_1);
            this.Ktxt_maso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Ktxt_maso_KeyPress_1);
            this.Ktxt_maso.Leave += new System.EventHandler(this.Ktxt_maso_Leave_1);
            // 
            // Kbtn_checkin
            // 
            this.Kbtn_checkin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Kbtn_checkin.Location = new System.Drawing.Point(223, 138);
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
            this.Kbtn_checkin.TabIndex = 55;
            this.Kbtn_checkin.Values.Text = "Thay Đổi";
            this.Kbtn_checkin.Click += new System.EventHandler(this.Kbtn_checkin_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.label1.Location = new System.Drawing.Point(110, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 53;
            this.label1.Text = "Thêm loại tiết kiệm";
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonButton1.Location = new System.Drawing.Point(214, 317);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.kryptonButton1.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.kryptonButton1.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.kryptonButton1.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.kryptonButton1.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.kryptonButton1.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton1.Size = new System.Drawing.Size(95, 28);
            this.kryptonButton1.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.kryptonButton1.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.kryptonButton1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateCommon.Border.Rounding = 8;
            this.kryptonButton1.StateCommon.Border.Width = 2;
            this.kryptonButton1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.kryptonButton1.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.kryptonButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton1.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.kryptonButton1.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.kryptonButton1.StateTracking.Border.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.StateTracking.Border.Color2 = System.Drawing.Color.White;
            this.kryptonButton1.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateTracking.Border.Rounding = 8;
            this.kryptonButton1.StateTracking.Border.Width = 2;
            this.kryptonButton1.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButton1.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton1.TabIndex = 52;
            this.kryptonButton1.Values.Text = "Thêm";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click_1);
            // 
            // ktxt_kyhanthem
            // 
            this.ktxt_kyhanthem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ktxt_kyhanthem.Location = new System.Drawing.Point(22, 317);
            this.ktxt_kyhanthem.Name = "ktxt_kyhanthem";
            this.ktxt_kyhanthem.Size = new System.Drawing.Size(158, 29);
            this.ktxt_kyhanthem.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.ktxt_kyhanthem.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.ktxt_kyhanthem.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.ktxt_kyhanthem.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ktxt_kyhanthem.StateCommon.Border.Rounding = 10;
            this.ktxt_kyhanthem.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.ktxt_kyhanthem.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktxt_kyhanthem.TabIndex = 51;
            this.ktxt_kyhanthem.Text = "Kỳ hạn";
            this.ktxt_kyhanthem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ktxt_kyhanthem.Enter += new System.EventHandler(this.ktxt_kyhanthem_Enter);
            this.ktxt_kyhanthem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ktxt_kyhanthem_KeyPress);
            this.ktxt_kyhanthem.Leave += new System.EventHandler(this.ktxt_kyhanthem_Leave);
            // 
            // ktxt_laisuat
            // 
            this.ktxt_laisuat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ktxt_laisuat.Location = new System.Drawing.Point(203, 261);
            this.ktxt_laisuat.Name = "ktxt_laisuat";
            this.ktxt_laisuat.Size = new System.Drawing.Size(158, 29);
            this.ktxt_laisuat.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.ktxt_laisuat.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.ktxt_laisuat.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.ktxt_laisuat.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ktxt_laisuat.StateCommon.Border.Rounding = 10;
            this.ktxt_laisuat.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.ktxt_laisuat.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktxt_laisuat.TabIndex = 50;
            this.ktxt_laisuat.Text = "Lãi suất";
            this.ktxt_laisuat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ktxt_laisuat.Enter += new System.EventHandler(this.ktxt_laisuat_Enter);
            this.ktxt_laisuat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ktxt_laisuat_KeyPress);
            this.ktxt_laisuat.Leave += new System.EventHandler(this.ktxt_laisuat_Leave);
            // 
            // ktxt_tien
            // 
            this.ktxt_tien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ktxt_tien.Location = new System.Drawing.Point(22, 261);
            this.ktxt_tien.Name = "ktxt_tien";
            this.ktxt_tien.Size = new System.Drawing.Size(158, 29);
            this.ktxt_tien.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.ktxt_tien.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.ktxt_tien.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.ktxt_tien.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ktxt_tien.StateCommon.Border.Rounding = 10;
            this.ktxt_tien.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.ktxt_tien.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktxt_tien.TabIndex = 49;
            this.ktxt_tien.Text = "Tiền Gửi Tối Thiểu";
            this.ktxt_tien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ktxt_tien.Enter += new System.EventHandler(this.ktxt_tien_Enter);
            this.ktxt_tien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ktxt_tien_KeyPress);
            this.ktxt_tien.Leave += new System.EventHandler(this.ktxt_tien_Leave);
            // 
            // Kbtn_signin
            // 
            this.Kbtn_signin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Kbtn_signin.Location = new System.Drawing.Point(808, 404);
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
            this.Kbtn_signin.TabIndex = 33;
            this.Kbtn_signin.Values.Text = "X";
            this.Kbtn_signin.Click += new System.EventHandler(this.Kbtn_signin_Click);
            // 
            // ThayDoiKyHan
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(874, 464);
            this.Controls.Add(this.Kgrb_in);
            this.Name = "ThayDoiKyHan";
            this.Text = "ThayDoiQuyDinh";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kgrb_in.Panel)).EndInit();
            this.Kgrb_in.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Kgrb_in)).EndInit();
            this.Kgrb_in.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox Kgrb_in;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Kbtn_signin;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ktxt_laisuat;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ktxt_tien;
        private System.Windows.Forms.Label label4;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kryptonComboBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox Ktxt_maso;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Kbtn_checkin;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ktxt_kyhanthem;
    }
}