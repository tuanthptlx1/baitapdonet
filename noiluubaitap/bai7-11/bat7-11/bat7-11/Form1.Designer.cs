namespace SimThe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvSim = new DataGridView();
            dgvMang = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSim).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMang).BeginInit();
            SuspendLayout();
            // 
            // dgvSim
            // 
            dgvSim.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSim.Location = new Point(12, 12);
            dgvSim.Name = "dgvSim";
            dgvSim.RowHeadersWidth = 51;
            dgvSim.Size = new Size(600, 583);
            dgvSim.TabIndex = 0;
            // 
            // dgvMang
            // 
            dgvMang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMang.Location = new Point(1089, 12);
            dgvMang.Name = "dgvMang";
            dgvMang.RowHeadersWidth = 51;
            dgvMang.Size = new Size(255, 583);
            dgvMang.TabIndex = 1;
            dgvMang.CellContentClick += dgvMang_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(32, 629);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Load";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1407, 727);
            Controls.Add(button1);
            Controls.Add(dgvMang);
            Controls.Add(dgvSim);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvSim).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMang).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvSim;
        private DataGridView dgvMang;
        private Button button1;
    }
}
