﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disney_Parser
{
    internal class VoiceParser
    {
        public void Parse(string path)
        {
            string fileContent = File.ReadAllText(path);
            string[] lines = fileContent.Split(' ');
            foreach (string line in lines.Skip(1))
            {
                string[] elements = line.Split(',');
                string character = elements[1];
                string voiceActor = elements[2];
                string movingActor = elements[3];
            }
        }
    }
}
