﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBook
{
    class Program
    {
        class mybook
        {
            public string book_name;//이름
            public string first_publication;//초판 발행
            public string writer;//지은이
            public string spread;//펴낸이
            public string company;//펴낸곳
            public string edit;//편집
            public string plan;//기획
            public string editperson;//편집
            public string design;//디자인

        }
        static void Main(string[] args)
        {
            List<mybook> list = new List<mybook>();
            list.Add(new mybook()
            {
                book_name = "PHP 프로그래밍 입문",
                first_publication = "2013년 5월 20일",
                writer = "황재호",
                spread = "김태헌",
                company = "한빛아카데미(주)",
                plan = "김이화",
                editperson = "김이화",
                design = "여동일"
            });

            foreach (var item in list)
            {
                Console.WriteLine(item.book_name + item.first_publication + item.writer + item.spread + item.edit + item.plan + item.editperson + item.design);
            }
        }
    }
}
