using System;
using System.Collections.Generic;

namespace silvanus_encrypt
{
    class Program
    {
        public static void Main(string[] args){
            encriptarPassword("2599"); // output: E1E1219
        }
        private static string encriptarPassword(string passFromUser){
            string pass = passFromUser;
            char[] password = pass.ToCharArray();
            List<string> newPass = new List<string>();
            int[] encodedPass = new int[pass.Length];
            for(int i=0; i< pass.Length;i++){
                newPass.Add(pass[i].ToString());
            }for (int i = 0; i < pass.Length; i++)
            {
                encodedPass[i] = (int.Parse(newPass[i])+1)*3;
            }for (int i = 0; i < pass.Length; i++)
            {
                newPass[i] = encodedPass[i].ToString("X");
            }
            string[] result = newPass.ToArray();
            pass = string.Join("", result);
            char[] invertedItems = pass.ToCharArray();
            Array.Reverse(invertedItems);
            pass = new string(invertedItems);
            Console.WriteLine(pass);
           return pass;
       }
    }
}
