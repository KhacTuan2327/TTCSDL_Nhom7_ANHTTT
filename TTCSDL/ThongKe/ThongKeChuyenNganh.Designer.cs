﻿
namespace TTCSDL
{
    partial class ThongKeChuyenNganh
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbbnganh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataTK = new Guna.UI.WinForms.GunaDataGridView();
            this.lbSL = new System.Windows.Forms.Label();
            this.soluong = new System.Windows.Forms.Label();
            this.search = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnExportFile = new FontAwesome.Sharp.IconButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataTK)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbnganh
            // 
            this.cbbnganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbnganh.FormattingEnabled = true;
            this.cbbnganh.Location = new System.Drawing.Point(37, 71);
            this.cbbnganh.Name = "cbbnganh";
            this.cbbnganh.Size = new System.Drawing.Size(644, 37);
            this.cbbnganh.TabIndex = 89;
            this.cbbnganh.SelectedIndexChanged += new System.EventHandler(this.cbbkhoa_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 30);
            this.label1.TabIndex = 98;
            this.label1.Text = "Chọn Chuyên ngành:";
            // 
            // dataTK
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dataTK.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataTK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTK.BackgroundColor = System.Drawing.Color.White;
            this.dataTK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataTK.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataTK.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTK.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataTK.ColumnHeadersHeight = 32;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataTK.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataTK.EnableHeadersVisualStyles = false;
            this.dataTK.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataTK.Location = new System.Drawing.Point(7, 172);
            this.dataTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataTK.Name = "dataTK";
            this.dataTK.ReadOnly = true;
            this.dataTK.RowHeadersVisible = false;
            this.dataTK.RowHeadersWidth = 62;
            this.dataTK.RowTemplate.Height = 28;
            this.dataTK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataTK.Size = new System.Drawing.Size(1181, 608);
            this.dataTK.TabIndex = 99;
            this.dataTK.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dataTK.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataTK.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataTK.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataTK.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataTK.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataTK.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataTK.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataTK.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataTK.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataTK.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataTK.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataTK.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataTK.ThemeStyle.HeaderStyle.Height = 32;
            this.dataTK.ThemeStyle.ReadOnly = true;
            this.dataTK.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataTK.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataTK.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataTK.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.dataTK.ThemeStyle.RowsStyle.Height = 28;
            this.dataTK.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataTK.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // lbSL
            // 
            this.lbSL.AutoSize = true;
            this.lbSL.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSL.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lbSL.Location = new System.Drawing.Point(241, 124);
            this.lbSL.Name = "lbSL";
            this.lbSL.Size = new System.Drawing.Size(23, 28);
            this.lbSL.TabIndex = 130;
            this.lbSL.Text = "0";
            // 
            // soluong
            // 
            this.soluong.AutoSize = true;
            this.soluong.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soluong.ForeColor = System.Drawing.Color.DarkBlue;
            this.soluong.Location = new System.Drawing.Point(22, 123);
            this.soluong.Name = "soluong";
            this.soluong.Size = new System.Drawing.Size(213, 30);
            this.soluong.TabIndex = 129;
            this.soluong.Text = "Tổng số lượng đề tài";
            // 
            // search
            // 
            this.search.BorderRadius = 8;
            this.search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.search.DefaultText = "";
            this.search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.search.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.Color.Black;
            this.search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.search.Location = new System.Drawing.Point(700, 61);
            this.search.Margin = new System.Windows.Forms.Padding(2);
            this.search.Name = "search";
            this.search.PasswordChar = '\0';
            this.search.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.search.PlaceholderText = "Nhập vào thông tin cần tìm kiếm ...";
            this.search.SelectedText = "";
            this.search.Size = new System.Drawing.Size(320, 47);
            this.search.TabIndex = 132;
            // 
            // btnExportFile
            // 
            this.btnExportFile.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportFile.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.btnExportFile.IconColor = System.Drawing.Color.Black;
            this.btnExportFile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExportFile.IconSize = 30;
            this.btnExportFile.Location = new System.Drawing.Point(1035, 61);
            this.btnExportFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExportFile.Name = "btnExportFile";
            this.btnExportFile.Size = new System.Drawing.Size(148, 47);
            this.btnExportFile.TabIndex = 131;
            this.btnExportFile.Text = "Xuất file";
            this.btnExportFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportFile.UseVisualStyleBackColor = true;
            this.btnExportFile.Click += new System.EventHandler(this.btnExportFile_Click);
            // 
            // ThongKeChuyenNganh
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1195, 791);
            this.ControlBox = false;
            this.Controls.Add(this.search);
            this.Controls.Add(this.btnExportFile);
            this.Controls.Add(this.lbSL);
            this.Controls.Add(this.soluong);
            this.Controls.Add(this.dataTK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbnganh);
            this.Name = "ThongKeChuyenNganh";
            this.Text = "ThongKeChuyenNganh";
            this.Load += new System.EventHandler(this.ThongKeChuyenNganh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbnganh;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaDataGridView dataTK;
        private System.Windows.Forms.Label lbSL;
        private System.Windows.Forms.Label soluong;
        private Guna.UI2.WinForms.Guna2TextBox search;
        private FontAwesome.Sharp.IconButton btnExportFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}