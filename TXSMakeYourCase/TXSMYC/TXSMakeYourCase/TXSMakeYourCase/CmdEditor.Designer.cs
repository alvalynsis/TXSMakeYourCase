namespace TXSMakeYourCase
{
    partial class CmdEditor
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cms_addRow = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsti_insertCodeAbove = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsti_insertCodeBelow = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsti_removeCode = new System.Windows.Forms.ToolStripMenuItem();
            this.cb_category = new System.Windows.Forms.ComboBox();
            this.lb_category = new System.Windows.Forms.Label();
            this.cb_command = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_operand1 = new System.Windows.Forms.Label();
            this.cb_operand1 = new System.Windows.Forms.ComboBox();
            this.cb_addAlternativeCondition = new System.Windows.Forms.CheckBox();
            this.cmsti_moveCodeUp = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsti_moveCodeDown = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_operand2 = new System.Windows.Forms.Label();
            this.tb_operand2 = new System.Windows.Forms.TextBox();
            this.tb_operand1 = new System.Windows.Forms.TextBox();
            this.cb_operand2 = new System.Windows.Forms.ComboBox();
            this.clm_userCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_gameCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_function = new System.Windows.Forms.Label();
            this.tb_function = new System.Windows.Forms.TextBox();
            this.btn_saveAndClose = new System.Windows.Forms.Button();
            this.btn_quit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.cms_addRow.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_userCode,
            this.clm_gameCode});
            this.dataGridView1.ContextMenuStrip = this.cms_addRow;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(15, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(895, 310);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // cms_addRow
            // 
            this.cms_addRow.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsti_insertCodeAbove,
            this.cmsti_insertCodeBelow,
            this.cmsti_moveCodeUp,
            this.cmsti_moveCodeDown,
            this.cmsti_removeCode});
            this.cms_addRow.Name = "cms_addRow";
            this.cms_addRow.Size = new System.Drawing.Size(235, 114);
            // 
            // cmsti_insertCodeAbove
            // 
            this.cmsti_insertCodeAbove.Name = "cmsti_insertCodeAbove";
            this.cmsti_insertCodeAbove.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Up)));
            this.cmsti_insertCodeAbove.Size = new System.Drawing.Size(234, 22);
            this.cmsti_insertCodeAbove.Text = "Insert Code Above";
            // 
            // cmsti_insertCodeBelow
            // 
            this.cmsti_insertCodeBelow.Name = "cmsti_insertCodeBelow";
            this.cmsti_insertCodeBelow.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Down)));
            this.cmsti_insertCodeBelow.Size = new System.Drawing.Size(234, 22);
            this.cmsti_insertCodeBelow.Text = "Insert Code Below";
            // 
            // cmsti_removeCode
            // 
            this.cmsti_removeCode.Name = "cmsti_removeCode";
            this.cmsti_removeCode.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.cmsti_removeCode.Size = new System.Drawing.Size(234, 22);
            this.cmsti_removeCode.Text = "Remove Code";
            // 
            // cb_category
            // 
            this.cb_category.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cb_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_category.FormattingEnabled = true;
            this.cb_category.Items.AddRange(new object[] {
            "0: conditions",
            "1: branches",
            "2: presentables",
            "3: flags",
            "4: visuals",
            "5: sounds",
            "6: cmd storing"});
            this.cb_category.Location = new System.Drawing.Point(74, 331);
            this.cb_category.Name = "cb_category";
            this.cb_category.Size = new System.Drawing.Size(164, 23);
            this.cb_category.TabIndex = 1;
            this.cb_category.SelectedIndexChanged += new System.EventHandler(this.cb_category_SelectedIndexChanged);
            // 
            // lb_category
            // 
            this.lb_category.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lb_category.AutoSize = true;
            this.lb_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_category.Location = new System.Drawing.Point(11, 334);
            this.lb_category.Name = "lb_category";
            this.lb_category.Size = new System.Drawing.Size(56, 15);
            this.lb_category.TabIndex = 2;
            this.lb_category.Text = "category:";
            // 
            // cb_command
            // 
            this.cb_command.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cb_command.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_command.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_command.FormattingEnabled = true;
            this.cb_command.Location = new System.Drawing.Point(316, 331);
            this.cb_command.Name = "cb_command";
            this.cb_command.Size = new System.Drawing.Size(238, 23);
            this.cb_command.TabIndex = 3;
            this.cb_command.SelectedIndexChanged += new System.EventHandler(this.cb_command_SelectedIndexChanged);
            this.cb_command.TextUpdate += new System.EventHandler(this.cb_command_TextUpdate);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "command:";
            // 
            // lb_operand1
            // 
            this.lb_operand1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lb_operand1.AutoSize = true;
            this.lb_operand1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_operand1.Location = new System.Drawing.Point(560, 334);
            this.lb_operand1.Name = "lb_operand1";
            this.lb_operand1.Size = new System.Drawing.Size(66, 15);
            this.lb_operand1.TabIndex = 5;
            this.lb_operand1.Text = "operand 1:";
            // 
            // cb_operand1
            // 
            this.cb_operand1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cb_operand1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_operand1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_operand1.FormattingEnabled = true;
            this.cb_operand1.Items.AddRange(new object[] {
            "123456-autopsy report"});
            this.cb_operand1.Location = new System.Drawing.Point(634, 333);
            this.cb_operand1.Name = "cb_operand1";
            this.cb_operand1.Size = new System.Drawing.Size(276, 21);
            this.cb_operand1.TabIndex = 6;
            // 
            // cb_addAlternativeCondition
            // 
            this.cb_addAlternativeCondition.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cb_addAlternativeCondition.AutoSize = true;
            this.cb_addAlternativeCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_addAlternativeCondition.Location = new System.Drawing.Point(14, 363);
            this.cb_addAlternativeCondition.Name = "cb_addAlternativeCondition";
            this.cb_addAlternativeCondition.Size = new System.Drawing.Size(159, 19);
            this.cb_addAlternativeCondition.TabIndex = 7;
            this.cb_addAlternativeCondition.Text = "add alternative condition";
            this.cb_addAlternativeCondition.UseVisualStyleBackColor = true;
            // 
            // cmsti_moveCodeUp
            // 
            this.cmsti_moveCodeUp.Name = "cmsti_moveCodeUp";
            this.cmsti_moveCodeUp.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Up)));
            this.cmsti_moveCodeUp.Size = new System.Drawing.Size(234, 22);
            this.cmsti_moveCodeUp.Text = "Move Code Up";
            // 
            // cmsti_moveCodeDown
            // 
            this.cmsti_moveCodeDown.Name = "cmsti_moveCodeDown";
            this.cmsti_moveCodeDown.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Down)));
            this.cmsti_moveCodeDown.Size = new System.Drawing.Size(234, 22);
            this.cmsti_moveCodeDown.Text = "Move Code Down";
            // 
            // lbl_operand2
            // 
            this.lbl_operand2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_operand2.AutoSize = true;
            this.lbl_operand2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_operand2.Location = new System.Drawing.Point(560, 364);
            this.lbl_operand2.Name = "lbl_operand2";
            this.lbl_operand2.Size = new System.Drawing.Size(66, 15);
            this.lbl_operand2.TabIndex = 8;
            this.lbl_operand2.Text = "operand 2:";
            // 
            // tb_operand2
            // 
            this.tb_operand2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tb_operand2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_operand2.Location = new System.Drawing.Point(634, 363);
            this.tb_operand2.Name = "tb_operand2";
            this.tb_operand2.Size = new System.Drawing.Size(276, 20);
            this.tb_operand2.TabIndex = 9;
            // 
            // tb_operand1
            // 
            this.tb_operand1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tb_operand1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_operand1.Location = new System.Drawing.Point(634, 331);
            this.tb_operand1.Name = "tb_operand1";
            this.tb_operand1.Size = new System.Drawing.Size(276, 21);
            this.tb_operand1.TabIndex = 10;
            // 
            // cb_operand2
            // 
            this.cb_operand2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cb_operand2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_operand2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_operand2.FormattingEnabled = true;
            this.cb_operand2.Location = new System.Drawing.Point(634, 361);
            this.cb_operand2.Name = "cb_operand2";
            this.cb_operand2.Size = new System.Drawing.Size(276, 23);
            this.cb_operand2.TabIndex = 11;
            // 
            // clm_userCode
            // 
            this.clm_userCode.HeaderText = "user code:";
            this.clm_userCode.Name = "clm_userCode";
            this.clm_userCode.ReadOnly = true;
            this.clm_userCode.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clm_userCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clm_userCode.Width = 550;
            // 
            // clm_gameCode
            // 
            this.clm_gameCode.HeaderText = "game code:";
            this.clm_gameCode.Name = "clm_gameCode";
            this.clm_gameCode.ReadOnly = true;
            this.clm_gameCode.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clm_gameCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clm_gameCode.Width = 350;
            // 
            // lbl_function
            // 
            this.lbl_function.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_function.AutoSize = true;
            this.lbl_function.Location = new System.Drawing.Point(14, 398);
            this.lbl_function.Name = "lbl_function";
            this.lbl_function.Size = new System.Drawing.Size(53, 15);
            this.lbl_function.TabIndex = 12;
            this.lbl_function.Text = "function:";
            // 
            // tb_function
            // 
            this.tb_function.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tb_function.Location = new System.Drawing.Point(17, 416);
            this.tb_function.Multiline = true;
            this.tb_function.Name = "tb_function";
            this.tb_function.ReadOnly = true;
            this.tb_function.Size = new System.Drawing.Size(894, 88);
            this.tb_function.TabIndex = 13;
            // 
            // btn_saveAndClose
            // 
            this.btn_saveAndClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_saveAndClose.Location = new System.Drawing.Point(794, 510);
            this.btn_saveAndClose.Name = "btn_saveAndClose";
            this.btn_saveAndClose.Size = new System.Drawing.Size(116, 23);
            this.btn_saveAndClose.TabIndex = 14;
            this.btn_saveAndClose.Text = "save and close";
            this.btn_saveAndClose.UseVisualStyleBackColor = true;
            // 
            // btn_quit
            // 
            this.btn_quit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_quit.Location = new System.Drawing.Point(672, 510);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(116, 23);
            this.btn_quit.TabIndex = 15;
            this.btn_quit.Text = "quit";
            this.btn_quit.UseVisualStyleBackColor = true;
            // 
            // CmdEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 545);
            this.Controls.Add(this.btn_quit);
            this.Controls.Add(this.btn_saveAndClose);
            this.Controls.Add(this.tb_function);
            this.Controls.Add(this.lbl_function);
            this.Controls.Add(this.tb_operand1);
            this.Controls.Add(this.tb_operand2);
            this.Controls.Add(this.lbl_operand2);
            this.Controls.Add(this.cb_addAlternativeCondition);
            this.Controls.Add(this.cb_operand1);
            this.Controls.Add(this.lb_operand1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_command);
            this.Controls.Add(this.lb_category);
            this.Controls.Add(this.cb_category);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cb_operand2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumSize = new System.Drawing.Size(940, 1300);
            this.MinimumSize = new System.Drawing.Size(940, 449);
            this.Name = "CmdEditor";
            this.Text = "CmdEditor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.cms_addRow.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cb_category;
        private System.Windows.Forms.Label lb_category;
        private System.Windows.Forms.ComboBox cb_command;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_operand1;
        private System.Windows.Forms.ComboBox cb_operand1;
        private System.Windows.Forms.CheckBox cb_addAlternativeCondition;
        private System.Windows.Forms.ContextMenuStrip cms_addRow;
        private System.Windows.Forms.ToolStripMenuItem cmsti_insertCodeAbove;
        private System.Windows.Forms.ToolStripMenuItem cmsti_insertCodeBelow;
        private System.Windows.Forms.ToolStripMenuItem cmsti_removeCode;
        private System.Windows.Forms.ToolStripMenuItem cmsti_moveCodeUp;
        private System.Windows.Forms.ToolStripMenuItem cmsti_moveCodeDown;
        private System.Windows.Forms.Label lbl_operand2;
        private System.Windows.Forms.TextBox tb_operand2;
        private System.Windows.Forms.TextBox tb_operand1;
        private System.Windows.Forms.ComboBox cb_operand2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_userCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_gameCode;
        private System.Windows.Forms.Label lbl_function;
        private System.Windows.Forms.TextBox tb_function;
        private System.Windows.Forms.Button btn_saveAndClose;
        private System.Windows.Forms.Button btn_quit;
    }
}