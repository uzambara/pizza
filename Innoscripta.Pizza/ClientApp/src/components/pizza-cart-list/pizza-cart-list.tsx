import React, {memo} from "react";
import {PizzaCartItem} from "..";
import {CartItemsMap} from "../../redux/reducers";
import {CurrencyType} from "../../enums";
import * as styles from "./pizza-cart-list.scss";
import {currencyUtils} from "../../utils";
import {ICartItem} from "../../models";

export interface IPizzaCartListProps {
    cartItems: ICartItem[],
    totalPrice: number,
    currencyType: CurrencyType
}

function PizzaCartListComponent(props: IPizzaCartListProps) {
    const {cartItems, totalPrice, currencyType} = props;
    const priceText = `Total: ${currencyUtils.getPriceString(totalPrice, currencyType)}`;

    return <ul className={styles.cartList}>
        {
            cartItems.map((cartItem) =>
                <li className={styles.cartListItem} key={cartItem.productId}>
                    <PizzaCartItem key={cartItem.productId} cartItem={cartItem} currencyType={currencyType}/>
                </li>)
        }
        <li className={styles.totalPrice} dangerouslySetInnerHTML={{__html: priceText}}/>
    </ul>
}

export const PizzaCartList = memo(PizzaCartListComponent);