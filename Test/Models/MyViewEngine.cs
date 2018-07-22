using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test.Models
{
    public class MyViewEngine : RazorViewEngine
    {
        public MyViewEngine()
        {
            ViewLocationFormats = new[]
            {
                "~/Views/{1}/{0}.cshtml",
                "~/Views/Shared/{0}.cshtml",
                "~/Views/Client/{1}/{0}.cshtml",//Client为Controllers控制器下的文件夹
                //可以一直往下添
                "~/Views/Admin/{1}/{0}.cshtml"//Admin为Controllers控制器下的文件夹
                //注：{1}表示Controller的名称，{0}表示视图名称
            };
        }
    }
}