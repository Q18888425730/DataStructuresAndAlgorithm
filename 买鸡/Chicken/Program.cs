using System;

namespace Chicken
{
    class Program
    {
        static void Main(string[] args)
        {
            //公鸡的数量
            int cockCount = 0;
            //母鸡的数量
            float henCount = 0;
            //小鸡的数量
            float smallCount = 0;
            for (cockCount = 0; cockCount < 100; cockCount++)
            {
                henCount = 25 - 7f / 4f * cockCount;
                smallCount = 75 + 3f / 4f * cockCount;
                if (henCount > 0 && smallCount > 0)
                {
                    if (((int)henCount == henCount) && ((int)smallCount == smallCount))
                    {
                        Console.WriteLine("公鸡数目有:{0},母鸡数目有:{1},小鸡数目有:{2}", cockCount, henCount, smallCount);
                    }

                }

            }
        }
    }
}
