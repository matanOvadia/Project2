using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopForum
{
    public class Complaint
    {

        private String submitter;
        private String title;
        private String content;

        public Complaint(String submitter, String title, String content)
        {
            this.submitter = submitter;
            this.title = title;
            this.content = content;
        }

    }
}
