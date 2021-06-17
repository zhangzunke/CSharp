using Microsoft.Extensions.FileProviders;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FileSystem
{
    class Program
    {
        static void Main(string[] args)
        {

            var baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            IFileProvider fileProvider = new PhysicalFileProvider(baseDirectory);
            var contents = fileProvider.GetDirectoryContents("/");
            foreach (var item in contents)
            {
                Console.WriteLine(item.Name);
            }

            IFileProvider embeddedFileProvider = new EmbeddedFileProvider(typeof(Program).Assembly);
            var htmlContent = embeddedFileProvider.GetFileInfo("Emb.html");

            IFileProvider providerCom = new CompositeFileProvider(fileProvider, embeddedFileProvider);

            var comContents = providerCom.GetDirectoryContents("/");
            foreach (var item in comContents)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine("Hello World!");
        }
    }
}
