using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace _02_Claims
{
    public class Claims_Repository : Claims_Content_Repository
    {
        public List<ClaimContent> GetAllClaims()
        {
            List<ClaimContent> allClaims = new List<ClaimContent>();
            foreach(ClaimContent content in _contentDirectory)
            {
                allClaims.Add(content);
                return allClaims;
            }
        }
        public Queue<ClaimContent> ClaimQueue()
        {
            Queue<ClaimContent> queue = new Queue<ClaimContent>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            while (queue.Count > 0)
            {
                var val = queue.Dequeue();
                Console.WriteLine("Current: {0}", val);

                if (queue.Count > 0)
                {
                    var next = queue.Peek();
                    Console.WriteLine("Next: {0}", next);
                }
            }
        }
    }
}
