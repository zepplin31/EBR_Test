using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBR_Test
{
    public class Grade : IComparable<Grade> 
    {
        public Grade() { }
        public Grade(string firstname, string surname, int score)
        {
            Firstname = firstname;
            Surname = surname;
            Score = score;
        }

        public string Firstname;
        public string Surname;
        public int Score;

        public int CompareTo(Grade other)
        {
            if (other == null)
                return 1;
            else
            {
                if (Score.CompareTo(other.Score) != 0)
                    return Score.CompareTo(other.Score) * -1;
                else
                {
                    if (Surname.CompareTo(other.Surname) != 0)
                        return Surname.CompareTo(other.Surname);

                    return Firstname.CompareTo(other.Firstname);
                }
            }
        }
    }
}
