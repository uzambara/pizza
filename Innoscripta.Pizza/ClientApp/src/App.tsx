import React from "react";
import {Route, Switch} from "react-router";
import {Routing} from "./routing";
import {MainPage} from "./pages";
import {PizzaHeader} from "./components";
import * as styles from "./app.scss";

export function App() {
    return <>
        <PizzaHeader className={styles.header}/>
        <Switch>
            <Route exact path={Routing.MainPage}>
                <MainPage className={styles.mainContainer}/>
            </Route>
        </Switch>
    </>
}