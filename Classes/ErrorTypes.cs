namespace DIOBank
{
    public static class ErrorTypes
    {
        public static string InsuficientBalance {get;private set;}
        public static string GenericError {get;private set;}

        static ErrorTypes()
        {
            InsuficientBalance = "Insuficient balance";
            GenericError = "Call the admins";
        }
    }
}