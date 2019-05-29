namespace TXSMakeYourCase
{
    partial class MechanicsEditor
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
            this.tab_ctrl = new System.Windows.Forms.TabControl();
            this.tab_presentables = new System.Windows.Forms.TabPage();
            this.tab_qstObjections = new System.Windows.Forms.TabPage();
            this.tab_ansObjections = new System.Windows.Forms.TabPage();
            this.tab_expressions = new System.Windows.Forms.TabPage();
            this.tab_memorization = new System.Windows.Forms.TabPage();
            this.tab_jury = new System.Windows.Forms.TabPage();
            this.tab_time = new System.Windows.Forms.TabPage();
            this.dgv_presentableCategories = new System.Windows.Forms.DataGridView();
            this.clm_CategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Categoryname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_categoryName = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_categoryName = new System.Windows.Forms.Label();
            this.cb_pd_qstCrossExamination = new System.Windows.Forms.CheckBox();
            this.lbl_presentableDuring = new System.Windows.Forms.Label();
            this.cb_pd_ansCrossExamination = new System.Windows.Forms.CheckBox();
            this.cb_defaultPresentablePrompt = new System.Windows.Forms.CheckBox();
            this.tab_ctrl.SuspendLayout();
            this.tab_presentables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_presentableCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_ctrl
            // 
            this.tab_ctrl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab_ctrl.Controls.Add(this.tab_presentables);
            this.tab_ctrl.Controls.Add(this.tab_qstObjections);
            this.tab_ctrl.Controls.Add(this.tab_ansObjections);
            this.tab_ctrl.Controls.Add(this.tab_expressions);
            this.tab_ctrl.Controls.Add(this.tab_memorization);
            this.tab_ctrl.Controls.Add(this.tab_jury);
            this.tab_ctrl.Controls.Add(this.tab_time);
            this.tab_ctrl.Location = new System.Drawing.Point(0, 0);
            this.tab_ctrl.Name = "tab_ctrl";
            this.tab_ctrl.SelectedIndex = 0;
            this.tab_ctrl.Size = new System.Drawing.Size(686, 316);
            this.tab_ctrl.TabIndex = 0;
            // 
            // tab_presentables
            // 
            this.tab_presentables.Controls.Add(this.cb_defaultPresentablePrompt);
            this.tab_presentables.Controls.Add(this.cb_pd_ansCrossExamination);
            this.tab_presentables.Controls.Add(this.lbl_presentableDuring);
            this.tab_presentables.Controls.Add(this.cb_pd_qstCrossExamination);
            this.tab_presentables.Controls.Add(this.lbl_categoryName);
            this.tab_presentables.Controls.Add(this.tb_categoryName);
            this.tab_presentables.Controls.Add(this.dgv_presentableCategories);
            this.tab_presentables.Location = new System.Drawing.Point(4, 24);
            this.tab_presentables.Name = "tab_presentables";
            this.tab_presentables.Padding = new System.Windows.Forms.Padding(3);
            this.tab_presentables.Size = new System.Drawing.Size(678, 288);
            this.tab_presentables.TabIndex = 0;
            this.tab_presentables.Text = "Presentables";
            this.tab_presentables.UseVisualStyleBackColor = true;
            // 
            // tab_qstObjections
            // 
            this.tab_qstObjections.Location = new System.Drawing.Point(4, 24);
            this.tab_qstObjections.Name = "tab_qstObjections";
            this.tab_qstObjections.Padding = new System.Windows.Forms.Padding(3);
            this.tab_qstObjections.Size = new System.Drawing.Size(678, 310);
            this.tab_qstObjections.TabIndex = 1;
            this.tab_qstObjections.Text = "Objections (questions)";
            this.tab_qstObjections.UseVisualStyleBackColor = true;
            // 
            // tab_ansObjections
            // 
            this.tab_ansObjections.Location = new System.Drawing.Point(4, 24);
            this.tab_ansObjections.Name = "tab_ansObjections";
            this.tab_ansObjections.Padding = new System.Windows.Forms.Padding(3);
            this.tab_ansObjections.Size = new System.Drawing.Size(678, 310);
            this.tab_ansObjections.TabIndex = 2;
            this.tab_ansObjections.Text = "Objections (answers)";
            this.tab_ansObjections.UseVisualStyleBackColor = true;
            // 
            // tab_expressions
            // 
            this.tab_expressions.Location = new System.Drawing.Point(4, 24);
            this.tab_expressions.Name = "tab_expressions";
            this.tab_expressions.Padding = new System.Windows.Forms.Padding(3);
            this.tab_expressions.Size = new System.Drawing.Size(678, 310);
            this.tab_expressions.TabIndex = 3;
            this.tab_expressions.Text = "Expressions";
            this.tab_expressions.UseVisualStyleBackColor = true;
            // 
            // tab_memorization
            // 
            this.tab_memorization.Location = new System.Drawing.Point(4, 24);
            this.tab_memorization.Name = "tab_memorization";
            this.tab_memorization.Padding = new System.Windows.Forms.Padding(3);
            this.tab_memorization.Size = new System.Drawing.Size(678, 310);
            this.tab_memorization.TabIndex = 4;
            this.tab_memorization.Text = "Memorization";
            this.tab_memorization.UseVisualStyleBackColor = true;
            // 
            // tab_jury
            // 
            this.tab_jury.Location = new System.Drawing.Point(4, 24);
            this.tab_jury.Name = "tab_jury";
            this.tab_jury.Padding = new System.Windows.Forms.Padding(3);
            this.tab_jury.Size = new System.Drawing.Size(678, 310);
            this.tab_jury.TabIndex = 5;
            this.tab_jury.Text = "Jury";
            this.tab_jury.UseVisualStyleBackColor = true;
            // 
            // tab_time
            // 
            this.tab_time.Location = new System.Drawing.Point(4, 24);
            this.tab_time.Name = "tab_time";
            this.tab_time.Padding = new System.Windows.Forms.Padding(3);
            this.tab_time.Size = new System.Drawing.Size(678, 310);
            this.tab_time.TabIndex = 6;
            this.tab_time.Text = "Time";
            this.tab_time.UseVisualStyleBackColor = true;
            // 
            // dgv_presentableCategories
            // 
            this.dgv_presentableCategories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgv_presentableCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_presentableCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_CategoryID,
            this.clm_Categoryname});
            this.dgv_presentableCategories.Location = new System.Drawing.Point(8, 6);
            this.dgv_presentableCategories.Name = "dgv_presentableCategories";
            this.dgv_presentableCategories.RowHeadersVisible = false;
            this.dgv_presentableCategories.Size = new System.Drawing.Size(661, 188);
            this.dgv_presentableCategories.TabIndex = 0;
            // 
            // clm_CategoryID
            // 
            this.clm_CategoryID.HeaderText = "ID";
            this.clm_CategoryID.Name = "clm_CategoryID";
            this.clm_CategoryID.ReadOnly = true;
            this.clm_CategoryID.Width = 25;
            // 
            // clm_Categoryname
            // 
            this.clm_Categoryname.HeaderText = "Category name";
            this.clm_Categoryname.Name = "clm_Categoryname";
            this.clm_Categoryname.ReadOnly = true;
            this.clm_Categoryname.Width = 200;
            // 
            // tb_categoryName
            // 
            this.tb_categoryName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_categoryName.Location = new System.Drawing.Point(58, 200);
            this.tb_categoryName.Name = "tb_categoryName";
            this.tb_categoryName.Size = new System.Drawing.Size(174, 21);
            this.tb_categoryName.TabIndex = 1;
            // 
            // btn_save
            // 
            this.btn_save.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_save.Location = new System.Drawing.Point(561, 322);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(112, 23);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "save";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_cancel.Location = new System.Drawing.Point(449, 322);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(106, 23);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // lbl_categoryName
            // 
            this.lbl_categoryName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_categoryName.AutoSize = true;
            this.lbl_categoryName.Location = new System.Drawing.Point(8, 203);
            this.lbl_categoryName.Name = "lbl_categoryName";
            this.lbl_categoryName.Size = new System.Drawing.Size(44, 15);
            this.lbl_categoryName.TabIndex = 2;
            this.lbl_categoryName.Text = "Name:";
            // 
            // cb_pd_qstCrossExamination
            // 
            this.cb_pd_qstCrossExamination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cb_pd_qstCrossExamination.AutoSize = true;
            this.cb_pd_qstCrossExamination.Location = new System.Drawing.Point(11, 242);
            this.cb_pd_qstCrossExamination.Name = "cb_pd_qstCrossExamination";
            this.cb_pd_qstCrossExamination.Size = new System.Drawing.Size(195, 19);
            this.cb_pd_qstCrossExamination.TabIndex = 3;
            this.cb_pd_qstCrossExamination.Text = "Cross Examination (Questions)";
            this.cb_pd_qstCrossExamination.UseVisualStyleBackColor = true;
            // 
            // lbl_presentableDuring
            // 
            this.lbl_presentableDuring.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_presentableDuring.AutoSize = true;
            this.lbl_presentableDuring.Location = new System.Drawing.Point(8, 224);
            this.lbl_presentableDuring.Name = "lbl_presentableDuring";
            this.lbl_presentableDuring.Size = new System.Drawing.Size(113, 15);
            this.lbl_presentableDuring.TabIndex = 4;
            this.lbl_presentableDuring.Text = "presentable during:";
            // 
            // cb_pd_ansCrossExamination
            // 
            this.cb_pd_ansCrossExamination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cb_pd_ansCrossExamination.AutoSize = true;
            this.cb_pd_ansCrossExamination.Location = new System.Drawing.Point(212, 242);
            this.cb_pd_ansCrossExamination.Name = "cb_pd_ansCrossExamination";
            this.cb_pd_ansCrossExamination.Size = new System.Drawing.Size(186, 19);
            this.cb_pd_ansCrossExamination.TabIndex = 5;
            this.cb_pd_ansCrossExamination.Text = "Cross Examination (Answers)";
            this.cb_pd_ansCrossExamination.UseVisualStyleBackColor = true;
            // 
            // cb_defaultPresentablePrompt
            // 
            this.cb_defaultPresentablePrompt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cb_defaultPresentablePrompt.AutoSize = true;
            this.cb_defaultPresentablePrompt.Location = new System.Drawing.Point(404, 242);
            this.cb_defaultPresentablePrompt.Name = "cb_defaultPresentablePrompt";
            this.cb_defaultPresentablePrompt.Size = new System.Drawing.Size(177, 19);
            this.cb_defaultPresentablePrompt.TabIndex = 6;
            this.cb_defaultPresentablePrompt.Text = "Default Presentable Prompt";
            this.cb_defaultPresentablePrompt.UseVisualStyleBackColor = true;
            // 
            // MechanicsEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 355);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.tab_ctrl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MechanicsEditor";
            this.Text = "MechanicsEditor";
            this.tab_ctrl.ResumeLayout(false);
            this.tab_presentables.ResumeLayout(false);
            this.tab_presentables.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_presentableCategories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_ctrl;
        private System.Windows.Forms.TabPage tab_presentables;
        private System.Windows.Forms.TabPage tab_qstObjections;
        private System.Windows.Forms.TabPage tab_ansObjections;
        private System.Windows.Forms.TabPage tab_expressions;
        private System.Windows.Forms.TabPage tab_memorization;
        private System.Windows.Forms.TabPage tab_jury;
        private System.Windows.Forms.TabPage tab_time;
        private System.Windows.Forms.DataGridView dgv_presentableCategories;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_CategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Categoryname;
        private System.Windows.Forms.TextBox tb_categoryName;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_categoryName;
        private System.Windows.Forms.Label lbl_presentableDuring;
        private System.Windows.Forms.CheckBox cb_pd_qstCrossExamination;
        private System.Windows.Forms.CheckBox cb_pd_ansCrossExamination;
        private System.Windows.Forms.CheckBox cb_defaultPresentablePrompt;
    }
}