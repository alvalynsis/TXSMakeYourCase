using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TXSMakeYourCase
{
    class Project
    {


    }

    class Dialogue
    {
        public string ID;
        public Dictionary<string, DlgText> library;

    }

    class DlgText
    {
        public string ID;
        public int characterID;
        public int textType;
        public string text;
        public List<string> choiceList;
        public string gameCode;
        public string tags;

    }

    class Presentable
    {
        public string ID;

    }

    class Character
    {
        public string ID;

    }
    class Flag
    {
        public string ID;

    }

    class Settings
    {

    }

    
    
}
