import React, {memo} from "react";
import {CurrencyType} from "../../enums";
import {currencyUtils} from "../../utils";
import * as styles from "./pizza-cart.scss";
import {Images} from "../../images";
import cn from "classnames";
import {PizzaLink} from "..";
import {Routing} from "../../routing";

export interface IPizzaCartProps {
    totalPrice: number,
    currencyType: CurrencyType,
    className?: string
}

function PizzaCartComponent(props: IPizzaCartProps) {
    const {totalPrice, currencyType, className} = props;

    const text = `${currencyUtils.getPriceString(totalPrice, currencyType)}`;
    return <PizzaLink className={cn(styles.cart, className)} href={Routing.Cart}>
        <img src={Images.Shared.cart} alt="cart" className={styles.cartImage}/>
        <span className={styles.cartText} dangerouslySetInnerHTML={{__html: text}}/>
    </PizzaLink>
}

export const PizzaCart = memo(PizzaCartComponent);