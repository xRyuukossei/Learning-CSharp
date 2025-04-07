namespace ExceptionHandlingExercise1.Exceptions;
internal class WithdrawException : ApplicationException
{
    public WithdrawException(string message) : base(message) 
    {
    }
}
