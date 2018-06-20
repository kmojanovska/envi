using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Envi
{
    class Results
    {
        private List<Result> ResultsList { get; set; }

        public List<Result> GetResultsList
        {
            get { return ResultsList; }
        }

        public Results()
        {
            ResultsList = new List<Result>();
        }

        public void AddResult(Result result)
        {
            ResultsList.Add(result);
        }

        public string[] bestResults()
        {
            ResultsList = ResultsList.OrderBy(o => o.Score).Reverse().ToList();
            int r = Math.Min(10, ResultsList.Count());
            string[] lines = new string[r];
            for(int i = 0; i < r; i++)
            {
                lines[i]=ResultsList.ElementAt<Result>(i).ToString();
            }
            return lines;
        }
    }
}
