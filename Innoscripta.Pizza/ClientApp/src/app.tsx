import React, {useEffect, useState} from "react";
import {Route, Switch} from "react-router";
import {Routing} from "./routing";
import {CartPage, CommentsPage, MainPage, ProfilePage} from "./pages";
import {PizzaHeader} from "./components";
import {useDispatch, useSelector} from "react-redux";
import {cartSelectors, languageSelectors, productsSelectors} from "./redux/selectors";
import {productUtils} from "./utils/products.utils";
import {ProductType} from "./enums";
import {accountActions, cartActions, productsActions} from "./redux/actions";
import {ToastContainer, Zoom} from "react-toastify";
import * as styles from "./app.scss";
import 'react-toastify/dist/ReactToastify.css';
import {LocalStorageService} from "./services";
import {CartItemsMap} from "./redux/reducers";
import {localStorageKeys} from "./constants";

export function App() {
    const [height, setHeightSize] = useState(0);
    const totalPrice = useSelector(cartSelectors.selectTotalPrice);
    const dispatch = useDispatch();

    const pages = useSelector(languageSelectors.selectPages);
    const products = useSelector(productsSelectors.selectProductItems);
    const pizzaProducts = productUtils.getProductsByType(products, ProductType.Pizza);
    const drinkProducts = productUtils.getProductsByType(products, ProductType.Drink);

    useEffect(() => {
        dispatch(productsActions.fetchProductsRemote());
        dispatch(accountActions.tryAuthenticate());

        const cartItemsMap = LocalStorageService.getItem<CartItemsMap>(localStorageKeys.CART_ITEMS) || {};
        dispatch(cartActions.setCartItemsMap(cartItemsMap))
    },[]);

    return <>
        <ToastContainer className={styles.toastContainer}
                        autoClose={8000}
                        hideProgressBar={true}
                        transition={Zoom}/>
        <PizzaHeader className={styles.header} onHeightChanged={setHeightSize} totalPrice={totalPrice}/>
        <Switch>
            <Route exact path={Routing.MainPage}>
                <MainPage className={styles.mainContainer} paddingTop={height} products={pizzaProducts} header={pages.PizzaPage.Title}/>
            </Route>
            <Route exact path={Routing.DrinksMenu}>
                <MainPage className={styles.mainContainer} paddingTop={height} products={drinkProducts} header={pages.DrinksPage.Title}/>
            </Route>
            <Route exact path={Routing.Cart}>
                <CartPage className={styles.mainContainer} paddingTop={height} totalPrice={totalPrice} header={pages.CartPage.Title}/>
            </Route>
            <Route exact path={Routing.Comments}>
                <CommentsPage className={styles.mainContainer} paddingTop={height} header={pages.CommentsPage.Title}/>
            </Route>
            <Route exact path={Routing.Profile}>
                <ProfilePage className={styles.mainContainer} paddingTop={height} header={pages.ProfilePage.Title}/>
            </Route>
        </Switch>
    </>
}