using System;
using System.Collections.Generic;
using Minesweeper;
public class MineController : IControl
{
    private bool initStart = true;

    void IControl.Reveal(out bool useFlag, out int y, out int x, List<List<MinesCellInfo>> mines)
    {

        if (initStart)
        {
            initStart = false;
            Random Rnd = new Random();
            x = Rnd.Next(0, 9);
            y = Rnd.Next(0, 9);
        }



        x = 1;
        y = 1;
        useFlag = false;

        for (int i = 0; i < mines.Count; i++)
        {
            for (int j = 0; j < mines[i].Count; j++)
            {
                Console.WriteLine(" useflag :: " + mines[y][x].UseFlag + "   mineCountHint" + mines[y][x].MineCountHint);

            }
        }

    }
    private void SearchMine()
    {

    }
}
