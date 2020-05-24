import React, {memo} from "react";
import {PizzaProductCard} from "..";
import {IProductModelRemote} from "../../models-remote";
import * as styles from "./pizza-product-list.scss";
import cn from "classnames";
import {useSelector} from "react-redux";
import {settingsSelectors} from "../../redux/selectors";



export interface IPizzaProductListProps {
    items: IProductModelRemote[],
    className?: string
}

function PizzaProductListComponent(props: IPizzaProductListProps) {
    const {items, className} = props;
    const currencyType = useSelector(settingsSelectors.selectCurrencyType);
    return <ul className={cn(styles.list, className)}>
        {
            items.map((product, idx) =>
                <li className={styles.listItem} key={idx}><PizzaProductCard currencyType={currencyType} productModel={product}/></li>)
        }
    </ul>
}

export const PizzaProductList = memo(PizzaProductListComponent);