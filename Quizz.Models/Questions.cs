﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Models
{
    public class Question
    {
        public string Text { get; set; } 
        public string[] Options { get; set; } 
        public int CorrectOptionIndex { get; set; } 
    }

}
