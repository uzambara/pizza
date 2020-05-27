import {IBaseResponse, ResponseCode} from "../contratcs";
import {Toasts} from "../components";
import {LocalStorageService} from "../services";
import {localStorageKeys} from "../constants";

function handleCreateOrder(response: IBaseResponse) {
    switch (response.code) {
        case ResponseCode.Ok: {
            Toasts.success({title: "Заказ создан", text: "ожидайте доставку в течении часа"});
            LocalStorageService.remove(localStorageKeys.CART_ITEMS);
            break;
        }

    }
}


export const responseHandleUtils = {
    order: {
        handleCreateOrder
    }
};