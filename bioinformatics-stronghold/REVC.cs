using System;

namespace bioinformatics_stronghold;

public class REVC
{
     public static string ComplementingAStrandOfDNA(string s)
        {
            var result = "";
            for (var i = s.Length - 1; i >= 0; i--)
            {
                switch (s.Substring(i, 1))
                {
                    case "A":
                        result += 'T';
                        break;
                    case "C":
                        result += 'G';
                        break;
                    case "G":
                        result += 'C';
                        break;
                    case "T":
                        result += 'A';
                        break;
                }
            }

            return result;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(ComplementingAStrandOfDNA(
                "GGCATGCATGGAGCTTCTAGCTGGACTACAGCGCAACCAAAACAGAAGTTTCATGTAGGCGAAGCATTTTCGTCCTTCCAGCTAACGAACGCATGTTATCTATTGTCATTAGGACCAATAGCTCGGGAACACCAGGTTTGCGCGCCTGTTGTGGCTCCCCCAGCCTGGGTTTTTACCCCCGAAACAGTTGTTGCCGCATCCCGCACAGAGGAGGATTGCAGTTGGTAATAAACGTGTGAGAGAGGTGCTTAGCATGCGTGTTCGAGGTTGCTACGTTAGGACTGTCCCTCATCCGCATATCATCAGCTTTTAGATACAGTCTGTACATACATACCATAAGTCGGGTGCGACTGTATTTCATTAAATAATAACCGGGTGAAATCAGATGCCCACCGCCCGTATAAGGTACATGTGGTGGTGGTTCACTTGTTCCTGAGGTATTTGCAGCTCCCAATCGATTGAATTGTATCTTCTCGCATCCCCATATGTATCGACCTTCTTTATAGCGACTTAGTGAGGATAAGTGAGAGACGGAAGTGAATATTAGCCCCATCGAGGTGCACCTGGAGCTTGCCTCATTGCTCTTCACGTGAAATTGTGGGAAACCAACTACGAATGCGTGGTTCACATCCCTTCTACGCTGTTCGGGTGTCCACTGATAAGGTTGTAGAGGGTAGAAGAGAATATAAACCTACTGACTAGCCGCTGACAAGTGTTGCCGACTGGCCTGAATGTTCGGCTTGGCTCGGGATCCAATGACAGTGTGCTTCGAGGTAATAACATTCAACCGAGGTGTTTCGTCACCCTGTTAAGAAAATGTATCAAGTTGGATGCAATAACCCCTCTAATGGCGTGGGGTACGCATAATACGTATTAACGCTCATATTTCAGAGCCCATGAATATAGGTTTACTCGTAGAGCAAGCAGAGAATTAAGAGGTCCATATTAGAACCACAT"));

        }
    
}