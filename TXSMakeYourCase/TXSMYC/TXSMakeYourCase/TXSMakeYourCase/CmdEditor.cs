using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TXSMakeYourCase
{
    public partial class CmdEditor : Form
    {
        public List<string> numberList = new List<string>();
        public Dictionary<string, string> cmdDictionary = new Dictionary<string, string>();

        public List<string> commandList = new List<string>();
        //operandArrayList for combobox -- Combobox,Usercode,Gamecode;
        public List<string[]> operandAList = new List<string[]>();
        public List<string[]> operandBList = new List<string[]>();
        //operandArray for textbox -- Text,Usercode,Gamecode;
        public string[] operandAArray = new string[3];
        public string[] operandBArray = new string[3];

        public Dictionary<int, int> openAndCloseDictionary = new Dictionary<int, int>();
        public List<Color> colorList;

        public CmdEditor()
        {
            InitializeComponent();
            numberList = CreateNumberList();
            cmdDictionary = CreateCmdDictionary();
        }

        private void CreateColorsList(List<Color> colorList)
        {
            colorList.Add(Color.Red);
            colorList.Add(Color.Green);
            colorList.Add(Color.Blue);
            colorList.Add(Color.Purple);
            colorList.Add(Color.Yellow);
            colorList.Add(Color.DarkOrange);
            colorList.Add(Color.DeepPink);
            colorList.Add(Color.DarkCyan);
        }

        private void dgv_cmd_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                FindCategory();
            }
            catch
            {
                cb_category.SelectedIndex = -1;
                cb_command.SelectedIndex = -1;
                return;
            }
            try
            {
                FindCommand();
            }
            catch
            {
                cb_command.SelectedIndex = -1;
            }

            try
            {
                List<string> operandList = FindOperands(dgv_cmd[1, dgv_cmd.CurrentRow.Index].Value.ToString(),
                    commandList[cb_command.SelectedIndex]);
            }
            catch
            {

            }

        }

        private void FindCategory()
        {
            cb_category.SelectedIndex =
                Convert.ToInt32(dgv_cmd[1, dgv_cmd.CurrentRow.Index].Value.ToString()[0].ToString());
            cb_category_SelectedIndexChanged(null, null);
        }

        private void FindCommand()
        {
            cb_command.SelectedIndex = -1;
            string cmd = (dgv_cmd[1, dgv_cmd.CurrentRow.Index].Value.ToString().Substring(0, 3));


            for (int i = 0; i < commandList.Count; i++)
            {
                if (commandList[i].Substring(0, 3) == cmd)
                {
                    cb_command.SelectedIndex = i;
                    return;
                }
            }
            cmd = (dgv_cmd[1, dgv_cmd.CurrentRow.Index].Value.ToString().Substring(0, 2));
            for (int i = 0; i < commandList.Count; i++)
            {
                if (commandList[i].Substring(0, 2) == cmd)
                {
                    cb_command.SelectedIndex = i;
                    return;
                }
            }
        }

        public List<string> FindOperands(string cmd, string cmdSyntax)
        {
            List<string> cmdStringList = new List<string>();
            bool operand = false;
            string opString = "";

            for (int i = 0; i < cmdSyntax.Length; i++)
            {
                if (cmdSyntax[i] == '#')
                {
                    opString += cmd[i].ToString();
                    operand = true;
                }

                if (cmdSyntax[i] != '#' && operand)
                {
                    operand = false;
                    cmdStringList.Add(opString);
                    opString = "";
                }
            }

            return cmdStringList;
        }

        public string InsertOperandsIntoGameCode(string cmd, string op1, string op2)
        {
            bool operand = false;
            string opString = op1;

            string cmdSyntax = GetGameCode(GetUserCode(cmd));
            

            for (int i = 0; i < cmdSyntax.Length; i++)
            {
                if (cmdSyntax[i] == '#')
                {
                    if (opString.Length > 0)
                    {
                        cmd = cmd.Substring(0, i) + opString[0] + cmd.Substring(i + 1, cmd.Length - i - 1);
                        opString = opString.Substring(1, opString.Length - 1);
                        operand = true;
                    }
                }

                if (cmdSyntax[i] != '#' && operand)
                {
                    operand = false;
                    opString = op2;
                }
            }

            return cmd;
        }

        

        private void cb_command_TextUpdate(object sender, EventArgs e)
        {

        }

        public bool CheckNewCodeSyntax(string gameCode)
        {

            return true;
        }

        

        private void cb_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_command.SelectedItem = -1;
            cb_addAlternativeCondition.Enabled = false;
            cb_addAlternativeCondition.Checked = false;
            cb_command.Items.Clear(); commandList.Clear();
            if (cb_category.SelectedIndex < 0)
                return;
            switch (cb_category.SelectedItem.ToString())
            {
                case "0: conditions":
                    foreach (var d in cmdDictionary)
                    {
                        if (d.Key[0].ToString() == "0")
                            commandList.Add(d.Key);
                    }
                    cb_addAlternativeCondition.Enabled = true;
                    try
                    {
                        cb_addAlternativeCondition.Checked =
                            (dgv_cmd[1, dgv_cmd.CurrentRow.Index].Value.ToString().Contains(".098"));
                    }
                    catch
                    {
                        cb_addAlternativeCondition.Checked = false;}

                    break;
                case "1: branches": 
                    cb_command.Items.AddRange(new object[2] { "text(#)=this_text", "text(#)=#" });
                    commandList.AddRange(new string[] { "10", "11" });
                    break;
            }
            UpdateCommandComboBox();
        }

        private void cb_command_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_command.SelectedIndex < 0)
                return;
            int i = dgv_cmd.CurrentCell.RowIndex;
            bool wasCondition = (dgv_cmd[1, i].Value != null && CheckIfCondition(dgv_cmd[1, i].Value.ToString()));

            dgv_cmd[1, dgv_cmd.CurrentCell.RowIndex].Value = commandList[cb_command.SelectedIndex];

            if (!wasCondition && (dgv_cmd[1, i].Value != null && CheckIfCondition(dgv_cmd[1, i].Value.ToString())))
            {
                if (i + 1 >= dgv_cmd.RowCount || !(CheckIfCondition(dgv_cmd[1, i + 1].Value.ToString()) || dgv_cmd[1, i + 1].Value == null || dgv_cmd[1, i + 1].Value.ToString() == ""))
                    cmsti_insertCodeBelow_Click(null, null);
                if (i > 0 && (CheckIfCondition(dgv_cmd[1, i - 1].Value.ToString()) || dgv_cmd[1, i - 1].Value.ToString() == "098."))
                {
                }
                else
                {
                    cmsti_insertCodeBelow_Click(null, null);
                    dgv_cmd[1, i + 2].Value = "099.";
                    dgv_cmd.CurrentCell = dgv_cmd[1, i];
                }
            }


            if (cb_command.SelectedIndex >= 0)
            {
                UpdateFunctionDescription(commandList[cb_command.SelectedIndex]);
                UpdateOperands(commandList[cb_command.SelectedIndex], true);
                operandAList = GetOperandList(commandList[cb_command.SelectedIndex], 0);
                operandBList = GetOperandList(commandList[cb_command.SelectedIndex], 1);
                operandAArray = GetOperandArray(commandList[cb_command.SelectedIndex], 0);
                operandBArray = GetOperandArray(commandList[cb_command.SelectedIndex], 1);
                FillOperandComboboxes();
            }


        }

        private List<string[]> GetOperandList(string gameCode, int operand)
        {
            var operandList = new List<string[]>();
            if (operand == 0)
            {
                switch (gameCode)
                {
                    case "00#.":
                    case "02#.":
                    case "03#.":
                        for (int i = 0; i < 10; i++)
                            operandList.Add(new string[3] { i.ToString(), i.ToString(), i.ToString() });
                        break;


                }

            }
            

            return operandList;
        }

        private string[] CompleteOperandArray(string gameCode, int operand, string[] operandArray)
        {
            if (operand == 0)
            {
                switch (gameCode)
                {

                }

            }



            return null;
        }


        public string[] GetOperandArray(string gameCode, int operand)
        {

            return null;
        }

        
        private void UpdateCommandComboBox()
        {
            foreach(string s in commandList)
            {
                cb_command.Items.Add(GetUserCode(s));


            }
        }

        static Dictionary<string, string> CreateCmdDictionary()
        {
            var dict = new Dictionary<string, string>();
            dict.Add("00#.", "if(choice==#)");
            dict.Add("010.######.", "if(presented==#)");
            dict.Add("011.######.", "if(invalid==#)");
            dict.Add("012.######.", "if(memorized==#)");
            dict.Add("02#.", "if(qst_objection==#)");
            dict.Add("03#.", "if(ans_objection==#)");
            dict.Add("04#.", "if(expression==#)");
            dict.Add("050.###.###.", "if(flag(#)==#)");
            dict.Add("051.###.###.", "if(flag(#)<=#)");
            dict.Add("052.###.###.", "if(flag(#)>=#)");
            dict.Add("053.###.", "if(text_repetitions>=#)");
            dict.Add("090.###.", "if(current_char_index==#)");
            dict.Add("091.###.", "if(current_word_index==#)");
            dict.Add("092.", "if(all_char_written)");
            dict.Add("093.###.", "if(char==#)");
            dict.Add("098.", "or");
            dict.Add("099.", "}");
            return dict;
        }

        private string GetUserCode(string s)
        {
            for (int i = 0; i < 3; i++)
            {
                foreach (var d in cmdDictionary)
                {
                    if (s == d.Key)
                    {
                        return d.Value;
                    }

                    try
                    {
                        if (i == 1 && s.Substring(0, 4) == d.Key.Substring(0, 4))
                        {
                            return d.Value;
                        }

                        if (i == 2 && s.Substring(0, 2) == d.Key.Substring(0, 2))
                        {
                            return d.Value;
                        }
                    }
                    catch
                    {
                    }
                }
            }

            return "";
        }

        private string GetGameCode(string s)
        {
            foreach (var d in cmdDictionary)
            {
                if (s.Replace("#", "") == d.Value.Replace("#", ""))
                    return d.Key;
            }

            return "";
        }

        private void UpdateFunctionDescription(string cmdGameCode)
        {
            switch (cmdGameCode)
            {
                //0
                case "00#.": tb_function.Text = "This condition is met, if the choice at the given index (operand 1) has been selected by the player. If the condition has been met, all the following commands will be executed that are contained in it."; break;
                case "010.######.": tb_function.Text = "This condition is met, if a (sub-)presentable (operand 1) has been presented by the player. Note that presenting a presentable will also present all unlocked sub-presentables. If the condition has been met, all the following commands will be executed that are contained in it."; break;
                case "011.######.": tb_function.Text = "This condition is met, if a (sub-)presentable (operand 1) is invalidated. If the condition has been met, all the following commands will be executed that are contained in it."; break;
                case "012.######.": tb_function.Text = "This condition is met, if a specific dialogue text (operand 1) has been memorized by the player. If the condition has been met, all the following commands will be executed that are contained in it."; break;
                case "02#.": tb_function.Text = "This condition is met, if an objection has been raised to a question by the player on specific grounds (operand 1). If the condition has been met, all the following commands will be executed that are contained in it."; break;
                case "03#.": tb_function.Text = "This condition is met, if an objection has been raised to an answer by the player on specific grounds (operand 1). If the condition has been met, all the following commands will be executed that are contained in it."; break;
                case "04#.": tb_function.Text = "This condition is met, if the current expression is set to operand 1. If the condition has been met, all the following commands will be executed that are contained in it."; break;
                case "050.###.###.": tb_function.Text = "This condition is met, if the flag(operand 1) is equal to operand 2 (Base10). If the condition has been met, all the following commands will be executed that are contained in it."; break;
                case "051.###.###.": tb_function.Text = "This condition is met, if the flag(operand 1) is equal to or lower than operand 2 (Base10). If the condition has been met, all the following commands will be executed that are contained in it."; break;
                case "052.###.###.": tb_function.Text = "This condition is met, if the flag(operand 1) is equal to or higher than operand 2 (Base10). If the condition has been met, all the following commands will be executed that are contained in it."; break;
                case "053.###.": tb_function.Text = "This condition is met, if the current dlg_text has been written more than operand 1 times. If the condition has been met, all the following commands will be executed that are contained in it."; break;
                //...
                case "090.###.": tb_function.Text = "This condition is met, if the index of the character that has been written is operand 1. If the condition has been met, all the following commands will be executed that are contained in it."; break;
                case "091.###.": tb_function.Text = "This condition is met, if the index of the word that has been written is operand 1. If the condition has been met, all the following commands will be executed that are contained in it."; break;
                case "092.": tb_function.Text = "This condition is met, if all characters have been written. If the condition has been met, all the following commands will be executed that are contained in it."; break;
                case "093.###.": tb_function.Text = "This condition is met, if the unicode id of the character that has been written is equal to operand 1 (1st digit ranges from 0 to z (62), 2nd and 3rd digit range from 0-Z (36). Note that you can only input the one symbol you are referring to into the text box. If the condition has been met, all the following commands will be executed that are contained in it."; break;
                    
            }
        }

        private int UpdateOperands(string cmdGameCode, bool updateInputFields)
        {

            switch (cmdGameCode)
            {
                case "00#.":
                case "010.######.":
                case "011.######.":
                case "02#.":
                case "03#.":
                case "04#.":
                    if (updateInputFields)
                        UpdateOperandStatus(0,-1);
                    break;

                case "012.######.":
                case "053.###.":
                case "090.###.":
                case "091.###.":
                case "093.###.":
                    if (updateInputFields)
                        UpdateOperandStatus(1, -1);
                    break;
                case "050.###.###.":
                case "051.###.###.":
                case "052.###.###.":
                    if (updateInputFields)
                        UpdateOperandStatus(0, 1);
                    break;


                default:
                    if (updateInputFields)
                        UpdateOperandStatus(-1, -1);
                    break;

            }

            return -1;
        }
        private void UpdateOperandStatus(int opAStatus, int opBStatus)
        {
            //-1: none, 0: combobox, 1: textbox;


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

        private List<string[]> GetListOfPresentables()
        {

            return null;
        }
        private List<string[]> GetListOfFlags()
        {

            return null;
        }

        public List<string[]> GetListOfExpressions()
        {

            return null;
        }
        public List<string[]> GetListOfQuestionObjections()
        {

            return null;
        }
        public List<string[]> GetListOfAnswerObjections()
        {

            return null;
        }


        private bool CheckIfDlgTextExists()
        {

            return false;
        }

        private void FillOperandComboboxes()
        {
            cb_operand1.Items.Clear();
            cb_operand2.Items.Clear();
            if (operandAList != null)
            {
                foreach (var i in operandAList)
                {
                    cb_operand1.Items.Add(i[0]);
                }
            }

            if (operandBList != null)
            {
                foreach (var i in operandBList)
                {
                    cb_operand2.Items.Add(i[0]);
                }
            }

        }
        

        public void InsertGameCode()
        {
            for (int i = 0; i < dgv_cmd.RowCount; i++)
            {
                for (int n = 0; n < dgv_cmd[1, i].Value.ToString().Length; i++)
                {

                }

            }

        }

        public void TranslateIntoUserCode()
        {
            for (int i = 0; i < dgv_cmd.RowCount; i++)
            {
                dgv_cmd[0, i].Value = "";
                string userCode = "";
                userCode = GetUserCode(dgv_cmd[1, i].Value.ToString());
                FindOperands(dgv_cmd[1, i].Value.ToString(), GetGameCode(userCode));

            }

        }

        public static List<string> CreateNumberList()
        {
            var list = new List<string>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(Convert.ToChar(i + 48).ToString());
            }
            for (int i = 0; i < 26; i++)
            {
                list.Add(Convert.ToChar(i + 65).ToString());
            }
            for (int i = 0; i < 26; i++)
            {
                list.Add(Convert.ToChar(i + 97).ToString());
            }

            return list;

        }

        public string GetUnicodeID(char c)
        {
            
            int id = Convert.ToInt32(c);
            string s = "";
            s += numberList[Convert.ToInt32((Math.Floor(id / 1296d)).ToString())];
            s += numberList[Convert.ToInt32((Math.Floor((id / 36d)%1296d)).ToString())];
            s += numberList[Convert.ToInt32((Math.Floor(id%36d)).ToString())];
            return s;
        
        }
        public char GetUnicodeChar(string s)
        {
            int id = 0;
            id += numberList.IndexOf(s[0].ToString()) * 1296;
            id += numberList.IndexOf(s[1].ToString()) * 36;
            id += numberList.IndexOf(s[1].ToString());
            return Convert.ToChar(id);
        }

        public bool CheckIfCondition(string gameCode)
        {
            return (gameCode.Length > 0 && (
                 Convert.ToInt32(gameCode
                     .Substring(0, 2)) < 10) && gameCode
                 .Substring(0, 3) != "098" && gameCode
                 .Substring(0, 3) != "099");
        }


        private void cmsti_insertCodeAbove_Click(object sender, EventArgs e)
        {
            int index = dgv_cmd.CurrentRow.Index;
            dgv_cmd.Rows.Insert(index);
            dgv_cmd[0, index].Value = "";
            dgv_cmd[1, index].Value = "";
        }
        private void cmsti_insertCodeBelow_Click(object sender, EventArgs e)
        {
            int index = dgv_cmd.CurrentRow.Index + 1;
            if (index < dgv_cmd.RowCount)
            {
                dgv_cmd.Rows.Insert(index);
                dgv_cmd[0, index].Value = "";
                dgv_cmd[1, index].Value = "";
            }
            else
            {
                dgv_cmd.Rows.Insert(index - 1);
                dgv_cmd[0, index - 1].Value = dgv_cmd[0, index].Value;
                dgv_cmd[1, index - 1].Value = dgv_cmd[1, index].Value;
                dgv_cmd[0, index].Value = "";
                dgv_cmd[1, index].Value = "";
            }
           
        }

        private void cmsti_moveCodeUp_Click(object sender, EventArgs e)
        {

            int index = dgv_cmd.CurrentRow.Index;
            if (index - 1 < 0)
                return;
            var cmd = new List<string> {dgv_cmd[0, index].Value.ToString(), dgv_cmd[1, index].Value.ToString()};
            dgv_cmd[0, index].Value = dgv_cmd[0, index - 1].Value;
            dgv_cmd[1, index].Value = dgv_cmd[1, index - 1].Value;
            dgv_cmd[0, index - 1].Value = cmd[0];
            dgv_cmd[1, index - 1].Value = cmd[1];
        }

        private void cmsti_moveCodeDown_Click(object sender, EventArgs e)
        {

            int index = dgv_cmd.CurrentRow.Index;
            if (index + 1 >= dgv_cmd.RowCount)
                return;
            var cmd = new List<string> { dgv_cmd[0, index].Value.ToString(), dgv_cmd[1, index].Value.ToString() };
            dgv_cmd[0, index].Value = dgv_cmd[0, index + 1].Value;
            dgv_cmd[1, index].Value = dgv_cmd[1, index + 1].Value;
            dgv_cmd[0, index + 1].Value = cmd[0];
            dgv_cmd[1, index + 1].Value = cmd[1];
        }

        private void cmsti_removeCode_Click(object sender, EventArgs e)
        {

            int index = dgv_cmd.CurrentRow.Index;
            dgv_cmd.Rows.RemoveAt(index);
        }

        private void cb_addAlternativeCondition_CheckedChanged(object sender, EventArgs e)
        {
            if (!cb_addAlternativeCondition.Enabled)
                return;

            if (cb_addAlternativeCondition.Checked)
            {
                int index = dgv_cmd.CurrentRow.Index;
                if ( index + 1 < dgv_cmd.RowCount && dgv_cmd[1, index].Value.ToString().Substring(0, 3) != "098")
                {
                    
                    dgv_cmd.Rows.Insert(dgv_cmd.CurrentRow.Index + 1);
                    dgv_cmd[0, index + 1].Value = "";
                    dgv_cmd[1, index + 1].Value = "098.";
                }

            }
            else
            {
                {
                    int index = dgv_cmd.CurrentRow.Index;
                    if (index + 1 < dgv_cmd.RowCount && dgv_cmd[1, index + 1].Value.ToString().Substring(0, 3) == "098")
                    {

                        dgv_cmd.Rows.RemoveAt(index + 1);
                    }

                }
            }

        }

        private void tb_operand1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_operand2_TextChanged(object sender, EventArgs e)
        {

        }

        private void cb_operand1_SelectedValueChanged(object sender, EventArgs e)
        {
            dgv_cmd[1, dgv_cmd.CurrentRow.Index].Value = InsertOperandsIntoGameCode(dgv_cmd[1, dgv_cmd.CurrentRow.Index].Value.ToString(), operandAList[cb_operand1.SelectedIndex][2], "");

        }
        
        private void cb_operand2_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv_cmd[1, dgv_cmd.CurrentRow.Index].Value = InsertOperandsIntoGameCode(dgv_cmd[1, dgv_cmd.CurrentRow.Index].Value.ToString(), "", operandAList[cb_operand1.SelectedIndex][2]);

        }

        private void dgv_cmd_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}