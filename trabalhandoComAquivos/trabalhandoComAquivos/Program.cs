using System;
using System.IO;
namespace trabalhandoComAquivos
{ 
    /* programa para a duplicação de arquivos porem nao funcionou!
     * 
     * 
     * */
    class Program
    {
        static void Main(string[] args)
        {
            string soucePath = @"F:\ws-vs2019\file1.txt";
            string targetPath = @"F:\ws-vs2019\file2.txt";


            try
            {
                FileInfo fileInfo = new FileInfo(soucePath);
                fileInfo.CopyTo(targetPath);
            }
            catch (IOException m)
            {
                Console.WriteLine(" Um erro ocorreu");
                Console.WriteLine(m.Message);

              
            }

        }
    }
}
