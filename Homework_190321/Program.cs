using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Maze_File 设计目标：
// 将迷宫地图保存在txt文件
// 仅需读取txt文件就可以获得地图全部信息，不需在程序内部指定

namespace Homework_190321
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game(8, 8, 1, 1);

            while(game.isRunning)
            {
                game.Loop();
            }

            game.End();
        }
    }
}
