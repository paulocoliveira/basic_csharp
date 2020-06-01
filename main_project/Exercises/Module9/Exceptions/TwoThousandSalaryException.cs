using System;
using System.Globalization;

namespace basic_csharp.Exercises.Module9.Exceptions{
    public class TwoThousandSalaryException : Exception{
        public TwoThousandSalaryException(string message) : base(message){ }
    }
}