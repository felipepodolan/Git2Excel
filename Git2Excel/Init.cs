using System;
using LibGit2Sharp;

namespace Git2Excel
{
    public class Init
    {
       
        public Init(String path)
        {
            Repository.Init(path);
        }

    }
}