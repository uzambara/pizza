import {memo} from "react";
import {PizzaButton} from "..";
import React from "react";
import cn from "classnames";
import * as styles from "./pizza-counter.scss";

interface IPizzaCounterProps {
    value,
    onIncrease: () => void,
    onDecrease: () => void,
    className?:  string
}

function PizzaCounterComponent(props: IPizzaCounterProps) {
    const {value, onIncrease, onDecrease, className} = props;

    return <div className={cn(styles.wrapper, className)}>
        <PizzaButton onClick={onDecrease} style={"submit"} className={styles.button}>–</PizzaButton>
        <span className={styles.counterValue}>{value}</span>
        <PizzaButton onClick={onIncrease} style={"submit"} className={styles.button}>+</PizzaButton>
    </div>
}

export const PizzaCounter = memo(PizzaCounterComponent);