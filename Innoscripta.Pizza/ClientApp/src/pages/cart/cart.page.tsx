import React, {memo} from "react";
import * as styles from "./cart.page.scss";
import {IPageProps} from "../page-props";
import {withPageWrapper} from "../../hocs";
import {useSelector} from "react-redux";
import {cartSelectors} from "../../redux/selectors";
import {PizzaCartItem} from "../../components/pizza-cart-item/pizza-cart-item";

export interface ICartPageProps extends IPageProps {
}

function CartPageComponent(props: ICartPageProps) {
    const {} = props;
    const cart = useSelector(cartSelectors.selectCart);
    return <>
        <h2 className={styles.title}>Your order</h2>
        {
            Object.keys(cart.items).map((productId) =>
                <PizzaCartItem key={productId} cartItem={cart.items[productId]}/>)
        }
    </>
}

export const CartPage = memo(withPageWrapper<ICartPageProps>(CartPageComponent));