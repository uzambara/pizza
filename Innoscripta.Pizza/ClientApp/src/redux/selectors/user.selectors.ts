import {IGlobalState} from "../reducers";

const selectUserState = (state: IGlobalState) => state.user;
const selectCurrentUser = (state: IGlobalState) => state.user.currentUser;
const selectOrderHistory = (state: IGlobalState) => state.user.orderHistory;
const selectStatistic = (state: IGlobalState) => state.user.statistic;

export const userSelectors = {
    selectCurrentUser,
    selectOrderHistory,
    selectStatistic,
    selectUserState
};