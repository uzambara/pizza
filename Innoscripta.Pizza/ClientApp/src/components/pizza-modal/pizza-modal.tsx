import React, {memo, PropsWithChildren} from "react";
import cn from "classnames";
import * as styles from "./pizza-modal.scss";

export interface IPizzaModalProps {
    classNameContainer?: string,
    classNameModal?: string,
    isOpen: boolean
}

function PizzaModalComponent(props: PropsWithChildren<IPizzaModalProps>) {
    const {children, classNameContainer, classNameModal, isOpen} = props;

    if(!isOpen)
        return null;
    return <div className={cn(styles.wrapper, classNameContainer)}>
        <div className={cn(styles.modal, classNameModal)}>
            {children}
        </div>
    </div>
}

export const PizzaModal = memo(PizzaModalComponent);