import {IBaseResponse, ResponseCode} from "../../contratcs";
import {IContentStrings} from "../../content-strings";
import {Toasts} from "../../components";

function handleLogin(response: IBaseResponse, contentStrings: IContentStrings) {
    switch (response.code) {
        case ResponseCode.Ok: {
            const text = contentStrings.Account.LoginSuccessfully;
            Toasts.success({text});
            break;
        }
        case ResponseCode.UserNotFound: {
            const errorText = contentStrings.Errors.Account.UserNotFound;
            Toasts.error({text: errorText});
            break;
        }
        case ResponseCode.IncorrectPassword: {
            const errorText = contentStrings.Errors.Account.UserNotFound;
            Toasts.error({text: errorText});
            break;
        }
        default: {
            Toasts.error({text: contentStrings.Errors.CommonError});
        }
    }
}

function handleLogout(response: IBaseResponse, contentStrings: IContentStrings) {
    switch (response.code) {
        case ResponseCode.Ok: {
            const text = contentStrings.Account.LogoutSuccessfully;
            Toasts.success({text});
            break;
        }
        default: {
            Toasts.error({text: contentStrings.Errors.CommonError});
        }
    }
}

function handleRegister(response: IBaseResponse, contentStrings: IContentStrings) {
    switch (response.code) {
        case ResponseCode.Ok: {
            const text = contentStrings.Account.RegisteredSuccessfully;
            Toasts.success({text});
            break;
        }
        case ResponseCode.UserWithTheSamePhoneExists: {
            const text = contentStrings.Errors.Account.UserWithTheSameNumberExists;
            Toasts.success({text});
            break;
        }
        default: {
            Toasts.error({text: contentStrings.Errors.CommonError});
        }
    }
}

export const account = {
    handleRegister,
    handleLogin,
    handleLogout
};