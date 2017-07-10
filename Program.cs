using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {

            SpeechSynthesizer  synth= new SpeechSynthesizer();
            synth.Speak("hello vishnu");
            GradeBook book=new GradeBook();
            book.AddGrades(91);
            book.AddGrades(89.5f);
            book.AddGrades(88);
            GradeStatistics stats = book.ComputeStatistics();
           Writeresult("Highest result ",stats.HighestGrade);
            Writeresult("Average",stats.AverageGrade);
            Writeresult("lowest",stats.LowesrGrade);
            Console.ReadLine();
           
        }

        static void Writeresult(string description,  float  result)
        {
            Console.WriteLine($"{description}:{result: f2}",description,result);
       
             
        }
    }
    
}
