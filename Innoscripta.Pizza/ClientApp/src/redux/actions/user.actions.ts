import {IOrderModelRemote, IUserModelRemote, IUserStatisticModelRemote} from "../../models-remote";
import {Dispatch} from "redux";
import {UserService} from "../../services";
import {ResponseCode} from "../../contratcs";

export type UserAction =
    ISetOrderHistory
    | ISetStatistic
    | ISetUser;

const getOrderHistoryRemote = () => async (dispatch: Dispatch) => {
    const response = await UserService.GetOrderHistory();
    if(response.code == ResponseCode.Ok) {
        dispatch(setOrderHistory(response.orderHistory))
    }
};

const getStatisticRemote = () => async (dispatch: Dispatch) => {
    const response = await UserService.GetStatistic();
    if(response.code == ResponseCode.Ok) {
        dispatch(setStatistic(response.statistic))
    }
};

export enum UserActionType {
    SetOrderHistory = "SET_ORDER_HISTORY",
    SetUserStatistic = "SET_USER_STATISTIC",
    SetUser = "SET_USER"
}

interface ISetOrderHistory {
    type: UserActionType.SetOrderHistory,
    payload: Array<IOrderModelRemote>
}

const setOrderHistory = (orders: Array<IOrderModelRemote>): ISetOrderHistory => ({
    type: UserActionType.SetOrderHistory,
    payload: orders
});

interface ISetStatistic {
    type: UserActionType.SetUserStatistic,
    payload: IUserStatisticModelRemote
}

const setStatistic= (statistic: IUserStatisticModelRemote): ISetStatistic => ({
    type: UserActionType.SetUserStatistic,
    payload: statistic
});

interface ISetUser {
    type: UserActionType.SetUser,
    payload: IUserModelRemote
}

const setUser = (user: IUserModelRemote): ISetUser => ({
    type: UserActionType.SetUser,
    payload: user
});

export const userActions = {
    getOrderHistoryRemote,
    getStatisticRemote,
    setUser
};