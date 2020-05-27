const rootPath = process.env.NODE_ENV == 'development'
    ? "http://localhost:5000/"
    : "/";

export class ApiRouting {
    public static Root: string = rootPath;
    private static apiPrefix: string = "api/";
    private static accountRoute: string = ApiRouting.apiPrefix + "account/";
    private static productRoute: string = ApiRouting.apiPrefix + "product/";
    private static orderRoute: string = ApiRouting.apiPrefix + "order/";

    public static readonly Account = {
        login: ApiRouting.Root + ApiRouting.accountRoute + "login",
        logout: ApiRouting.Root + ApiRouting.accountRoute + "logout",
        register: ApiRouting.Root + ApiRouting.accountRoute + "register",
        getCurrentUser: ApiRouting.Root + ApiRouting.accountRoute + "get-current-user",
    };

    public static readonly Product = {
        getAll: ApiRouting.Root + ApiRouting.productRoute + "get-all",
    };

    public static readonly Order = {
        create: ApiRouting.Root + ApiRouting.orderRoute + "create",
    };
}