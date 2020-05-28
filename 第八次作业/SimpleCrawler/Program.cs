using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleCrawler
{
    class SimpleCrawler
    {
        private Hashtable urls = new Hashtable();
        private int count = 0;
        static void Main(string[] args)
        {
            SimpleCrawler myCrawler = new SimpleCrawler();
            string startUrl = "http://www.cnblogs.com/dstang2000/";
            if (args.Length >= 1) startUrl = args[0];
            myCrawler.urls.Add(startUrl, false); //加入初始页面
            new Thread(myCrawler.Crawl).Start(); //开始爬行
        }

        private void Crawl()
        {
            Console.WriteLine("开始爬行了.... ");
            while (true)
            {
                string current = null;
                foreach (string url in urls.Keys) //找到一个还没下载过的链接
                {
                    if ((bool)urls[url]) continue; //已经下载过的不再下载
                    current = url;
                }

                if (current == null || count > 10) break;
                Console.WriteLine("爬行" + current + "页面!");
                string html = DownLoad(current);    // 下载
                urls[current] = true;
                count++;
                Parse(html);             //解析,并加入新的链接
                Console.WriteLine("爬行结束");
            }
        }


        public string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                return html;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }
        }

        private void Parse(string html)
        {
            string strRef = @"(href|HREF)[ ]*=[ ]*[""'][^""'#>]+[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                string rootURL = match.Value;
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1)
                          .Trim('"', '\"', '#', '>');
                if (strRef.Length == 0) continue;
                if (Regex.IsMatch(strRef, @"(html|htm)$"))
                {
                    strRef = absoluteUrl(strRef, rootURL);

                    if (urls[strRef] == null) urls[strRef] = false;

                }
                
            }
        }

        static private string absoluteUrl(string url, string rootUrl)
        {
            if (url.Contains("://"))
            {
                return url;
            }
            if (url.StartsWith("/"))
            {
                return rootUrl + url;
            }
            if (url.StartsWith("//"))
            {
                return "http:" + url;
            }
            if (url.StartsWith("../"))
            {
                url = url.Substring(3);
                int endIndex = rootUrl.LastIndexOf("/");
                return absoluteUrl(url, rootUrl.Substring(0, endIndex));
            }
            if (url.StartsWith("./"))
            {
                return absoluteUrl(url.Substring(2), rootUrl);
            }

            int end = rootUrl.LastIndexOf("/");
            return rootUrl.Substring(0, end) + "/" + url;
        }
    }
}

