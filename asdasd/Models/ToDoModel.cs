using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asdasd.Models
{
    internal class ToDoModel
    {
        public int ID { get; set; }
        public string Task { get; set; }
        public bool IsCompleted { get; set; } = false;
        public bool Delete { set; get; } = false;
    }
}
