using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emp_Manager.model {
    internal class Notice {

        string content;

        public Notice(string content) {
            this.content = content;
        }

        public string Content { get => content; set => content = value; }
    }
}
