namespace TXSMakeYourCase
{
    partial class FlagEditor
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
            this.dgv_flags = new System.Windows.Forms.DataGridView();
            this.clm_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_flagName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_numeralSystem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_startingValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_timerType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_incrementTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_flags)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_flags
            // 
            this.dgv_flags.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_flags.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_ID,
            this.clm_flagName,
            this.clm_numeralSystem,
            this.clm_startingValue,
            this.clm_timerType,
            this.clm_incrementTime});
            this.dgv_flags.Location = new System.Drawing.Point(12, 12);
            this.dgv_flags.Name = "dgv_flags";
            this.dgv_flags.RowHeadersVisible = false;
            this.dgv_flags.Size = new System.Drawing.Size(607, 293);
            this.dgv_flags.TabIndex = 0;
            // 
            // clm_ID
            // 
            this.clm_ID.HeaderText = "flag-ID";
            this.clm_ID.Name = "clm_ID";
            this.clm_ID.ReadOnly = true;
            this.clm_ID.Width = 55;
            // 
            // clm_flagName
            // 
            this.clm_flagName.HeaderText = "flag name";
            this.clm_flagName.Name = "clm_flagName";
            this.clm_flagName.ReadOnly = true;
            this.clm_flagName.Width = 250;
            // 
            // clm_numeralSystem
            // 
            this.clm_numeralSystem.HeaderText = "numeral system";
            this.clm_numeralSystem.Name = "clm_numeralSystem";
            this.clm_numeralSystem.ReadOnly = true;
            this.clm_numeralSystem.Width = 80;
            // 
            // clm_startingValue
            // 
            this.clm_startingValue.HeaderText = "starting value";
            this.clm_startingValue.Name = "clm_startingValue";
            this.clm_startingValue.ReadOnly = true;
            this.clm_startingValue.Width = 60;
            // 
            // clm_timerType
            // 
            this.clm_timerType.HeaderText = "timer type";
            this.clm_timerType.Name = "clm_timerType";
            this.clm_timerType.ReadOnly = true;
            this.clm_timerType.Width = 70;
            // 
            // clm_incrementTime
            // 
            this.clm_incrementTime.HeaderText = "increment time";
            this.clm_incrementTime.Name = "clm_incrementTime";
            this.clm_incrementTime.ReadOnly = true;
            this.clm_incrementTime.Width = 70;
            // 
            // FlagEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 456);
            this.Controls.Add(this.dgv_flags);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FlagEditor";
            this.Text = "FlagEditor";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_flags)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_flags;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_flagName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_numeralSystem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_startingValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_timerType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_incrementTime;
    }
}