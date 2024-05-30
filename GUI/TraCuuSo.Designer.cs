using System.Windows.Forms;

namespace GUI
{
    partial class TraCuuSo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Kdt_socantracuu = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.lbl_moso = new System.Windows.Forms.Label();
            this.Ktxt_maso = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Kbtn_tim = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btn_tatca = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Kbtn_signin = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.Kdt_socantracuu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Kdt_socantracuu
            // 
            this.Kdt_socantracuu.AllowUserToAddRows = false;
            this.Kdt_socantracuu.AllowUserToDeleteRows = false;
            this.Kdt_socantracuu.AllowUserToOrderColumns = true;
            this.Kdt_socantracuu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Kdt_socantracuu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.Kdt_socantracuu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Kdt_socantracuu.Location = new System.Drawing.Point(12, 72);
            this.Kdt_socantracuu.Name = "Kdt_socantracuu";
            this.Kdt_socantracuu.ReadOnly = true;
            this.Kdt_socantracuu.RowHeadersWidth = 20;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Kdt_socantracuu.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Kdt_socantracuu.Size = new System.Drawing.Size(593, 380);
            this.Kdt_socantracuu.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.Kdt_socantracuu.StateCommon.Background.Color2 = System.Drawing.Color.White;
            this.Kdt_socantracuu.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.Kdt_socantracuu.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.White;
            this.Kdt_socantracuu.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.Kdt_socantracuu.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.Kdt_socantracuu.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Kdt_socantracuu.StateCommon.HeaderColumn.Border.Width = 3;
            this.Kdt_socantracuu.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.Kdt_socantracuu.StateCommon.HeaderColumn.Content.Color2 = System.Drawing.Color.White;
            this.Kdt_socantracuu.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kdt_socantracuu.TabIndex = 0;
            // 
            // lbl_moso
            // 
            this.lbl_moso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_moso.AutoSize = true;
            this.lbl_moso.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_moso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.lbl_moso.Location = new System.Drawing.Point(182, 5);
            this.lbl_moso.Name = "lbl_moso";
            this.lbl_moso.Size = new System.Drawing.Size(545, 55);
            this.lbl_moso.TabIndex = 7;
            this.lbl_moso.Text = "Danh sách gửi tiết kiệm";
            // 
            // Ktxt_maso
            // 
            this.Ktxt_maso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Ktxt_maso.Location = new System.Drawing.Point(629, 126);
            this.Ktxt_maso.Name = "Ktxt_maso";
            this.Ktxt_maso.Size = new System.Drawing.Size(233, 28);
            this.Ktxt_maso.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.Ktxt_maso.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.Ktxt_maso.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.Ktxt_maso.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Ktxt_maso.StateCommon.Border.Rounding = 10;
            this.Ktxt_maso.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.Ktxt_maso.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ktxt_maso.TabIndex = 29;
            this.Ktxt_maso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Kbtn_tim
            // 
            this.Kbtn_tim.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Kbtn_tim.Location = new System.Drawing.Point(643, 161);
            this.Kbtn_tim.Name = "Kbtn_tim";
            this.Kbtn_tim.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.Kbtn_tim.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.Kbtn_tim.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.Kbtn_tim.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.Kbtn_tim.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Kbtn_tim.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.Kbtn_tim.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.Kbtn_tim.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kbtn_tim.Size = new System.Drawing.Size(95, 28);
            this.Kbtn_tim.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.Kbtn_tim.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.Kbtn_tim.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.Kbtn_tim.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.Kbtn_tim.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Kbtn_tim.StateCommon.Border.Rounding = 8;
            this.Kbtn_tim.StateCommon.Border.Width = 2;
            this.Kbtn_tim.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.Kbtn_tim.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.Kbtn_tim.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kbtn_tim.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.Kbtn_tim.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.Kbtn_tim.StateTracking.Border.Color1 = System.Drawing.Color.White;
            this.Kbtn_tim.StateTracking.Border.Color2 = System.Drawing.Color.White;
            this.Kbtn_tim.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Kbtn_tim.StateTracking.Border.Rounding = 8;
            this.Kbtn_tim.StateTracking.Border.Width = 2;
            this.Kbtn_tim.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.Kbtn_tim.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.Kbtn_tim.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kbtn_tim.TabIndex = 30;
            this.Kbtn_tim.Values.Text = "Tìm";
            this.Kbtn_tim.Click += new System.EventHandler(this.Kbtn_tim_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.label1.Location = new System.Drawing.Point(639, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 24);
            this.label1.TabIndex = 31;
            this.label1.Text = "Nhập mã sổ để tìm kiếm";
            // 
            // btn_tatca
            // 
            this.btn_tatca.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_tatca.Location = new System.Drawing.Point(758, 161);
            this.btn_tatca.Name = "btn_tatca";
            this.btn_tatca.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.btn_tatca.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.btn_tatca.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btn_tatca.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btn_tatca.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_tatca.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btn_tatca.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btn_tatca.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tatca.Size = new System.Drawing.Size(95, 28);
            this.btn_tatca.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btn_tatca.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btn_tatca.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btn_tatca.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btn_tatca.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_tatca.StateCommon.Border.Rounding = 8;
            this.btn_tatca.StateCommon.Border.Width = 2;
            this.btn_tatca.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btn_tatca.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btn_tatca.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tatca.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btn_tatca.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btn_tatca.StateTracking.Border.Color1 = System.Drawing.Color.White;
            this.btn_tatca.StateTracking.Border.Color2 = System.Drawing.Color.White;
            this.btn_tatca.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_tatca.StateTracking.Border.Rounding = 8;
            this.btn_tatca.StateTracking.Border.Width = 2;
            this.btn_tatca.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_tatca.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_tatca.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tatca.TabIndex = 32;
            this.btn_tatca.Values.Text = "Tất cả";
            this.btn_tatca.Click += new System.EventHandler(this.btn_tatca_Click);
            // 
            // Kbtn_signin
            // 
            this.Kbtn_signin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Kbtn_signin.Location = new System.Drawing.Point(830, 420);
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
            // TraCuuSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 464);
            this.Controls.Add(this.Kbtn_signin);
            this.Controls.Add(this.btn_tatca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Kbtn_tim);
            this.Controls.Add(this.Ktxt_maso);
            this.Controls.Add(this.lbl_moso);
            this.Controls.Add(this.Kdt_socantracuu);
            this.Name = "TraCuuSo";
            this.Text = "TraCuuSo";
            ((System.ComponentModel.ISupportInitialize)(this.Kdt_socantracuu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView Kdt_socantracuu;
        private System.Windows.Forms.Label lbl_moso;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox Ktxt_maso;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Kbtn_tim;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_tatca;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Kbtn_signin;
    }
}