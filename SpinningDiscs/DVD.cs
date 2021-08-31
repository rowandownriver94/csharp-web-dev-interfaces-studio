using System;
namespace SpinningDiscs
{
    public class DVD : BaseDisc, IOpticalDisc
    {
        public string Quote { get; set;}

        public DVD(string name, int minutesOfContent, string content, string discType, bool isSpinable, string quote) : base(name, minutesOfContent, content, discType, isSpinable)
        {
            Quote = quote;
        }

        public void ReadData()
        {
            Console.WriteLine(Quote);
        }

        public void SpinDisc()
        {
            if(IsSpinable == true)
            {
                ReadData();
            }
            else
            {
                Console.WriteLine("ERROR! Unable to read disc.");
            }
        }
    }
}
