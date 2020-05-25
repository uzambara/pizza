import React, {useEffect, useMemo, useState} from "react";
import {Route, Switch} from "react-router";
import {Routing} from "./routing";
import {CartPage, MainPage} from "./pages";
import {PizzaHeader} from "./components";
import * as styles from "./app.scss";
import {useDispatch, useSelector} from "react-redux";
import {cartSelectors, productsSelectors} from "./redux/selectors";
import {productUtils} from "./utils/products.utils";
import {ProductType} from "./enums";
import {productsActions} from "./redux/actions";

export function App() {
    const [height, setHeightSize] = useState(0);
    const totalPrice = useSelector(cartSelectors.selectTotalPrice);
    const dispatch = useDispatch();

    const products = useSelector(productsSelectors.selectProductItems);

    const pizzaProducts = productUtils.getProductsByType(products, ProductType.Pizza);
    const drinkProducts = productUtils.getProductsByType(products, ProductType.Drink);

    useEffect(() => {
        dispatch(productsActions.fetchProductsRemote());
    },[]);

    return <>
        <PizzaHeader className={styles.header} onHeightChanged={setHeightSize} totalPrice={totalPrice}/>
        <Switch>
            <Route exact path={Routing.MainPage}>
                <MainPage className={styles.mainContainer} paddingTop={height} products={pizzaProducts} header="Hot pizza"/>
            </Route>
            <Route exact path={Routing.DrinksMenu}>
                <MainPage className={styles.mainContainer} paddingTop={height} products={drinkProducts} header="Cold drinks"/>
            </Route>
            <Route exact path={Routing.Cart}>
                <CartPage className={styles.mainContainer} paddingTop={height} totalPrice={totalPrice}/>
            </Route>
        </Switch>
    </>
}