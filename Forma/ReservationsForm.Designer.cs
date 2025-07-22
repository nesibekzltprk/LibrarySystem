namespace Forma
{
    partial class ReservationsForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewReser = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReser)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(387, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGridViewReser
            // 
            this.dataGridViewReser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewReser.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewReser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReser.Location = new System.Drawing.Point(109, 82);
            this.dataGridViewReser.Name = "dataGridViewReser";
            this.dataGridViewReser.Size = new System.Drawing.Size(584, 262);
            this.dataGridViewReser.TabIndex = 1;
            this.dataGridViewReser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReser_CellContentClick);
            // 
            // ReservationsForm
            // 
            this.ClientSize = new System.Drawing.Size(811, 436);
            this.Controls.Add(this.dataGridViewReser);
            this.Controls.Add(this.label2);
            this.Name = "ReservationsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewReser;
    }
}