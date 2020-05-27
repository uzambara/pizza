namespace Innoscripta.Pizza.Routing
{
    public static class ApiRoutes
    {
        public const string Root = "api/";
        public static class Account
        {
            private const string ControllerRoute = "account/";
            public const string Login = Root + ControllerRoute + "login";
            public const string Logout = Root + ControllerRoute + "logout";
            public const string Register = Root + ControllerRoute + "register";
            public const string GetCurrentUser = Root + ControllerRoute + "get-current-user";
        }

        public static class Product
        {
            private const string ControllerRoute = "product/";
            public const string GetAll = Root + ControllerRoute + "get-all";
        }

        public static class Order
        {
            private const string ControllerRoute = "order/";
            public const string Create = Root + ControllerRoute + "create";
        }
    }
}