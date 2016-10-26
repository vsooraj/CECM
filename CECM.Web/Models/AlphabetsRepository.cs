using BO;
using System.Collections.Generic;

namespace CECM.Web.Models
{
    public class AlphabetsRepository
    {
        string[] _alphabets = new string[] { "ALL", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        public List<Alphabets> listAlphabets = new List<Alphabets>();
        //Alphabets alphabets = new Alphabets();
        public AlphabetsRepository()
        {
            foreach (string alphabet in _alphabets)
            {
                Alphabets alphabets = new Alphabets();
                alphabets.alphabet = alphabet;
                listAlphabets.Add(alphabets);
            }
        }

    }
}