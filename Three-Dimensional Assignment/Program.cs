namespace Three_Dim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,,] firstArray = new int[2, 5, 3]
            {
                { { 2, 1, 2 }, { 1, 3, 5 }, { 2, 3, 4 }, { 3, 4, 2 }, { 9, 5, 1 } },
                { { 2, 4, 3 }, { 1, 6, 2 }, { 5, 3, 1 }, { 3, 7, 2 }, { 4, 5, 8 } },
            };
            int[,,] secondArray = new int[2, 5, 3]
            {
                { { 2, 4, 6 }, { 1, 3, 5 }, { 2, 3, 4 }, { 3, 4, 5 }, {7, 1, 2 } },
                { { 1, 3, 2 }, { 3, 0, 1 }, { 5, 1, 9 }, { 9, 3, 0 }, {2, 1, 4 } },
               

            }; int[,,] thirdArray = new int[2, 5, 3];

            for (int i = 0; i < firstArray.GetLength(0); i++)
            {
                for (int j = 0; j < secondArray.GetLength(1); j++)
                {
                    for (int k = 0; k < secondArray.GetLength(2); k++)
                    {
                        thirdArray[i, j, k] += firstArray[i, j, k] * secondArray[i, j, k];
                    }
                }
            }



            foreach(var item in thirdArray)
            {
                Console.WriteLine(item);
            }


        }
    }
}



