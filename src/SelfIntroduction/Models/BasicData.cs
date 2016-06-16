using SelfIntroduction.Core;
using System;

namespace SelfIntroduction.Models
{
    public class BasicData
    {
        public string Name { get; set; }
        public string EnglishName { get; set; }
        public DateTime BirthDay { get; set; }
        public SexType Sex { get; set; }
    }
}
