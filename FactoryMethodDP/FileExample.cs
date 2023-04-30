using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDP
{
    class FileExample
    {
        public static void Use()
        {
            FileFactory fileFactory = new FileFactory();

            fileFactory.AddFile(new CVFileFactory().CreateFile());
            fileFactory.AddFile(new RaportFileFactory().CreateFile());
            fileFactory.AddFile(new InvoiceFileFactory().CreateFile());

            Console.WriteLine(fileFactory.Files);
        }
    }

    abstract class File { }

    interface IFile
    {
        File CreateFile();
    }

    class CVFileFactory : IFile
    {
        public File CreateFile()
        {
            throw new NotImplementedException();
        }
    }

    class RaportFileFactory : IFile
    {
        public File CreateFile()
        {
            throw new NotImplementedException();
        }
    }

    class InvoiceFileFactory : IFile
    {
        public File CreateFile()
        {
            throw new NotImplementedException();
        }
    }

    class FileFactory
    {
        public List<File> Files { get; }

        public FileFactory()
        {
            Files = new List<File>();
        }

        public void AddFile(File file)
        {
            Files.Add(file);
        }
    }

}
