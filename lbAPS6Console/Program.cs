using System;

namespace lbAPS6Console
{ 
    class Program
    {
        static void Main(string[] args)
        {
            AskMe askName = new AskMe("Please, choose between H.264/MPEG-4 AVC and HEVC \n  ", "Thank you. ");
            askName.talk = new ConsoleTell();
            askName.Ask();
            AskMe askQuality = new AskMe("Please, enter the name of the file and choose quality \n Enter small,medium or high: ", "Thank you, we are working on this");
            askQuality.talk = new ConsoleTell();
            askQuality.Ask();
        }
    }
}
