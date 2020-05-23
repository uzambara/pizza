import "./main.scss";
import * as ReactDOM from "react-dom";
import { App } from "./app";
import React from "react";
import {Provider} from "react-redux";
import {BrowserRouter} from "react-router-dom";
import {configureStore} from "./redux";

const store = configureStore();

ReactDOM.render(<Provider store={store}>
    <BrowserRouter>
        <App/>
    </BrowserRouter>
</Provider>, document.getElementById("app"));