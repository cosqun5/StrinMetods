using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_methods.Models
{
    public class Custom
    {
        public bool Start(string name, char chars)
        {
            if (name[0] == chars)
            {
                return true;
            }
            return false;
      

        }
        public bool End(string name , char chars)
        {
            if (name[name.Length-1] == chars)
            {
                return true;
            }
            return false;



        }
        public bool Contain(string name, char chars)
        {
            for (int i = 0; i < name.Length; i++)
            {
              if (name[i]== chars)
                {
                    return true;
                }
            
            }
            return false;
        }

        public int Index(string name, char chars)
        {
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] == chars)
                {
                    return i;
                }
            }
            return -1;

        }

        public int LastIndex(string name, char chars)
        {
            for (int i = name.Length - 1; i >= 0; i--)
            {
                if (name[name.Length - 1]==chars)
                {
                    return i;
                }
            }
            return -1;
        }
        
        public string Replace(string Name, char oldchar,char newchar)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < Name.Length; i++)
            {
                if (Name[i]==oldchar)
                {
                    sb.Append(newchar);
                     
                }
                else
                {
                    sb.Append(Name[i]);
                }
            }
                return sb.ToString();
        }
        public string Remove(string Name ,char num)
        {
            StringBuilder  sb = new StringBuilder();
            for (int i = 0; i < Name.Length; i++)
            {
                if (Name[i]==num)
                {
                    sb.Remove(2,2);
                }
                else
                {
                    sb.Append(Name[i]);
                }
            }
            return sb.ToString();
        }
        public string Trim(string Name)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < Name.Length; i++)
            {
                if (Name[i] !=' ')
                {

                }
            }
            return sb.ToString();
        }
    }
}
