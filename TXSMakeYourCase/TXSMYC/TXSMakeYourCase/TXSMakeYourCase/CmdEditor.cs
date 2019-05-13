using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TXSMakeYourCase
{
    public partial class CmdEditor : Form
    {
        public List<string> commandList = new List<string>();
        public List<string> operandAList = new List<string>();
        public List<string> operandBList = new List<string>();
        public CmdEditor()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void cb_command_TextUpdate(object sender, EventArgs e)
        {

        }

        private void UpdateOperandStatus(int opAStatus, int opBStatus)
        {
            cb_operand1.Items.Clear();
            cb_operand2.Items.Clear();
            operandAList.Clear();
            operandBList.Clear();

            switch (opAStatus)
            {
                case -1: tb_operand1.Visible = false; tb_operand1.ReadOnly = true; cb_operand1.Visible = true; cb_operand1.Enabled = false; break;
                case 0: tb_operand1.Visible = false; tb_operand1.ReadOnly = true; cb_operand1.Visible = true; cb_operand1.Enabled = true; break;
                case 1: tb_operand1.Visible = true; tb_operand1.ReadOnly = false; cb_operand1.Visible = false; cb_operand1.Enabled = false; break;
            }
            switch (opBStatus)
            {
                case -1: tb_operand2.Visible = false; tb_operand2.ReadOnly = true; cb_operand2.Visible = true; cb_operand2.Enabled = false; break;
                case 0: tb_operand2.Visible = false; tb_operand2.ReadOnly = true; cb_operand2.Visible = true; cb_operand2.Enabled = true; break;
                case 1: tb_operand2.Visible = true; tb_operand2.ReadOnly = false; cb_operand2.Visible = false; cb_operand2.Enabled = false; break;
            }
            
        }

        private void cb_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_command.SelectedItem = -1;
            cb_addAlternativeCondition.Enabled = false;
            cb_addAlternativeCondition.Checked = false;
            switch (cb_category.SelectedItem.ToString())
            {
                case "0: conditions": cb_command.Items.Clear(); commandList.Clear();
                    commandList.AddRange(new string[] { "00", "010.", "011.", "012.", "02", "04", "050.", "051.", "052.", "053." });
                    cb_addAlternativeCondition.Enabled = true;
                    if (dataGridView1.RowCount > dataGridView1.CurrentRow.Index + 1)
                        cb_addAlternativeCondition.Checked = (dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString() == "099.");
                    else
                        cb_addAlternativeCondition.Checked = false;
                    break;
                case "1: branches": cb_command.Items.Clear(); commandList.Clear();
                    cb_command.Items.AddRange(new object[2] { "text(#)=this_text", "text(#)=#" });
                    commandList.AddRange(new string[] { "10", "11" });
                    break;
            }
            UpdateCommandComboBox();
        }

        private void cb_command_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1[1, dataGridView1.CurrentCell.RowIndex].Value = commandList[cb_command.SelectedIndex];

            if (cb_command.SelectedIndex >= 0)
                UpdateFunctionDescription(commandList[cb_command.SelectedIndex]);



        }
        private void UpdateCommandComboBox()
        {
            foreach(string s in commandList)
            {
                switch (s)
                {
                    case "00":
                        cb_command.Items.Add("if(choice==#)"); break;
                    case "010.":
                        cb_command.Items.Add("if(presented==#)"); break;
                    case "011.":
                        cb_command.Items.Add("if(invalid==#)"); break;
                    case "012.":
                        cb_command.Items.Add("if(memorized==#)"); break;
                    case "02":
                        cb_command.Items.Add("if(objection==#)"); break;
                    case "04":
                        cb_command.Items.Add("if(expression==#)"); break;
                    case "050.":
                        cb_command.Items.Add("if(flag(#)==#)"); break;
                    case "051.":
                        cb_command.Items.Add("if(flag(#)<=#)"); break;
                    case "052.":
                        cb_command.Items.Add("if(flag(#)>=#)"); break;
                    case "053.":
                        cb_command.Items.Add("if(text_repetitions>=#)"); break;

                }
            }
        }

        private void UpdateFunctionDescription(string cmdGameCode)
        {
            switch (cmdGameCode)
            {
                case "00": tb_function.Text = "This condition is met, if the choice at the given index (operand 1) has been selected by the player. If the condition has been met, all the following commands will be executed that are contained in it."; break;
                case "010.": tb_function.Text = "This condition is met, if a piece of (sub-)evidence (operand 1) has been presented by the player. If the condition has been met, all the following commands will be executed that are contained in it."; break;
                case "011.": tb_function.Text = "This condition is met, if a piece of (sub-)evidence (operand 1) is invalidated. If the condition has been met, all the following commands will be executed that are contained in it."; break;
                case "012.": tb_function.Text = "This condition is met, if a specific dialogue text (operand 1) has been memorized by the player. If the condition has been met, all the following commands will be executed that are contained in it."; break;
                case "02": tb_function.Text = "This condition is met, if an objection has been raised by the player on specific grounds (operand 1). If the condition has been met, all the following commands will be executed that are contained in it."; break;

            }


        }

        public void TranslateIntoUserCode()
        {


        }



    }
}