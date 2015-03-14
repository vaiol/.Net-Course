using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetLaba1
{
    class Spec
    {
        public List<string> terms;
        public List<string> tasks; 
 
        public Spec()
        {
            terms = new List<string>();
            tasks = new List<string>();
        }

        public void addTerms(string value, string desc)
        {
            if (string.IsNullOrEmpty(desc) || string.IsNullOrEmpty(value))
            {
                return;
            }
            string result = "<tr><td>" + value + "</td> <td>" + desc + "</td></tr>";
            terms.Add(result);
        }
        public void addTasks(string value, string desc)
        {
            if (string.IsNullOrEmpty(desc) || string.IsNullOrEmpty(value))
            {
                return;
            }
            string result = "<tr><td>" + value + "</td> <td>" + desc + "</td></tr>";
            tasks.Add(result);
        }

        public string getTerms()
        {
            string result = "";
            if (!terms.Any())
            {
                return result;
            }
            foreach(string tmp in terms)
            {
                result += tmp;
            }
            return result;
        }

        public string getTasks()
        {
            string result = "";
            if (!tasks.Any())
            {
                return result;
            }
            foreach (string tmp in tasks)
            {
                result += tmp;
            }
            return result;
        }
    }
}
