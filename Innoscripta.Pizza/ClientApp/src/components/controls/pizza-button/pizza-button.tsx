import React, {memo, PropsWithChildren} from "react";
import cn from "classnames";
import * as styles from "./pizza-button.scss";


export interface IPizzaButtonProps {
    onClick: () => void,
    className?: string,
    type: "submit" | "alert" | "success" | "simple"
}

function PizzaButtonComponent(props: PropsWithChildren<IPizzaButtonProps>) {
    const {onClick, children, className, type} = props;

    return <button
        onClick={onClick}
        className={cn(className, styles.button, {
            [styles.buttonAlert]: type === "alert",
            [styles.buttonSubmit]: type === "submit",
            [styles.buttonSuccess]: type === "success",
        })}
    >
        {children}
    </button>
}

export const PizzaButton = memo(PizzaButtonComponent);