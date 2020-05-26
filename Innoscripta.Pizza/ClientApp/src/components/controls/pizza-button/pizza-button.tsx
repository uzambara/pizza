import React, {memo, PropsWithChildren} from "react";
import cn from "classnames";
import * as styles from "./pizza-button.scss";


export interface IPizzaButtonProps {
    onClick: () => void,
    className?: string,
    style: "submit" | "alert" | "success" | "simple",
    type?: "submit" | "reset" | "button"
}

function PizzaButtonComponent(props: PropsWithChildren<IPizzaButtonProps>) {
    const {onClick, children, className, style, type} = props;

    return <button
        onClick={onClick}
        type={type || "button"}
        className={cn(className, styles.button, {
            [styles.buttonAlert]: style === "alert",
            [styles.buttonSubmit]: style === "submit",
            [styles.buttonSuccess]: style === "success",
        })}
    >
        {children}
    </button>
}

export const PizzaButton = memo(PizzaButtonComponent);