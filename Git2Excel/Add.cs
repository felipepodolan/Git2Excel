using System;
using System.Collections.Generic;
using System.IO.Compression;
using LibGit2Sharp;

namespace Git2Excel
{
    class Add
    {
        private List<String> excelFiles = new List<string>();
        private List<string> excelExtensions = new List<string> { ".xlsx", ".xls", ".xlsm" };

        public Add(String path)
        {
            string[] filePaths = System.IO.Directory.GetFiles(path);
            foreach (string filename in filePaths)
            {
                if (excelExtensions.Contains(System.IO.Path.GetExtension(filename)))
                {
                    excelFiles.Add(filename);
                }
            }
            foreach (string excelFile in excelFiles)
            {
                string newFilename = System.IO.Path.ChangeExtension(excelFile, ".zip");
                System.IO.File.Move(excelFile, newFilename);
                using (ZipArchive archive = ZipFile.Open(newFilename, ZipArchiveMode.Update))
                {
                    archive.ExtractToDirectory(path);
                }
                //System.IO.File.Move(newFilename, excelFile);
                
                using (var repo = new Repository(path))
                {
                    //repo.Ignore.AddTemporaryRules(excelExtensions);
                    //Commands.Stage(repo, "*");
                }

            }
        }

    }
}
