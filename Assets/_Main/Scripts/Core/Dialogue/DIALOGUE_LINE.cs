using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DIALOGUE
{

    public class DIALOGUE_LINE
    {
        public string speaker;
        public string dialogue;
        public string commands;
        
        public DIALOGUE_LINE(string speaker, string dialogue, string command)
        {
            this.speaker = speaker;
            this.dialogue = dialogue;
            this.commands = command;
        }
    }
}
