using System;
using System.Collections.Generic;
using basic_csharp.fundamentals;

namespace basic_csharp
{
    class Program {
        static void Main(string[] args) {
            var central = new ExercisesCentral(new Dictionary<string, Action>() {
                {"Fundamentals - First Program", FirstProgram.Run},
                {"Fundamentals - Comments", Comments.Run},
                {"Fundamentals - Variables And Constants", VariablesAndConstants.Run},
                {"Fundamentals - Inference", Inference.Run},
                {"Fundamentals - Interpolation", Interpolation.Run},
            });

            central.SelectAndRun();
        }
    }
}