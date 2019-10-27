using System;
using System.Collections.Generic;
using Minesweeper;
public class MineController : IControl
{
    private bool initStart = true;
    Random Rnd = new Random();
    
    // 지뢰 찿기 생성 알고리즘 상 지뢰에  ++ 를 호출하므로 지뢰가 숫자들에 둘러 싸임


    // 1회 차에 최대 1개식 오픈 가능 ...   메인 스레드를 수정하지 않는 한  속도에  한계성이 보임 
    void IControl.Reveal(out bool useFlag, out int y, out int x, List<List<MinesCellInfo>> mines)
    {


        if (initStart)
        {
            initStart = false;
           
            x = Rnd.Next(0, 9);
            y = Rnd.Next(0, 9);
        }

        int DeltaY[] = new int[8];
        int DeltaX[] = new int[8];

        List<Data> Travel = new List<Data>();
        String Map = "";
        for (int i = 0; i < mines.Count; i++)
        {
            for (int j = 0; j < mines[i].Count; j++)
            {

                Map += mines[i][j].MineCountHint + " ";

                

            }
            Map += "\n";
      
        }


        Console.WriteLine(Map);




      
        useFlag = false;
        //Console.WriteLine("시작");
        for (int i = 0; i < mines.Count; i++)
        {
            for (int j = 0; j < mines[i].Count; j++)
            {
                ///Console.WriteLine("인덱스 y = {0}, x = {1}  useflag :: " + mines[i][j].UseFlag + "   mineCountHint  :: " + mines[i][j].MineCountHint, i, j);

            }
        }

        //Console.WriteLine("끝");

    }
    private void SearchMine()
    {

    }
    class Data
    {
        public int x;
        public int y;
        public int hint ;
        public Data(int _x, int _y, int _hint)
        {
            x = _x;
            y = _y;
            hint = _hint;
        }

    }
}
