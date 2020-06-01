import React from "react";
import {Images} from "../../images";
import cn from "classnames";
import {PizzaLink} from "..";
import * as styles from "./pizza-logo.scss";

interface IPizzaLogoProps {
    className?: string
}

export function PizzaLogo(props: IPizzaLogoProps) {
    const {className} = props;
    return <PizzaLink className={cn(styles.pizzaLogo, className)} href="/">
        <img className={styles.pizzaLogoImg} src={Images.Shared.logo} alt="pizza"/>
        <h1 className={styles.pizzaLogoTitle}>Eat me</h1>
    </PizzaLink>
}