using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mybook
{
    class Program
    {
        class Book
        {
            public string name;
            public string issue;
            public string wirter;
            public string published;
            public string publish_place;
            public string r_edit;
            public string plan;
            public string edit;
            public string design;
        }
        static void Main(string[] args)
        {
            Book mybook = new Book();
            mybook.name = "PHP 프로그래밍 입문";
            mybook.issue = "2013년 5월 20일";
            mybook.wirter = "황재호";
            mybook.published = "김태헌";
            mybook.publish_place = "한빛아카데미(주)";
            mybook.r_edit = "김현용";
            mybook.plan = "김이화";
            mybook.edit = "김이화";
            mybook.design = "여동일";
        }
    }
}
