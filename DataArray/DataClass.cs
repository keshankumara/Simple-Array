using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Data_Array
{
    public class DataArray
    {
        private int[] dataArray;
        private int ArrayElements;
        private int ArraySize;

        public DataArray(int size)
        {
            ArrayElements = 0;
            ArraySize = size;
            dataArray = new int[ArraySize];
        }

        public void DisplayValues()
        {
            for (int i = 0; i < ArrayElements; i++)
            {
                Console.Write($"{dataArray[i]} ");
            }
            Console.WriteLine(" ");
        }

        public void AddValue(int value)
        {
            if (ArrayElements < ArraySize)
            {
                dataArray[ArrayElements] = value;
                ArrayElements++;
                //Console.WriteLine($"Array Size : {ArraySize} ");
            }
            else
            {
                expand();
                AddValue(value);
                //Console.WriteLine("Error : Out of Range");
            }
        }

        public void AddValuesFromUser()
        {
            Console.Write("Enter Size of Array : ");
            int size =Convert.ToInt32(Console.ReadLine());
            ArraySize = size;
            Console.Write("Enter Number of Values : ");
            int NumberOfValues = Convert.ToInt32(Console.ReadLine());
            for (int i=0; i<NumberOfValues; i++)
            {
                Console.Write("Enter Value : ");
                int value = Convert.ToInt32(Console.ReadLine());
                AddValue(value);
            }

        }

        public void RemoveValues(int index)
        {
            if (index >= 0 || index <= ArraySize)
            {
                for (int i = index; i < ArrayElements - 1; i++)
                {
                    dataArray[i] = dataArray[i + 1];
                }
                ArrayElements--;
                DisplayValues();
                ConditionCheck();
            }
            else
            {
                Console.WriteLine("Error : Out of Range");
            }
        }

        public void RemoveValues(int StartIndex, int EndIndex)
        {
            if (StartIndex < EndIndex)
            {
                int GapOfIndex = (EndIndex - StartIndex) + 1;
                if ((StartIndex >= 0 || StartIndex <= ArraySize) && (EndIndex >= 0 || EndIndex <= ArraySize))
                {
                    for (int i = EndIndex; i < ArrayElements - 1; i++)
                    {
                        dataArray[StartIndex] = dataArray[i+1];
                        StartIndex++;
                    }
                    ArrayElements = ArrayElements - GapOfIndex;
                    //Console.WriteLine($"{GapOfIndex}");
                    //Console.WriteLine($"Array Elements : {ArrayElements}");
                    DisplayValues();
                    ConditionCheck();
                }
                else
                {
                    Console.WriteLine("Error : Out of Range");
                }
            }
            
        }

        public void SearchValue(int index)
        {
            if (index > 0 && index <= ArraySize)
            {
                if (index < ArrayElements)
                {
                    Console.WriteLine($"Searching Data Value is : {dataArray[index]}");
                }
                else
                {
                    Console.WriteLine("Searching Data Value is : No Data");
                }
            }
            else
            {
                Console.WriteLine("Searching Data Value is : Out of Range");
            }
        }

        public void ConditionCheck()
        {
            if (ArrayElements < ArraySize && ArrayElements <= (ArraySize / 2))
            {
                Srinkage();
                //Console.WriteLine($"Array Size : {ArraySize} ");
            }

        }

        public void expand()
        {
            ArraySize = ArraySize * 2;
            int[] NewArray = new int[ArraySize];
            Array.Copy(dataArray, NewArray, ArrayElements);
            dataArray = NewArray;
        }

        public void Srinkage()
        {
            ArraySize = ArraySize / 2;
            int[] NewArray = new int[ArraySize];
            Array.Copy(dataArray, NewArray, ArrayElements);
            dataArray = NewArray;
        }

        public void ShowFuctions()
        {
            Console.WriteLine("  Welcome Function Lists   ");
            Console.WriteLine();
            Console.WriteLine("  Functions :");
            Console.WriteLine("             DataArray(Size of Array)");
            Console.WriteLine("             DisplayValues()");
            Console.WriteLine("             AddValue(Value)  // By using code");
            Console.WriteLine("             RemoveValues(Index of Array which you want to remove )");
            Console.WriteLine("             RemoveValues(StartIndex, EndIndex)");
            Console.WriteLine("             SearchValue(Index of Array)");
            Console.WriteLine();
        }

    }
}
