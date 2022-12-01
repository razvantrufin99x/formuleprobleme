using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace formuleprobleme
{
    public class prioritateoperatori
    {
        public List<formuleprobleme.grupa> tabeluldeprioritatealoperatorilor = new List<formuleprobleme.grupa>();

        public prioritateoperatori()
        { 
            tabeluldeprioritatealoperatorilor.Add(new grupa("2","!","dreapta->stinga"));
            tabeluldeprioritatealoperatorilor.Add(new grupa("2", "-", "dreapta->stinga"));
            tabeluldeprioritatealoperatorilor.Add(new grupa("2", "+", "dreapta->stinga"));
            tabeluldeprioritatealoperatorilor.Add(new grupa("2", "~", "dreapta->stinga"));
            tabeluldeprioritatealoperatorilor.Add(new grupa("2", "++", "dreapta->stinga"));
            tabeluldeprioritatealoperatorilor.Add(new grupa("2", "--", "dreapta->stinga"));
            tabeluldeprioritatealoperatorilor.Add(new grupa("2", "(tip)", "dreapta->stinga"));
            tabeluldeprioritatealoperatorilor.Add(new grupa("2", "sizeof", "dreapta->stinga"));
            tabeluldeprioritatealoperatorilor.Add(new grupa("4", "*", "stinga->dreapta"));
            tabeluldeprioritatealoperatorilor.Add(new grupa("4", "/", "stinga->dreapta"));
            tabeluldeprioritatealoperatorilor.Add(new grupa("4", "%", "stinga->dreapta"));
            tabeluldeprioritatealoperatorilor.Add(new grupa("5", "+", "stinga->dreapta"));
            tabeluldeprioritatealoperatorilor.Add(new grupa("5", "-", "stinga->dreapta"));
            tabeluldeprioritatealoperatorilor.Add(new grupa("6", "<<", "stinga->dreapta"));
            tabeluldeprioritatealoperatorilor.Add(new grupa("6", ">>", "stinga->dreapta"));
            tabeluldeprioritatealoperatorilor.Add(new grupa("7", "<", "stinga->dreapta"));
            tabeluldeprioritatealoperatorilor.Add(new grupa("7", ">", "stinga->dreapta"));
            tabeluldeprioritatealoperatorilor.Add(new grupa("7", "<=", "stinga->dreapta"));
            tabeluldeprioritatealoperatorilor.Add(new grupa("7", "=>", "stinga->dreapta"));
            tabeluldeprioritatealoperatorilor.Add(new grupa("8", "==", "stinga->dreapta"));
            tabeluldeprioritatealoperatorilor.Add(new grupa("8", "!=", "stinga->dreapta"));
            tabeluldeprioritatealoperatorilor.Add(new grupa("9", "&", "stinga->dreapta"));
            tabeluldeprioritatealoperatorilor.Add(new grupa("10", "^", "stinga->dreapta"));
            tabeluldeprioritatealoperatorilor.Add(new grupa("11", "!", "stinga->dreapta"));
            tabeluldeprioritatealoperatorilor.Add(new grupa("12", "&&", "stinga->dreapta"));
            tabeluldeprioritatealoperatorilor.Add(new grupa("13", "||", "stinga->dreapta"));
            tabeluldeprioritatealoperatorilor.Add(new grupa("14", "?", "dreapta->stinga"));
            tabeluldeprioritatealoperatorilor.Add(new grupa("14", ":", "dreapta->stinga"));
            tabeluldeprioritatealoperatorilor.Add(new grupa("15", "=", "dreapta->stinga"));
            tabeluldeprioritatealoperatorilor.Add(new grupa("15", "*=", "dreapta->stinga"));
            tabeluldeprioritatealoperatorilor.Add(new grupa("15", "/=", "dreapta->stinga"));
            tabeluldeprioritatealoperatorilor.Add(new grupa("15", "%=", "dreapta->stinga"));
            tabeluldeprioritatealoperatorilor.Add(new grupa("15", "+=", "dreapta->stinga"));
            tabeluldeprioritatealoperatorilor.Add(new grupa("15", "-=", "dreapta->stinga"));
            tabeluldeprioritatealoperatorilor.Add(new grupa("15", "&=", "dreapta->stinga"));
            tabeluldeprioritatealoperatorilor.Add(new grupa("15", "^=", "dreapta->stinga"));
            tabeluldeprioritatealoperatorilor.Add(new grupa("15", "!=", "dreapta->stinga"));
            tabeluldeprioritatealoperatorilor.Add(new grupa("15", "<<=", "dreapta->stinga"));
            tabeluldeprioritatealoperatorilor.Add(new grupa("15", ">>=", "dreapta->stinga"));
            tabeluldeprioritatealoperatorilor.Add(new grupa("16", ",", "dreapta->stinga"));

        }
    }
}
