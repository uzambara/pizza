import React, {memo, useCallback} from "react";
import {ICartItem} from "../../models";
import * as styles from "./pizza-cart-item.scss";
import {PizzaCounter} from "../pizza-counter/pizza-counter";
import {currencyUtils} from "../../utils";
import {CurrencyType} from "../../enums";
import {useDispatch} from "react-redux";
import {cartActions} from "../../redux/actions";

export interface IPizzaCartItem {
    cartItem: ICartItem,
    currencyType: CurrencyType
}

function PizzaCartItemComponent(props: IPizzaCartItem) {
    const {cartItem, currencyType} = props;
    const {imageUrl, price, count, productId, name} = cartItem;
    const dispatch = useDispatch();
    const deleteItem = () => dispatch(cartActions.RemoveItem(productId));

    const onIncreaseCount = useCallback(() => {
        dispatch(cartActions.ChangeItemCount(productId, 1));
    }, []);
    const onDecreaseCount = useCallback(() => {
        dispatch(cartActions.ChangeItemCount(productId, -1));
    }, []);

    return <div className={styles.wrapper}>
        <img src={imageUrl} alt="product" className={styles.productImage}/>
        <div className={styles.counterAndNameWrapper}>
            <PizzaCounter value={count} onIncrease={onIncreaseCount} onDecrease={onDecreaseCount} className={styles.counter}/>
            <h3 className={styles.productName}>{name}</h3>
        </div>
        <span className={styles.price} dangerouslySetInnerHTML={{__html: currencyUtils.getPriceString(price, currencyType)}}/>
        <button className={styles.deleteButton} onClick={deleteItem}>✖</button>
    </div>
}

export const PizzaCartItem = memo(PizzaCartItemComponent);