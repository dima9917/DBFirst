using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vidzy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
            var _context = new VidzyEntities();
            _context.AddVideo("Video1", DateTime.Now, "Comedy");
            _context.AddVideo("Video2", DateTime.Now, "Comedy");
            _context.AddVideo("Video3", DateTime.Now, "Action");
            _context.AddVideo("Video4", DateTime.Now, "Action");
            _context.SaveChanges();

            Console.ReadKey();
            var vids = _context.Videos;
            foreach (var v in vids)
            {
                Console.WriteLine("{0}, {1}, {2}", v.Id, v.Name, v.ReleaseDate);
            }

            Console.ReadKey();
        }
    }
}
