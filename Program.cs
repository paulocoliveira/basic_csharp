using System;
using System.Collections.Generic;
using basic_csharp.fundamentals;
using basic_csharp.controlStatements;
using basic_csharp.exercises;
using basic_csharp.classesAndMethods;

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
                {"Control Structures - If Statement", IfStatement.Run},
                {"Control Structures - If/Else Statement", IfElseStatement.Run},
                {"Control Structures - If/Else/If Statement", IfElseIfStatement.Run},
                {"Control Structures - Switch Statement", SwitchStatement.Run},
                {"Control Structures - While Statement", WhileStatement.Run},
                {"Control Structures - Do While Statement", DoWhileStatement.Run},
                {"Control Structures - For Statement", ForStatement.Run},
                {"Control Structures - For Each Statement", ForEachStatement.Run},
                {"Control Structures - Using Break", UsingBreak.Run},
                {"Control Structures - Using Continue", UsingContinue.Run},
                {"Exercises - 01", Exercise01.Run},
                {"Exercises - 02", Exercise02.Run},
                {"Exercises - 03", Exercise03.Run},
                {"Exercises - 04", Exercise04.Run},
                {"Classes and Methods - Members", Members.Run},
                {"Classes and Methods - Constructors", Constructors.Run},
                {"Classes and Methods - Methods with return", MethodsWithReturn.Run},
                {"Classes and Methods - Static Methods", StaticMethods.Run},
                {"Classes and Methods - Static Attributes", StaticAttributes.Run},
                {"Classes and Methods - Attribute Challenge", AttributeChallenge.Run},
            });

            central.SelectAndRun();
        }
    }
}