
namespace RestaurantManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.L_Menu = new System.Windows.Forms.Label();
            this.P_Sh_Pic = new System.Windows.Forms.PictureBox();
            this.Bt_Del = new System.Windows.Forms.Button();
            this.Bt_Ad = new System.Windows.Forms.Button();
            this.Bt_Delete = new System.Windows.Forms.Button();
            this.Bt_Clear = new System.Windows.Forms.Button();
            this.Bt_Confirm = new System.Windows.Forms.Button();
            this.Da_SEL_Menu = new System.Windows.Forms.DataGridView();
            this.Da_Sh_Menu = new System.Windows.Forms.DataGridView();
            this.amount_of_F = new System.Windows.Forms.NumericUpDown();
            this.Bt_Add = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BT_Log_Out = new System.Windows.Forms.Button();
            this.Bt_Pic = new System.Windows.Forms.Button();
            this.L_Show = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.P_Sh_Pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Da_SEL_Menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Da_Sh_Menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amount_of_F)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // L_Menu
            // 
            this.L_Menu.AutoSize = true;
            this.L_Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.L_Menu.Location = new System.Drawing.Point(56, 32);
            this.L_Menu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.L_Menu.Name = "L_Menu";
            this.L_Menu.Size = new System.Drawing.Size(196, 39);
            this.L_Menu.TabIndex = 0;
            this.L_Menu.Text = "รายการอาหาร";
            // 
            // P_Sh_Pic
            // 
            this.P_Sh_Pic.BackColor = System.Drawing.SystemColors.Control;
            this.P_Sh_Pic.Location = new System.Drawing.Point(716, 44);
            this.P_Sh_Pic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.P_Sh_Pic.Name = "P_Sh_Pic";
            this.P_Sh_Pic.Size = new System.Drawing.Size(576, 281);
            this.P_Sh_Pic.TabIndex = 3;
            this.P_Sh_Pic.TabStop = false;
            // 
            // Bt_Del
            // 
            this.Bt_Del.BackColor = System.Drawing.Color.Red;
            this.Bt_Del.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Bt_Del.Location = new System.Drawing.Point(1188, 364);
            this.Bt_Del.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Bt_Del.Name = "Bt_Del";
            this.Bt_Del.Size = new System.Drawing.Size(120, 52);
            this.Bt_Del.TabIndex = 4;
            this.Bt_Del.Text = "-";
            this.Bt_Del.UseVisualStyleBackColor = false;
            this.Bt_Del.Click += new System.EventHandler(this.Bt_Del_Click);
            // 
            // Bt_Ad
            // 
            this.Bt_Ad.BackColor = System.Drawing.Color.Blue;
            this.Bt_Ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Bt_Ad.Location = new System.Drawing.Point(845, 364);
            this.Bt_Ad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Bt_Ad.Name = "Bt_Ad";
            this.Bt_Ad.Size = new System.Drawing.Size(120, 52);
            this.Bt_Ad.TabIndex = 5;
            this.Bt_Ad.Text = "+";
            this.Bt_Ad.UseVisualStyleBackColor = false;
            this.Bt_Ad.Click += new System.EventHandler(this.Bt_Ad_Click);
            // 
            // Bt_Delete
            // 
            this.Bt_Delete.BackColor = System.Drawing.Color.Red;
            this.Bt_Delete.Location = new System.Drawing.Point(757, 711);
            this.Bt_Delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Bt_Delete.Name = "Bt_Delete";
            this.Bt_Delete.Size = new System.Drawing.Size(120, 52);
            this.Bt_Delete.TabIndex = 7;
            this.Bt_Delete.Text = "ลบ";
            this.Bt_Delete.UseVisualStyleBackColor = false;
            this.Bt_Delete.Click += new System.EventHandler(this.Bt_Delete_Click);
            // 
            // Bt_Clear
            // 
            this.Bt_Clear.BackColor = System.Drawing.Color.Lime;
            this.Bt_Clear.Location = new System.Drawing.Point(979, 711);
            this.Bt_Clear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Bt_Clear.Name = "Bt_Clear";
            this.Bt_Clear.Size = new System.Drawing.Size(120, 52);
            this.Bt_Clear.TabIndex = 8;
            this.Bt_Clear.Text = "เคลียร์";
            this.Bt_Clear.UseVisualStyleBackColor = false;
            this.Bt_Clear.Click += new System.EventHandler(this.Bt_Clear_Click);
            // 
            // Bt_Confirm
            // 
            this.Bt_Confirm.BackColor = System.Drawing.Color.Blue;
            this.Bt_Confirm.Location = new System.Drawing.Point(1188, 711);
            this.Bt_Confirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Bt_Confirm.Name = "Bt_Confirm";
            this.Bt_Confirm.Size = new System.Drawing.Size(120, 52);
            this.Bt_Confirm.TabIndex = 9;
            this.Bt_Confirm.Text = "ยืนยัน";
            this.Bt_Confirm.UseVisualStyleBackColor = false;
            this.Bt_Confirm.Click += new System.EventHandler(this.Bt_Confirm_Click);
            // 
            // Da_SEL_Menu
            // 
            this.Da_SEL_Menu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Da_SEL_Menu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Da_SEL_Menu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Da_SEL_Menu.Location = new System.Drawing.Point(661, 450);
            this.Da_SEL_Menu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Da_SEL_Menu.Name = "Da_SEL_Menu";
            this.Da_SEL_Menu.RowHeadersWidth = 51;
            this.Da_SEL_Menu.Size = new System.Drawing.Size(712, 229);
            this.Da_SEL_Menu.TabIndex = 10;
            // 
            // Da_Sh_Menu
            // 
            this.Da_Sh_Menu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Da_Sh_Menu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Da_Sh_Menu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Da_Sh_Menu.Location = new System.Drawing.Point(28, 119);
            this.Da_Sh_Menu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Da_Sh_Menu.Name = "Da_Sh_Menu";
            this.Da_Sh_Menu.RowHeadersWidth = 51;
            this.Da_Sh_Menu.Size = new System.Drawing.Size(593, 560);
            this.Da_Sh_Menu.TabIndex = 11;
            this.Da_Sh_Menu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Da_Sh_Menu_CellContentClick);
            // 
            // amount_of_F
            // 
            this.amount_of_F.BackColor = System.Drawing.Color.White;
            this.amount_of_F.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.amount_of_F.Location = new System.Drawing.Point(993, 369);
            this.amount_of_F.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.amount_of_F.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.amount_of_F.Name = "amount_of_F";
            this.amount_of_F.ReadOnly = true;
            this.amount_of_F.Size = new System.Drawing.Size(171, 37);
            this.amount_of_F.TabIndex = 12;
            this.amount_of_F.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Bt_Add
            // 
            this.Bt_Add.BackColor = System.Drawing.Color.Fuchsia;
            this.Bt_Add.Location = new System.Drawing.Point(692, 362);
            this.Bt_Add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Bt_Add.Name = "Bt_Add";
            this.Bt_Add.Size = new System.Drawing.Size(120, 54);
            this.Bt_Add.TabIndex = 13;
            this.Bt_Add.Text = "เพิ่มลงในตะกร้า";
            this.Bt_Add.UseVisualStyleBackColor = false;
            this.Bt_Add.Click += new System.EventHandler(this.Bt_Add_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(221)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.BT_Log_Out);
            this.panel2.Controls.Add(this.Bt_Pic);
            this.panel2.Controls.Add(this.L_Show);
            this.panel2.Location = new System.Drawing.Point(-4, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1301, 118);
            this.panel2.TabIndex = 65;
            // 
            // BT_Log_Out
            // 
            this.BT_Log_Out.FlatAppearance.BorderSize = 0;
            this.BT_Log_Out.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Log_Out.Font = new System.Drawing.Font("Andalus", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Log_Out.Image = ((System.Drawing.Image)(resources.GetObject("BT_Log_Out.Image")));
            this.BT_Log_Out.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_Log_Out.Location = new System.Drawing.Point(1088, 19);
            this.BT_Log_Out.Name = "BT_Log_Out";
            this.BT_Log_Out.Size = new System.Drawing.Size(190, 80);
            this.BT_Log_Out.TabIndex = 68;
            this.BT_Log_Out.Text = "Log Out";
            this.BT_Log_Out.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BT_Log_Out.UseVisualStyleBackColor = true;
            // 
            // Bt_Pic
            // 
            this.Bt_Pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Bt_Pic.FlatAppearance.BorderSize = 0;
            this.Bt_Pic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_Pic.Image = ((System.Drawing.Image)(resources.GetObject("Bt_Pic.Image")));
            this.Bt_Pic.Location = new System.Drawing.Point(22, 27);
            this.Bt_Pic.Name = "Bt_Pic";
            this.Bt_Pic.Size = new System.Drawing.Size(75, 75);
            this.Bt_Pic.TabIndex = 63;
            this.Bt_Pic.UseVisualStyleBackColor = true;
            // 
            // L_Show
            // 
            this.L_Show.AutoSize = true;
            this.L_Show.Font = new System.Drawing.Font("Bodoni MT Condensed", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Show.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.L_Show.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.L_Show.Location = new System.Drawing.Point(103, 14);
            this.L_Show.Name = "L_Show";
            this.L_Show.Size = new System.Drawing.Size(205, 100);
            this.L_Show.TabIndex = 63;
            this.L_Show.Text = "Restaurant \r\nManagement";
            this.L_Show.Click += new System.EventHandler(this.L_Show_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1293, 838);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Bt_Add);
            this.Controls.Add(this.amount_of_F);
            this.Controls.Add(this.Da_Sh_Menu);
            this.Controls.Add(this.Da_SEL_Menu);
            this.Controls.Add(this.Bt_Confirm);
            this.Controls.Add(this.Bt_Clear);
            this.Controls.Add(this.Bt_Delete);
            this.Controls.Add(this.Bt_Ad);
            this.Controls.Add(this.Bt_Del);
            this.Controls.Add(this.P_Sh_Pic);
            this.Controls.Add(this.L_Menu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.P_Sh_Pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Da_SEL_Menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Da_Sh_Menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amount_of_F)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_Menu;
        private System.Windows.Forms.PictureBox P_Sh_Pic;
        private System.Windows.Forms.Button Bt_Del;
        private System.Windows.Forms.Button Bt_Ad;
        private System.Windows.Forms.Button Bt_Delete;
        private System.Windows.Forms.Button Bt_Clear;
        private System.Windows.Forms.Button Bt_Confirm;
        private System.Windows.Forms.DataGridView Da_SEL_Menu;
        private System.Windows.Forms.DataGridView Da_Sh_Menu;
        private System.Windows.Forms.NumericUpDown amount_of_F;
        private System.Windows.Forms.Button Bt_Add;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BT_Log_Out;
        private System.Windows.Forms.Button Bt_Pic;
        private System.Windows.Forms.Label L_Show;
    }
}

