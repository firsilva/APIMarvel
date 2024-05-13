using APIMarvel.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace APIMarvel.Utils
{
    public class Imprimir
    {
        public void arquivo(PersonagemModel personagens)
        {
            StreamWriter x;
            //string CaminhoArquivo = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string CaminhoArquivo = Environment.CurrentDirectory;
            x = File.CreateText(@CaminhoArquivo + @"\personagensmarvel.txt");

            foreach (var p in personagens.data.results)
            {
                x.WriteLine("Id: " + p.id);
                x.WriteLine("Name: " + p.name);
                x.WriteLine("Description: " + p.description);
                x.WriteLine("");
                x.WriteLine("   Comics:");
                foreach (var y in p.comics.items)
                {
                    x.WriteLine("       - " + y.name);
                }
                x.WriteLine("   Series:");
                foreach (var y in p.series.items)
                {
                    x.WriteLine("       - " + y.name);
                }
                x.WriteLine("   Stories:");
                foreach (var y in p.stories.items)
                {
                    x.WriteLine("       - " + y.name);
                }
                x.WriteLine("   Events:");
                foreach (var y in p.events.items)
                {
                    x.WriteLine("       - " + y.name);
                }

                x.WriteLine("-------------------------------------------------------------------------------");
            }
            x.Close();



        }
    }
}
