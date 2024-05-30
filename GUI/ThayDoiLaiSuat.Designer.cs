namespace GUI
{
    partial class ThayDoiLaiSuat
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
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.ktxt_thoigian = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Ktxt_laisuat = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Kbtn_signin = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Kcb_loaitietkiem = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.Kdt_thoigiangui = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.Kbtn_thaydoi = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Kcb_loaitietkiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kdt_thoigiangui)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.kryptonGroupBox1.CaptionOverlap = 0.8D;
            this.kryptonGroupBox1.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonGroupBox1.Location = new System.Drawing.Point(4, -14);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.ktxt_thoigian);
            this.kryptonGroupBox1.Panel.Controls.Add(this.Ktxt_laisuat);
            this.kryptonGroupBox1.Panel.Controls.Add(this.label4);
            this.kryptonGroupBox1.Panel.Controls.Add(this.Kbtn_signin);
            this.kryptonGroupBox1.Panel.Controls.Add(this.Kcb_loaitietkiem);
            this.kryptonGroupBox1.Panel.Controls.Add(this.Kdt_thoigiangui);
            this.kryptonGroupBox1.Panel.Controls.Add(this.Kbtn_thaydoi);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(867, 477);
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
            this.kryptonGroupBox1.Values.Heading = "Check In";
            // 
            // ktxt_thoigian
            // 
            this.ktxt_thoigian.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ktxt_thoigian.Location = new System.Drawing.Point(565, 167);
            this.ktxt_thoigian.Name = "ktxt_thoigian";
            this.ktxt_thoigian.Size = new System.Drawing.Size(158, 29);
            this.ktxt_thoigian.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.ktxt_thoigian.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.ktxt_thoigian.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.ktxt_thoigian.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ktxt_thoigian.StateCommon.Border.Rounding = 10;
            this.ktxt_thoigian.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.ktxt_thoigian.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktxt_thoigian.TabIndex = 61;
            this.ktxt_thoigian.Text = "Thời gian (tháng)";
            this.ktxt_thoigian.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ktxt_thoigian.Enter += new System.EventHandler(this.ktxt_thoigian_Enter);
            this.ktxt_thoigian.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ktxt_thoigian_KeyPress);
            this.ktxt_thoigian.Leave += new System.EventHandler(this.ktxt_thoigian_Leave);
            // 
            // Ktxt_laisuat
            // 
            this.Ktxt_laisuat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Ktxt_laisuat.Location = new System.Drawing.Point(746, 131);
            this.Ktxt_laisuat.Name = "Ktxt_laisuat";
            this.Ktxt_laisuat.Size = new System.Drawing.Size(95, 29);
            this.Ktxt_laisuat.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.Ktxt_laisuat.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.Ktxt_laisuat.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.Ktxt_laisuat.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Ktxt_laisuat.StateCommon.Border.Rounding = 10;
            this.Ktxt_laisuat.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.Ktxt_laisuat.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ktxt_laisuat.TabIndex = 60;
            this.Ktxt_laisuat.Text = "Lãi suất";
            this.Ktxt_laisuat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Ktxt_laisuat.Enter += new System.EventHandler(this.Ktxt_laisuat_Enter);
            this.Ktxt_laisuat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Ktxt_laisuat_KeyPress);
            this.Ktxt_laisuat.Leave += new System.EventHandler(this.Ktxt_laisuat_Leave);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.label4.Location = new System.Drawing.Point(647, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 58;
            this.label4.Text = "Thay đổi lãi suất";
            // 
            // Kbtn_signin
            // 
            this.Kbtn_signin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Kbtn_signin.Location = new System.Drawing.Point(807, 402);
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
            this.Kbtn_signin.TabIndex = 35;
            this.Kbtn_signin.Values.Text = "X";
            this.Kbtn_signin.Click += new System.EventHandler(this.Kbtn_signin_Click);
            // 
            // Kcb_loaitietkiem
            // 
            this.Kcb_loaitietkiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Kcb_loaitietkiem.DropDownWidth = 121;
            this.Kcb_loaitietkiem.Location = new System.Drawing.Point(565, 139);
            this.Kcb_loaitietkiem.Name = "Kcb_loaitietkiem";
            this.Kcb_loaitietkiem.Size = new System.Drawing.Size(147, 21);
            this.Kcb_loaitietkiem.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.Kcb_loaitietkiem.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.Kcb_loaitietkiem.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Kcb_loaitietkiem.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Blue;
            this.Kcb_loaitietkiem.StateCommon.DropBack.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.Kcb_loaitietkiem.StateCommon.DropBack.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.Kcb_loaitietkiem.TabIndex = 30;
            // 
            // Kdt_thoigiangui
            // 
            this.Kdt_thoigiangui.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Kdt_thoigiangui.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Kdt_thoigiangui.Location = new System.Drawing.Point(3, 3);
            this.Kdt_thoigiangui.Name = "Kdt_thoigiangui";
            this.Kdt_thoigiangui.Size = new System.Drawing.Size(556, 443);
            this.Kdt_thoigiangui.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.Kdt_thoigiangui.StateCommon.Background.Color2 = System.Drawing.Color.White;
            this.Kdt_thoigiangui.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.Kdt_thoigiangui.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.White;
            this.Kdt_thoigiangui.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.Kdt_thoigiangui.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.Kdt_thoigiangui.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Kdt_thoigiangui.StateCommon.HeaderColumn.Border.Width = 3;
            this.Kdt_thoigiangui.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.Kdt_thoigiangui.StateCommon.HeaderColumn.Content.Color2 = System.Drawing.Color.White;
            this.Kdt_thoigiangui.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kdt_thoigiangui.TabIndex = 27;
            // 
            // Kbtn_thaydoi
            // 
            this.Kbtn_thaydoi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Kbtn_thaydoi.Location = new System.Drawing.Point(746, 167);
            this.Kbtn_thaydoi.Name = "Kbtn_thaydoi";
            this.Kbtn_thaydoi.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.Kbtn_thaydoi.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.Kbtn_thaydoi.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.Kbtn_thaydoi.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.Kbtn_thaydoi.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Kbtn_thaydoi.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.Kbtn_thaydoi.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.Kbtn_thaydoi.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kbtn_thaydoi.Size = new System.Drawing.Size(95, 28);
            this.Kbtn_thaydoi.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.Kbtn_thaydoi.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.Kbtn_thaydoi.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.Kbtn_thaydoi.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.Kbtn_thaydoi.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Kbtn_thaydoi.StateCommon.Border.Rounding = 8;
            this.Kbtn_thaydoi.StateCommon.Border.Width = 2;
            this.Kbtn_thaydoi.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.Kbtn_thaydoi.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.Kbtn_thaydoi.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kbtn_thaydoi.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.Kbtn_thaydoi.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.Kbtn_thaydoi.StateTracking.Border.Color1 = System.Drawing.Color.White;
            this.Kbtn_thaydoi.StateTracking.Border.Color2 = System.Drawing.Color.White;
            this.Kbtn_thaydoi.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Kbtn_thaydoi.StateTracking.Border.Rounding = 8;
            this.Kbtn_thaydoi.StateTracking.Border.Width = 2;
            this.Kbtn_thaydoi.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.Kbtn_thaydoi.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.Kbtn_thaydoi.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kbtn_thaydoi.TabIndex = 29;
            this.Kbtn_thaydoi.Values.Text = "Thay Đổi";
            this.Kbtn_thaydoi.Click += new System.EventHandler(this.Kbtn_thaydoi_Click);
            // 
            // ThayDoiLaiSuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 464);
            this.Controls.Add(this.kryptonGroupBox1);
            this.Name = "ThayDoiLaiSuat";
            this.Text = "ThayDoiThoiGianGuiToiThieu";
            this.Load += new System.EventHandler(this.ThayDoiLaiSuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Kcb_loaitietkiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kdt_thoigiangui)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox Kcb_loaitietkiem;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView Kdt_thoigiangui;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Kbtn_thaydoi;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Kbtn_signin;
        private System.Windows.Forms.Label label4;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ktxt_thoigian;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox Ktxt_laisuat;
    }
}