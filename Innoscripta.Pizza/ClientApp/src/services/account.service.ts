import {
    IGetCurrentUserResponse,
    ILoginRequest,
    ILoginResponse, ILogoutResponse,
    IRegisterRequest,
    IRegisterResponse
} from "../contratcs/account";
import {fetchUtil} from "../utils";
import {ApiRouting} from "../routing";

export class AccountService {
    public static async login(request: ILoginRequest): Promise<ILoginResponse> {
        return fetchUtil.post<ILoginResponse>(ApiRouting.Account.login, request);
    }

    public static logout(): Promise<ILogoutResponse>  {
        return fetchUtil.post<ILogoutResponse>(ApiRouting.Account.logout);
    }

    public static async register(request: IRegisterRequest): Promise<IRegisterResponse> {
        return fetchUtil.post<IRegisterResponse>(ApiRouting.Account.register, request);
    }

    public static async getCurrentUser(): Promise<IGetCurrentUserResponse> {
        return fetchUtil.get<IGetCurrentUserResponse>(ApiRouting.Account.getCurrentUser);
    }
}