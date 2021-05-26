using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Teste.Servicos;

namespace Teste.Manutencao
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            Console.WriteLine();
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine(string.Format("-- {0} ", "Ancelmo Luiz"));
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine();

            Executar();

            stopwatch.Stop();

            Console.WriteLine();
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine(string.Format("-- PROGRAMA FINALIZADO EM {0}ms", stopwatch.ElapsedMilliseconds));
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine();
            Console.ReadKey();
        }

        private static void Executar()
        {
            var linhas = File.ReadLines(@".\Arquivos\input.3.in");


            for (int i = 0; i < linhas.ToList().Count; i++)
            {
                var linha = linhas.ToList()[i];

                Console.WriteLine();
                Console.WriteLine(string.Format("-- Teste #{0:00} ------------------------------", i + 1));
                Console.WriteLine(string.Format("Entrada: \t{0}", linha));
                Console.Write("Saída: \t\t");


                string residencial = FormatarTelefoneResidencial.DeveFormatarNumeroResidencial(linha);
                if (!string.IsNullOrEmpty(residencial))
                {
                    Console.WriteLine(residencial);
                    continue;
                }

                string movel = FormatarTelefoneCelular.DeveFormatarNumeroCelular(linha);
                if (!string.IsNullOrEmpty(movel))
                {
                    Console.WriteLine(movel);
                    continue;
                }

                string SUP = FormatarSup.DeveFormatarSUP(linha);
                if (!string.IsNullOrEmpty(SUP))
                {
                    Console.WriteLine(SUP);
                    continue;
                }

                string telefoniaFixa = FormatarTelefoniaFixa.DeveFormatarTelefoniaFixa(linha);
                if (!string.IsNullOrEmpty(telefoniaFixa))
                {
                    Console.WriteLine(telefoniaFixa);
                    continue;
                }

                string telefoniaMovel = FormatarTelefoniaMovel.DeveFormatarTelefoniaMovel(linha);
                if (!string.IsNullOrEmpty(telefoniaMovel))
                {
                    Console.WriteLine(telefoniaMovel);
                    continue;
                }

                string tvPorAssinatura = FormatarTvPorAssinatura.DeveFormatarTvPorAssinatura(linha);
                if (!string.IsNullOrEmpty(tvPorAssinatura))
                {
                    Console.WriteLine(tvPorAssinatura);
                    continue;
                }

                string numeroNaoGeografico = FormatarNumeroNaoGeografico.DeveFormatarNumeroNaoGeografico(linha);
                if (!string.IsNullOrEmpty(numeroNaoGeografico))
                {
                    Console.WriteLine(numeroNaoGeografico);
                    continue;
                }

                Console.WriteLine("-------------------------------------------");
                Console.WriteLine();
            }
        }
    }
}