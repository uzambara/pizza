namespace Innoscripta.Pizza.Contracts
{
    public enum ResponseCode
    {
        Ok = 100,

        // Errors
        InnerError = 400,
        UserNotFound = 401,
        IncorrectPassword = 402,
        NotAuthenticated = 403,
        UserWithTheSamePhoneExists = 404
    }
}