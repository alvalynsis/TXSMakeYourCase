namespace TXSMakeYourCase
{
    partial class TextEditor
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
            this.cb_textType = new System.Windows.Forms.ComboBox();
            this.lb_textType = new System.Windows.Forms.Label();
            this.lb_character = new System.Windows.Forms.Label();
            this.cb_character = new System.Windows.Forms.ComboBox();
            this.tb_textID = new System.Windows.Forms.TextBox();
            this.lb_textID = new System.Windows.Forms.Label();
            this.lb_tags = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_saveAndClose = new System.Windows.Forms.Button();
            this.lb_text = new System.Windows.Forms.Label();
            this.tb_text = new System.Windows.Forms.TextBox();
            this.btn_saveAndNext = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.cb_splitText = new System.Windows.Forms.CheckBox();
            this.tb_choices = new System.Windows.Forms.TextBox();
            this.lb_choices = new System.Windows.Forms.Label();
            this.lb_userCommands = new System.Windows.Forms.Label();
            this.tb_commands = new System.Windows.Forms.TextBox();
            this.btn_editWithCmdEditor = new System.Windows.Forms.Button();
            this.rb_userCode = new System.Windows.Forms.RadioButton();
            this.rb_gameCode = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // cb_textType
            // 
            this.cb_textType.FormattingEnabled = true;
            this.cb_textType.Items.AddRange(new object[] {
            "normal text",
            "multiple choice text",
            "evidence prompt text",
            "opposition cross-x text",
            "player subject text",
            "player question text",
            "witness testimony text"});
            this.cb_textType.Location = new System.Drawing.Point(89, 20);
            this.cb_textType.Name = "cb_textType";
            this.cb_textType.Size = new System.Drawing.Size(185, 23);
            this.cb_textType.TabIndex = 0;
            // 
            // lb_textType
            // 
            this.lb_textType.AutoSize = true;
            this.lb_textType.Location = new System.Drawing.Point(14, 23);
            this.lb_textType.Name = "lb_textType";
            this.lb_textType.Size = new System.Drawing.Size(62, 15);
            this.lb_textType.TabIndex = 1;
            this.lb_textType.Text = "Text Type:";
            // 
            // lb_character
            // 
            this.lb_character.AutoSize = true;
            this.lb_character.Location = new System.Drawing.Point(324, 23);
            this.lb_character.Name = "lb_character";
            this.lb_character.Size = new System.Drawing.Size(63, 15);
            this.lb_character.TabIndex = 3;
            this.lb_character.Text = "Character:";
            // 
            // cb_character
            // 
            this.cb_character.FormattingEnabled = true;
            this.cb_character.Location = new System.Drawing.Point(397, 20);
            this.cb_character.Name = "cb_character";
            this.cb_character.Size = new System.Drawing.Size(300, 23);
            this.cb_character.TabIndex = 2;
            // 
            // tb_textID
            // 
            this.tb_textID.Location = new System.Drawing.Point(17, 83);
            this.tb_textID.Name = "tb_textID";
            this.tb_textID.Size = new System.Drawing.Size(144, 21);
            this.tb_textID.TabIndex = 4;
            // 
            // lb_textID
            // 
            this.lb_textID.AutoSize = true;
            this.lb_textID.Location = new System.Drawing.Point(14, 65);
            this.lb_textID.Name = "lb_textID";
            this.lb_textID.Size = new System.Drawing.Size(48, 15);
            this.lb_textID.TabIndex = 5;
            this.lb_textID.Text = "Text ID:";
            // 
            // lb_tags
            // 
            this.lb_tags.AutoSize = true;
            this.lb_tags.Location = new System.Drawing.Point(166, 65);
            this.lb_tags.Name = "lb_tags";
            this.lb_tags.Size = new System.Drawing.Size(37, 15);
            this.lb_tags.TabIndex = 7;
            this.lb_tags.Text = "Tags:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(169, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(528, 21);
            this.textBox1.TabIndex = 6;
            // 
            // btn_saveAndClose
            // 
            this.btn_saveAndClose.Location = new System.Drawing.Point(546, 637);
            this.btn_saveAndClose.Name = "btn_saveAndClose";
            this.btn_saveAndClose.Size = new System.Drawing.Size(152, 27);
            this.btn_saveAndClose.TabIndex = 8;
            this.btn_saveAndClose.Text = "Save and Close";
            this.btn_saveAndClose.UseVisualStyleBackColor = true;
            // 
            // lb_text
            // 
            this.lb_text.AutoSize = true;
            this.lb_text.Location = new System.Drawing.Point(17, 134);
            this.lb_text.Name = "lb_text";
            this.lb_text.Size = new System.Drawing.Size(33, 15);
            this.lb_text.TabIndex = 9;
            this.lb_text.Text = "Text:";
            // 
            // tb_text
            // 
            this.tb_text.Location = new System.Drawing.Point(21, 153);
            this.tb_text.Multiline = true;
            this.tb_text.Name = "tb_text";
            this.tb_text.Size = new System.Drawing.Size(676, 106);
            this.tb_text.TabIndex = 10;
            this.tb_text.Text = "Why would you say that lorem ipsum gay shit man";
            // 
            // btn_saveAndNext
            // 
            this.btn_saveAndNext.Location = new System.Drawing.Point(387, 637);
            this.btn_saveAndNext.Name = "btn_saveAndNext";
            this.btn_saveAndNext.Size = new System.Drawing.Size(152, 27);
            this.btn_saveAndNext.TabIndex = 11;
            this.btn_saveAndNext.Text = "Save and Next";
            this.btn_saveAndNext.UseVisualStyleBackColor = true;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(229, 637);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(152, 27);
            this.btn_Save.TabIndex = 12;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            // 
            // cb_splitText
            // 
            this.cb_splitText.AutoSize = true;
            this.cb_splitText.Location = new System.Drawing.Point(420, 133);
            this.cb_splitText.Name = "cb_splitText";
            this.cb_splitText.Size = new System.Drawing.Size(262, 19);
            this.cb_splitText.TabIndex = 13;
            this.cb_splitText.Text = "Split Into Multiple DlgTexts (if limit reached)";
            this.cb_splitText.UseVisualStyleBackColor = true;
            // 
            // tb_choices
            // 
            this.tb_choices.Location = new System.Drawing.Point(21, 294);
            this.tb_choices.Multiline = true;
            this.tb_choices.Name = "tb_choices";
            this.tb_choices.Size = new System.Drawing.Size(676, 104);
            this.tb_choices.TabIndex = 14;
            this.tb_choices.Text = "Why would you say that lorem ipsum gay shit man";
            // 
            // lb_choices
            // 
            this.lb_choices.AutoSize = true;
            this.lb_choices.Location = new System.Drawing.Point(17, 276);
            this.lb_choices.Name = "lb_choices";
            this.lb_choices.Size = new System.Drawing.Size(54, 15);
            this.lb_choices.TabIndex = 15;
            this.lb_choices.Text = "Choices:";
            // 
            // lb_userCommands
            // 
            this.lb_userCommands.AutoSize = true;
            this.lb_userCommands.Location = new System.Drawing.Point(17, 417);
            this.lb_userCommands.Name = "lb_userCommands";
            this.lb_userCommands.Size = new System.Drawing.Size(71, 15);
            this.lb_userCommands.TabIndex = 17;
            this.lb_userCommands.Text = "Commands";
            // 
            // tb_commands
            // 
            this.tb_commands.Location = new System.Drawing.Point(21, 435);
            this.tb_commands.Multiline = true;
            this.tb_commands.Name = "tb_commands";
            this.tb_commands.Size = new System.Drawing.Size(676, 71);
            this.tb_commands.TabIndex = 16;
            this.tb_commands.Text = "Why would you say that lorem ipsum gay shit man";
            // 
            // btn_editWithCmdEditor
            // 
            this.btn_editWithCmdEditor.Location = new System.Drawing.Point(21, 513);
            this.btn_editWithCmdEditor.Name = "btn_editWithCmdEditor";
            this.btn_editWithCmdEditor.Size = new System.Drawing.Size(152, 27);
            this.btn_editWithCmdEditor.TabIndex = 18;
            this.btn_editWithCmdEditor.Text = "edit with cmdEditor";
            this.btn_editWithCmdEditor.UseVisualStyleBackColor = true;
            this.btn_editWithCmdEditor.Click += new System.EventHandler(this.btn_editWithCmdEditor_Click);
            // 
            // rb_userCode
            // 
            this.rb_userCode.AutoSize = true;
            this.rb_userCode.Checked = true;
            this.rb_userCode.Location = new System.Drawing.Point(513, 414);
            this.rb_userCode.Name = "rb_userCode";
            this.rb_userCode.Size = new System.Drawing.Size(81, 19);
            this.rb_userCode.TabIndex = 19;
            this.rb_userCode.TabStop = true;
            this.rb_userCode.Text = "user Code";
            this.rb_userCode.UseVisualStyleBackColor = true;
            // 
            // rb_gameCode
            // 
            this.rb_gameCode.AutoSize = true;
            this.rb_gameCode.Location = new System.Drawing.Point(605, 414);
            this.rb_gameCode.Name = "rb_gameCode";
            this.rb_gameCode.Size = new System.Drawing.Size(89, 19);
            this.rb_gameCode.TabIndex = 20;
            this.rb_gameCode.Text = "game Code";
            this.rb_gameCode.UseVisualStyleBackColor = true;
            // 
            // TextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 677);
            this.Controls.Add(this.rb_gameCode);
            this.Controls.Add(this.rb_userCode);
            this.Controls.Add(this.btn_editWithCmdEditor);
            this.Controls.Add(this.lb_userCommands);
            this.Controls.Add(this.tb_commands);
            this.Controls.Add(this.lb_choices);
            this.Controls.Add(this.tb_choices);
            this.Controls.Add(this.cb_splitText);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_saveAndNext);
            this.Controls.Add(this.tb_text);
            this.Controls.Add(this.lb_text);
            this.Controls.Add(this.btn_saveAndClose);
            this.Controls.Add(this.lb_tags);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lb_textID);
            this.Controls.Add(this.tb_textID);
            this.Controls.Add(this.lb_character);
            this.Controls.Add(this.cb_character);
            this.Controls.Add(this.lb_textType);
            this.Controls.Add(this.cb_textType);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TextEditor";
            this.Text = "TextEditor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_textType;
        private System.Windows.Forms.Label lb_textType;
        private System.Windows.Forms.Label lb_character;
        private System.Windows.Forms.ComboBox cb_character;
        private System.Windows.Forms.TextBox tb_textID;
        private System.Windows.Forms.Label lb_textID;
        private System.Windows.Forms.Label lb_tags;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_saveAndClose;
        private System.Windows.Forms.Label lb_text;
        private System.Windows.Forms.TextBox tb_text;
        private System.Windows.Forms.Button btn_saveAndNext;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.CheckBox cb_splitText;
        private System.Windows.Forms.TextBox tb_choices;
        private System.Windows.Forms.Label lb_choices;
        private System.Windows.Forms.Label lb_userCommands;
        private System.Windows.Forms.TextBox tb_commands;
        private System.Windows.Forms.Button btn_editWithCmdEditor;
        private System.Windows.Forms.RadioButton rb_userCode;
        private System.Windows.Forms.RadioButton rb_gameCode;
    }
}