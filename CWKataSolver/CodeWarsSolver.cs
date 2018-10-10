﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CWKataSolver
{
    public class CodeWarsSolver
    {
        // Level 8 kata
        public double basicOp(char operation, double value1, double value2)
        {
            switch (operation)
            {
                case '+': return value1 + value2;
                case '-': return value1 - value2;
                case '*': return value1 * value2;
                case '/': return value1 / value2;
                default:
                    throw new System.ArgumentException("Unknown operation!", operation.ToString());
            }
        }

        public bool IsLochNessMonster(string sentence)
        {
            if(sentence == null) { return false; }

            return (sentence.ToLower().Contains("tree fiddy")) || sentence.Contains("3.50");
        }

        public string NoSpace(string input)
        {
            throw new NotImplementedException();
        }

        public int Multiply(int a, int b)
        {
            throw new NotImplementedException();
        }

        public string EvenOrOdd(int number)
        {
            throw new NotImplementedException();
        }

        public float Combat(float health, float damage)
        {
            throw new NotImplementedException();
        }

        public double FindAverage(double[] array)
        {
            throw new NotImplementedException();

        }

        public string Bmi(double weight, double height)
        {
            throw new NotImplementedException();
        }

        // Level 6 kata
        public string BreakCamelCase(string str)
        {
            throw new NotImplementedException();
        }

        public bool IsPrime(int n)
        {
            throw new NotImplementedException();
        }

        public int[] ArrayDiff(int[] a, int[] b)
        {
            throw new NotImplementedException();
        }

        public int Solution(int value)
        {
            throw new NotImplementedException();
        }

        // Level 5 kata
        public string WhoIsNext(string[] values, long n)
        {
            throw new NotImplementedException();

        }
    }
}
