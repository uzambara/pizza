import React from "react";
import {Route, Switch} from "react-router";
import {Routing} from "./routing";
import {MainPage} from "./pages";
import {PizzaHeader} from "./components";

export function App() {
    return <div>
        <PizzaHeader/>
        <Switch>
            <Route exact path={Routing.MainPage}>
                <MainPage/>
            </Route>
        </Switch>
    </div>
}