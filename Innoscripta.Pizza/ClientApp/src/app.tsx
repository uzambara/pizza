import React, {useState} from "react";
import {Route, Switch} from "react-router";
import {Routing} from "./routing";
import {MainPage} from "./pages";
import {PizzaHeader} from "./components";
import * as styles from "./app.scss";

export function App() {
    const [height, setHeightSize] = useState(0);
    return <>
        <PizzaHeader className={styles.header} onHeightChanged={setHeightSize}/>
        <Switch>
            <Route exact path={Routing.MainPage}>
                <MainPage className={styles.mainContainer} paddingTop={height}/>
            </Route>
        </Switch>
    </>
}