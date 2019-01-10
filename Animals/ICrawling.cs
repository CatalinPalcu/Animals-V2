using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    interface ICrawling
    {
        double MaxCrawlingSpeed { get; set; }
        void Crawl();
    }
}
