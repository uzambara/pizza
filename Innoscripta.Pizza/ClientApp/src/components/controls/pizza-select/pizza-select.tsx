import React, {ChangeEventHandler, memo} from "react";
import * as styles from "./pizza-select.scss";
import cn from "classnames";

export interface ISelectItem {
    value: string | number,
    text: string | number
}

export interface IPizzaSelectProps {
    items: ISelectItem[],
    onChange: (value: string | number) => void,
    value: string | number,
     className?: string
}

function PizzaSelectComponent(props: IPizzaSelectProps) {
    const {items, onChange, value, className} = props;
    const onChangeInternal: ChangeEventHandler<HTMLSelectElement> = (ev) => onChange(ev.target.value);

    return <select className={cn(styles.select, className)} onChange={onChangeInternal} value={value}>
        {
            items.map(item => <option key={item.value} value={item.value}>
                {item.text}
            </option>)
        }
    </select>
}

export const PizzaSelect = memo(PizzaSelectComponent);