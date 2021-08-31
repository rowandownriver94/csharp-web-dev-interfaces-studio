using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    public abstract class BaseDisc
    {
        public string Name { get; set; }
        public int MinutesOfContent { get; set; }
        public string Content { get; set; }
        public string DiscType { get; set; }
        public bool IsSpinable { get; set; }

        public BaseDisc(string name, int minutesOfContent, string content, string discType, bool isSpinable)
        {
            Name = name;
            MinutesOfContent = minutesOfContent;
            Content = content;
            DiscType = discType;
            IsSpinable = isSpinable;
        }


    }
}
