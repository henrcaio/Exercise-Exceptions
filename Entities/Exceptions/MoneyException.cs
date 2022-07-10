using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseExceptions.Entities.Exceptions {
    class MoneyException : ApplicationException {
    
        public MoneyException(string message) : base(message) { }
    }
}
