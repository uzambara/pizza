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
            public const string History = Root + ControllerRoute + "history";
        }

        public static class Comment
        {
            private const string ControllerRoute = "comment/";
            public const string Create = Root + ControllerRoute + "create";
            public const string Get = Root + ControllerRoute + "get";
        }

        public static class User
        {
            private const string ControllerRoute = "user/";
            public const string OrderHistory = Root + ControllerRoute + "order-history";
            public const string Statistic = Root + ControllerRoute + "statistic";
        }
    }
}