using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Nr_56
{
    class Calculate
    {
        private float numA;
        private float numB;
        private float result;
        private string path = @"quickMaths.txt";
        public void Plus(float a,float b)
        {
            numA = a;
            numB = b;
            result = numA + numB;
            string aLine =  numA + "+" + numB + "=" + result ;
            
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(aLine);
            }
        }
        public void Minus(float a, float b)
        {

            numA = a;
            numB = b;
            result = numA - numB;
            string aLine =  numA + "-" + numB + "=" + result ;

            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(numA + "-" + numB + "=" + result);
            }
        }
        public void Multiplication(float a, float b)
        {
            numA = a;
            numB = b;
            result = numA * numB;
            string aLine = numA + "*" + numB + "=" + result ;

            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(aLine);
            }
        }
        public void Division(float a, float b)
        {

            numA = a;
            numB = b;
            result = numA / numB;
            string aLine = numA + "/" + numB + "=" + result;

            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(aLine);
            }
        }
        
    }
}
