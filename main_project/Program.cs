using System;
using System.Collections.Generic;
using basic_csharp.Fundamentals;
using basic_csharp.ControlStatements;
using basic_csharp.ClassesAndMethods;
using basic_csharp.Collections;
using basic_csharp.ObjectOriented;
using basic_csharp.MethodsAndFunctions;
using basic_csharp.Exceptions;
using basic_csharp.Api;
using basic_csharp.AdvancedTopics;
using Encapsulation;
using basic_csharp.Exercises.Module3;
using basic_csharp.Exercises.Module4;
using basic_csharp.Exercises.Module5;
using basic_csharp.Exercises.Module6;
using basic_csharp.Exercises.Module7;
using basic_csharp.Exercises.Module9;
using basic_csharp.Exercises.Challenge;



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
                {"Classes and Methods - Members", Members.Run},
                {"Classes and Methods - Constructors", Constructors.Run},
                {"Classes and Methods - Methods with return", MethodsWithReturn.Run},
                {"Classes and Methods - Static Methods", StaticMethods.Run},
                {"Classes and Methods - Static Attributes", StaticAttributes.Run},
                {"Classes and Methods - Attribute Challenge", AttributeChallenge.Run},
                {"Classes and Methods - Params", Params.Run},
                {"Classes and Methods - Named Params", NamedParams.Run},
                {"Classes and Methods - Getters and Setters", GettersAndSetters.Run},
                {"Classes and Methods - Properties", Properties.Run},
                {"Classes and Methods - Read Only", ReadOnly.Run},
                {"Classes and Methods - Enums", Enums.Run},
                {"Classes and Methods - Using Struct", UsingStruct.Run},
                {"Classes and Methods - Struct vs Class", StructVsClass.Run},
                {"Classes and Methods - Value vs Reference", ValueVsReference.Run},
                {"Classes and Methods - Parameters by Reference", ParametersByReference.Run},
                {"Classes and Methods - Standard Parameter", StandardParameter.Run},
                {"Collections - Using Arrays", UsingArrays.Run},
                {"Collections - Using Lists", UsingLists.Run},
                {"Collections - Using Array Lists", UsingArrayLists.Run},
                {"Collections - Using Sets", UsingSets.Run},
                {"Collections - Using Queues", UsingQueues.Run},
                {"Collections - Equality", Equality.Run},
                {"Collections - Using Stacks", UsingStacks.Run},
                {"Collections - Using Dictionaries", UsingDictionaries.Run},
                {"Object-Oriented - Inheritance", Inheritance.Run},
                {"Object-Oriented - This Constructor", ThisConstructor.Run},
                {"Object-Oriented - Encapsulation", ObjectOriented.Encapsulation.Run},
                {"Object-Oriented - Polymorphism", Polymorphism.Run},
                {"Object-Oriented - Abstract Class", AbstractClass.Run},
                {"Object-Oriented - Interface", Interface.Run},
                {"Object-Oriented - Sealed Class", SealedClass.Run},
                {"Methods and Functions - Using Lambda", UsingLambda.Run},
                {"Methods and Functions - Lambda Delegate", LambdaDelegate.Run},
                {"Methods and Functions - Using Delegates", UsingDelegates.Run},
                {"Methods and Functions - Delegate Anonymous Function", DelegateAnonymousFunction.Run},
                {"Methods and Functions - Delegate As Parameter", DelegateAsParameter.Run},
                {"Methods and Functions - Extension Methods", ExtensionMethods.Run},
                {"Exceptions - First Exception", FirstException.Run},
                {"Exceptions - Custom Exceptions", CustomExceptions.Run},
                {"Api - First File", FirstFile.Run},
                {"Api - Reading Files", ReadingFiles.Run},
                {"Api - Using FileInfo", UsingFileInfo.Run},
                {"Api - Directories", Directories.Run},
                {"Api - Using DirectoryInfo", UsingDirectoryInfo.Run},
                {"Api - Using Path", UsingPath.Run},
                {"Api - Using DateTime", UsingDateTime.Run},
                {"Api - Using TimeSpan", UsingTimeSpan.Run},
                {"Advanced Topics - LINQ #01", LINQ1.Run},
                {"Advanced Topics - LINQ #02", LINQ2.Run},
                {"Advanced Topics - Nullables", Nullables.Run},
                {"Advanced Topics - Dynamics", Dynamics.Run},
                {"Advanced Topics - Generics", Generics.Run},
                {"Exercises - 01", Exercise01.Run},
                {"Exercises - 02", Exercise02.Run},
                {"Exercises - 03", Exercise03.Run},
                {"Exercises - 04", Exercise04.Run},
                {"Exercises - 05", Exercise05.Run},
                {"Exercises - 06", Exercise06.Run},
                {"Exercises - 07", Exercise07.Run},
                {"Exercises - 08", Exercise08.Run},
                {"Exercises - 09", Exercise09.Run},
                {"Challenge", ChallengeExercise.Run},
            });

            central.SelectAndRun();
        }
    }
}