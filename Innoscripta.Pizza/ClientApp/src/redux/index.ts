import {applyMiddleware, createStore} from "redux";
import {rootReducer} from "./reducers";
import {composeWithDevTools} from "redux-devtools-extension/developmentOnly";
import {middlewares} from "./middlewares";



export const configureStore = () => createStore(
    rootReducer,
    composeWithDevTools(applyMiddleware(...middlewares))
);