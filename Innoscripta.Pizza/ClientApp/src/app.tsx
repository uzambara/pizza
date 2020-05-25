import React, {useState} from "react";
import {Route, Switch} from "react-router";
import {Routing} from "./routing";
import {CartPage, MainPage} from "./pages";
import {PizzaHeader} from "./components";
import * as styles from "./app.scss";
import {useSelector} from "react-redux";
import {cartSelectors} from "./redux/selectors";

export function App() {
    const [height, setHeightSize] = useState(0);
    const totalPrice = useSelector(cartSelectors.selectTotalPrice);
    return <>
        <PizzaHeader className={styles.header} onHeightChanged={setHeightSize} totalPrice={totalPrice}/>
        <Switch>
            <Route exact path={Routing.MainPage}>
                <MainPage className={styles.mainContainer} paddingTop={height}/>
            </Route>
            <Route exact path={Routing.Cart}>
                <CartPage className={styles.mainContainer} paddingTop={height} totalPrice={totalPrice}/>
            </Route>
        </Switch>
    </>
}