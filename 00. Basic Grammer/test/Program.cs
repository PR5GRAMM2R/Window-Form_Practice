using System;
using System.Runtime.InteropServices;

namespace Example1
{
    class program
    {
        public static void Main(string[] args)
        {
            /*char chVar1 = 'A';
            char chVar2 = '\x0041';
            char chVar3 = (char)65;
            char chVar4 = '\u0041';

            Console.WriteLine("문자 표현 : {0}", chVar1);
            Console.WriteLine("16진수 표현 : {0}", chVar2);
            Console.WriteLine("ASCII 표현 : {0}", chVar3);
            Console.WriteLine("Unicode 표현 : {0}", chVar4);*/

            ////////////////////////////////////////////////////////////////////////////////////////////////

            /*string strText1 = " Hello ";
            string strText2 = " C# ";
            string strText3 = " World! ";
            string strText4 = strText1 + strText2 + strText3;

            Console.WriteLine("전체 문자열 : {0}", strText4);
            Console.WriteLine("전체 문자열의 길이 : {0}", strText4.Length);
            Console.WriteLine("문자열 시작과 끌의 공백 제거 : {0}", strText4.Trim());
            Console.WriteLine("C# 제거 : {0}", strText4.Remove(8, 2));
            Console.WriteLine("Hello 를 안녕으로 변경 : {0}", strText4.Replace("Hello", "안녕"));
            Console.WriteLine("모두 대문자로 변경 : {0}", strText4.ToUpper());
            Console.WriteLine("모두 대문자로 변경 : {0}", strText4.ToLower());*/

            ////////////////////////////////////////////////////////////////////////////////////////////////

            /*int iAge = 22;
            string strText1 = "안녕하세요!";
            string strText2 = "제 나이는";
            string strText3 = "세 입니다.";

            Console.WriteLine("{0} {1} {2} {3}", strText1, strText2, iAge, strText3);*/

            ////////////////////////////////////////////////////////////////////////////////////////////////

            /*int iNum1 = 2;
            int iNum2 = 7;

            Console.WriteLine("iNum1 = {0}, iNum2 = {1}", iNum1, iNum2);
            Console.WriteLine("iNum1 + iNum2 = {1}", iNum1 + iNum2);
            Console.WriteLine("iNum1 - iNum2 = {1}", iNum1 - iNum2);
            Console.WriteLine("iNum1 / iNum2 = {1}", iNum1 / iNum2);
            Console.WriteLine("iNum1 * iNum2 = {1}", iNum1 * iNum2);
            Console.WriteLine("iNum1 % iNum2 = {1}", iNum1 % iNum2);*/

            ////////////////////////////////////////////////////////////////////////////////////////////////

            /*int iNum1 = 3;
            int iNum2 = 3;

            Console.WriteLine("전위 연산자");
            Console.WriteLine("iNum1 = {0}, iNum2 = {1}", iNum1, iNum2);
            Console.WriteLine("++iNum = {0}, --iNum2 = {1}", ++iNum1, --iNum2);
            Console.WriteLine("iNum1 = {0}, iNum2 = {1}", iNum1, iNum2);

            iNum1 = 3;
            iNum2 = 3;
            Console.WriteLine("\n");

            Console.WriteLine("후위 연산자");
            Console.WriteLine("iNum1 = {0}, iNum2 = {1}", iNum1, iNum2);
            Console.WriteLine("iNum++ = {0}, iNum2-- = {1}", iNum1++, iNum2--);
            Console.WriteLine("iNum1 = {0}, iNum2 = {1}", iNum1, iNum2);*/

            ////////////////////////////////////////////////////////////////////////////////////////////////

            /*string strName;

            Console.Write("<< 이름을 입력하세요 : ");
            strName = Console.ReadLine();
            Console.WriteLine(">> {0} 님, 안녕하세요!", strName);*/

            ////////////////////////////////////////////////////////////////////////////////////////////////

            /*const int NUM_STUDENTS = 5;
            Array arrStudents = Array.CreateInstance(typeof(Student), NUM_STUDENTS);

            int iScoreSum = 0;
            double dScoreMean = 0.0;

            Console.WriteLine("<< {0} 명의 학생의 점수를 입력하세요.", NUM_STUDENTS);

            for(int i = 0; i < NUM_STUDENTS; i++)
            {
                int iNumber = i + 1;
                string strScore = Console.ReadLine();
                int iScore = Convert.ToInt32(strScore);

                Student student = new Student(iNumber, iScore);
                arrStudents.SetValue(student, i);
            }

            for(int i = 0; i < arrStudents.Length; i++)
            {
                int iNumber = ((Student)arrStudents.GetValue(i)).getNumber();
                int iScore = ((Student)arrStudents.GetValue(i)).getScore();

                string strGrade = "F";
                if(iScore >= 90)
                {
                    strGrade = "A";
                }
                else if (iScore >= 80)
                {
                    strGrade = "B";
                }
                else if (iScore >= 70)
                {
                    strGrade = "C";
                }
                else if (iScore >= 60)
                {
                    strGrade = "D";
                }

                Console.WriteLine(">> {0} 번 학생의 점수 : {1}, 등급 {2}", iNumber, iScore, strGrade);

                iScoreSum += iScore;
            }

            dScoreMean = (double)iScoreSum / NUM_STUDENTS;
            Console.WriteLine("평균 점수 : {0}", dScoreMean);*/

            ////////////////////////////////////////////////////////////////////////////////////////////////

            /*int[,] values = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 } };

            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    Console.Write("{0}", values[i, j]);
                }
            }

            Console.WriteLine();

            foreach(int value in values)
            {
                Console.WriteLine("{0}", value);
            }*/

            ////////////////////////////////////////////////////////////////////////////////////////////////

            /* String str = null;

             try
             {
                 Console.WriteLine(str.ToString());
                 Console.WriteLine("Program Terminated");
             }
             catch(NullReferenceException e)
             {
                 Console.WriteLine(e.ToString());
             }*/

            ////////////////////////////////////////////////////////////////////////////////////////////////

            /*int[] arr1 = { 1, 11, 22, 33 };
            int[] arr2 = { 0, 1, 2 };

            for(int i = 0; i < arr1.Length; i++)
            {
                try
                {
                    Console.WriteLine(arr1[i] + "/" + arr2[i] + "=" + arr1[i] / arr2[i]);
                }
                catch(DivideByZeroException e)
                {
                    Console.WriteLine("Can't divide");
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }*/

            ////////////////////////////////////////////////////////////////////////////////////////////////

            /*int[] arr_1 = new int[5] { 3, 5, 7, 4, 1 };
            int[] arr_2 = (int[]) arr_1.Clone();

            foreach(int item in arr_2){
                Console.WriteLine("{0}", item);
            }*/

            ////////////////////////////////////////////////////////////////////////////////////////////////

            int[] arr_1 = new int[5] { 3, 5, 7, 4, 1 };
            int[] arr_2 = new int[5] { 9, 3, 6, 5, 2 };
            int[] arr_3 = new int[10];

            arr_1.CopyTo(arr_3, 0);
            arr_2.CopyTo(arr_3, 5);

            foreach (int item in arr_3)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();

            ////////////////////////////////////////////////////////////////////////////////////////////////

            /*int[,] arr = new int[2, 5] { { 3, 5, 7, 4, 1 }, { 4, 5, 7, 8, 9 } };

            Console.WriteLine("{0}", arr.GetLength(0));
            Console.WriteLine("{0}", arr.GetLength(1));
            Console.WriteLine("{0}", arr.Length);
            Console.WriteLine("{0}" + "차원", arr.Rank);*/

            ////////////////////////////////////////////////////////////////////////////////////////////////

            /*B b = new B();
            b.PrintA();
            b.PrintB();*/

            ////////////////////////////////////////////////////////////////////////////////////////////////

            /*Date d1 = new Date();

            Console.WriteLine("Default month : {0}\n", d1.Month);

            while (true)
            {
                Console.WriteLine("Enter month : ");
                int inputMonth = int.Parse(Console.ReadLine());

                if(inputMonth == -1)
                {
                    break;
                }
                d1.Month = inputMonth;

                Console.WriteLine("Now month : {0}\n", d1.Month);
            }*/

            ////////////////////////////////////////////////////////////////////////////////////////////////

            MyIndexerClass mic = new MyIndexerClass();

            mic[0] = "Seoul";
            mic[1] = "Nowon";
            mic[2] = "Kwangwoon";
            mic[3] = "-road 20";
            mic[4] = "Kwangwoon University";

            for(int i = 0; i < mic.Length; i++)
            {
                Console.Write("{0} ", mic[i]);
            }

            Console.WriteLine();
        }
    }

    public class Student
    {
        private int mINumber;
        private int mIScore;

        public Student(int iNumber, int iScore)
        {
            this.mINumber = iNumber;
            this.mIScore = iScore;
        }

        public int getNumber()
        {
            return mINumber;
        }

        public int getScore()
        {
            return mIScore;
        }
    }

    class A
    {
        public void PrintA()
        {
            Console.WriteLine("A class function");
        }
    }

    class B : A
    {
        public void PrintB()
        {
            Console.WriteLine("B class function");
        }
    }

    public class Date
    {
        private int month = 7;
        public int Month
        {
            get { return month; }
            set { if ((value > 0) && (value < 13)) month = value; }
        }
    }

    class MyIndexerClass
    {
        private string[] data = new string[5];

        public int Length
        {
            get { return data.Length; }
        }
        
        public string this[int index]
        {
            get { return data[index]; }
            set { data[index] = value; }
        }
    }
}