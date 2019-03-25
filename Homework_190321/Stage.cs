using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;

namespace Homework_190321
{
    class Stage
    {
        public const int UP = 0;
        public const int DOWN = 1;
        public const int LEFT = 2;
        public const int RIGHT = 3;

        public int row = 8;
        public int col = 8;

        public int playerPosX = 1;
        public int playerPosY = 1;

        public int goalPosX = 0;
        public int goalPosY = 0;

        char[] stage;

        // 生成指定关卡的地图
        public Stage(int level)
        {
            stage = ReadMapData(level);
            SetPlayerPos(this.playerPosX, this.playerPosY);

            //ReadMapData(level);
        }

        public char[] ReadMapData(int level)
        {
            // 根据关卡编号，得出关卡地图的txt文件路径
            string mapPath = string.Format("./Map_{0}.txt", level);

            string[] mapLines = File.ReadAllLines(mapPath);

            int row = mapLines.Length;      // 字符串数组的长度就是地图的行数
            int col = mapLines[0].Length;   // 单个字符串的字符个数就是地图的列数

            this.row = row;
            this.col = col;

            char[] ret = new char[row * col];

            for (int i = 0; i < row; i++)
            {
                for(int t = 0; t < col; t++)
                {
                    char block = mapLines[i][t];

                    if (block == 'p')
                    {
                        //Console.WriteLine("玩家起始位置：{0},{1}", i, t);
                        playerPosX = t;
                        playerPosY = i;
                        block = ' ';
                    }
                    else if(block == 'o')
                    {
                        //Console.WriteLine("出口位置：{0},{1}", i, t);
                        goalPosX = t;
                        goalPosY = i;
                    }

                    ret[i * col + t] = block;
                }
            }

            return ret;
        }

        public static bool HasLevel(int level)
        {
            // 根据关卡编号，得出关卡地图的txt文件路径
            string mapPath = string.Format("./Map_{0}.txt", level);

            return File.Exists(mapPath);
        }

        private bool IsWall(int row, int col, int i, int t)
        {
            bool isWall = false;

            // TODO : 判断是不是围墙

            // 判断标准：
            // 第一行和最后一行必定是围墙
            // 第一列和最后一列必定是围墙
            // '#'字符也是不能走的
            bool isFirstRow = false;
            bool isLastRow = false;
            bool isFirstCol = false;
            bool isLastCol = false;
            bool isObstacle = false;

            // 是否第一行
            isFirstRow = (t == 0);

            // 是否最后一行
            isLastRow = (t == row - 1);

            // 是否第一列
            isFirstCol = (i == 0);

            // 是否最后一列
            isLastCol = (i == col - 1);

            // 是不是 # 字障碍物
            isObstacle = (stage[t * col + i] == '#');

            // 上述五个条件任何一个满足，就是围墙
            isWall = isFirstRow || isLastRow || isFirstCol || isLastCol || isObstacle;
            return isWall;
        }

        private void SetPlayerPos(int newPosX, int newPosY)
        {
            if(IsWall(row, col, newPosX, newPosY) == false)
            {
                int currentIdx = playerPosY * col + playerPosX;
                //stage[currentIdx] = ' ';

                playerPosX = newPosX;
                playerPosY = newPosY;

                int idx = newPosY * col + newPosX;
                //stage[idx] = 'p';
            }
        }

        public void MovePlayer(int direction)
        {
            switch(direction)
            {
                case UP:
                    SetPlayerPos(playerPosX, playerPosY - 1);
                    break;
                case DOWN:
                    SetPlayerPos(playerPosX, playerPosY + 1);
                    break;
                case LEFT:
                    SetPlayerPos(playerPosX - 1, playerPosY);
                    break;
                case RIGHT:
                    SetPlayerPos(playerPosX + 1, playerPosY);
                    break;
            }
        }

        public void DrawStage()
        {
            for (int i = 0; i < stage.Length; i++)
            {
                if(playerPosY * col + playerPosX == i)
                {
                    Console.Write('p');
                }
                else
                {
                    Console.Write(stage[i]);
                }

                Console.Write(' ');

                int mod = i % col;
                if (mod == col - 1)
                {
                    Console.Write('\n');
                }
            }
        }

        public bool IsPlayerReachedGoal()
        {
            return (playerPosX == goalPosX && playerPosY == goalPosY);
        }
    }
}
