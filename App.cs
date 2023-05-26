using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Class1;

namespace oaip12
{
    public class App
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public string Date_start { get; set; }
        public string Date_finish { get; set; }
        public string Status { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
