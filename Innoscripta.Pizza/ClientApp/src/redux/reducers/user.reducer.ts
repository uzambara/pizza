import {IOrderModelRemote, IUserModelRemote, IUserStatisticModelRemote} from "../../models-remote";
import {UserAction, UserActionType} from "../actions";

export interface IUserState {
    currentUser: IUserModelRemote,
    orderHistory: Array<IOrderModelRemote>,
    statistic: IUserStatisticModelRemote
}

const initialState: IUserState = {
    currentUser: null,
    orderHistory: [],
    statistic: null
};

export function UserReducer(state: IUserState = initialState, action: UserAction): IUserState {
    switch (action.type) {
        case UserActionType.SetUser: {
            return {
                ...state,
                currentUser: action.payload
            }
        }
        case UserActionType.SetOrderHistory: {
            return {
                ...state,
                orderHistory: action.payload
            }
        }
        case UserActionType.SetUserStatistic: {
            return {
                ...state,
                statistic: action.payload
            }
        }
        default:
            return state;
    }
}