using System;
using System.Collections.Generic;
using System.Text;

namespace lbAPS6Console
{
    interface ISpeak
    {
        string GetUserAnswer();
        void ShowAsk(string ask);
        void ShowAnswer(string answer);
    }
}
