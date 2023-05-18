using System;
namespace DataFinder.BLL
{
    /// <summary>
    /// Пользовательское исключение BusinessRuleException
    /// </summary>
    public class BusinessRuleException : Exception
    {
        public BusinessRuleException(string message) : base(message) { }
    }
}

