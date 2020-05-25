import React, {memo} from "react";
import {PizzaCartItem} from "..";
import {CartItemsMap} from "../../redux/reducers";
import {CurrencyType} from "../../enums";
import * as styles from "./pizza-cart-list.scss";
import {currencyUtils} from "../../utils";

export interface IPizzaCartListProps {
    cartItemsMap: CartItemsMap,
    totalPrice: number,
    currencyType: CurrencyType
}

function PizzaCartListComponent(props: IPizzaCartListProps) {
    const {cartItemsMap, totalPrice, currencyType} = props;
    const priceText = `Total: ${currencyUtils.getPriceString(totalPrice, currencyType)}`;

    const itemKeys = Object.keys(cartItemsMap);
    if(itemKeys.length == 0) {
        return null;
    }

    return <ul className={styles.cartList}>
        {
            itemKeys.map((productId) =>
                <li className={styles.cartListItem} key={productId}>
                    <PizzaCartItem key={productId} cartItem={cartItemsMap[productId]} currencyType={currencyType}/>
                </li>)
        }
        <li className={styles.totalPrice} dangerouslySetInnerHTML={{__html: priceText}}/>
    </ul>
}

export const PizzaCartList = memo(PizzaCartListComponent);