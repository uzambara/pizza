import React from "react";
import {Images} from "../../images";
import * as styles from "./pizza-logo.scss";

export function PizzaLogo() {
    return <a className={styles.pizzaLogo}>
        <img className={styles.pizzaLogoImg} src={Images.Shared.logo} alt="pizza"/>
        <h1 className={styles.pizzaLogoTitle}>Eat me</h1>
    </a>
}