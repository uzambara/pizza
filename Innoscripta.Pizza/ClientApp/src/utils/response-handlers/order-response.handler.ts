import {IBaseResponse, ResponseCode} from "../../contratcs";
import {Toasts} from "../../components";
import {LocalStorageService} from "../../services";
import {localStorageKeys} from "../../constants";
import {IContentStrings} from "../../content-strings";

function handleCreateOrder(response: IBaseResponse, contentStrings: IContentStrings) {
    switch (response.code) {
        case ResponseCode.Ok: {
            const {Toasts: {MakeOrderToast: {Title, Text}}} = contentStrings;
            Toasts.success({title: Title, text: Text});
            LocalStorageService.remove(localStorageKeys.CART_ITEMS);
            break;
        }
        default: {
            Toasts.error({text: contentStrings.Errors.CommonError});
        }
    }
}

export const order = {
    handleCreateOrder
};