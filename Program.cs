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
                {"Fundamentals - Point Notation", PointNotation.Run},
                {"Fundamentals - Reading Data", ReadingData.Run},
                {"Fundamentals - Number Format", NumberFormat.Run},
                {"Fundamentals - Type Casting", TypeCasting.Run},
                {"Fundamentals - Arithmetic Operators", ArithmeticOperators.Run},
                {"Fundamentals - Relational Operators", RelationalOperators.Run},
                {"Fundamentals - Logical Operators", LogicalOperators.Run},
                {"Fundamentals - Assign Operators", AssignOperators.Run},
                {"Fundamentals - Unary Operators", UnaryOperators.Run},
                {"Fundamentals - Ternary Operators", TernaryOperators.Run},
            });

            central.SelectAndRun();
        }
    }
}