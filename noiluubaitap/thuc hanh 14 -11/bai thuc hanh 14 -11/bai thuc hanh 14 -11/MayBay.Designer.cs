﻿namespace bai_thuc_hanh_14__11
{
    partial class MayBay
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
            this.dataGridViewMayBay = new System.Windows.Forms.DataGridView();
            this.btnReload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMayBay)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMayBay
            // 
            this.dataGridViewMayBay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMayBay.Location = new System.Drawing.Point(11, 10);
            this.dataGridViewMayBay.Name = "dataGridViewMayBay";
            this.dataGridViewMayBay.RowHeadersWidth = 51;
            this.dataGridViewMayBay.RowTemplate.Height = 24;
            this.dataGridViewMayBay.Size = new System.Drawing.Size(786, 324);
            this.dataGridViewMayBay.TabIndex = 0;
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(274, 377);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(216, 47);
            this.btnReload.TabIndex = 2;
            this.btnReload.Text = "load";
            this.btnReload.UseVisualStyleBackColor = true;
            // 
            // MayBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.dataGridViewMayBay);
            this.Name = "MayBay";
            this.Text = "MayBay";
            this.Load += new System.EventHandler(this.MayBay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMayBay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMayBay;
        private System.Windows.Forms.Button btnReload;
    }
}

