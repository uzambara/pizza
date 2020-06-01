import React, {memo} from "react";
import {IOrderItemModelRemote} from "../../models-remote";
import {useSelector} from "react-redux";
import {languageSelectors, settingsSelectors} from "../../redux/selectors";
import {currencyUtils} from "../../utils";
import cn from "classnames";
import * as styles from "./pizza-order-item-details.scss";

export interface IPizzaOrderItemDetailsProps {
    orderItem: IOrderItemModelRemote,
    className?: string
}

function PizzaOrderItemDetailsComponent(props: IPizzaOrderItemDetailsProps) {
    const currencyType = useSelector(settingsSelectors.selectCurrencyType);
    const {PiecesUnits} = useSelector(languageSelectors.selectCommon);
    const {
        className,
        orderItem: {
            productImg,
            productName,
            count,
            price
        }
    } = props;
    return <div className={cn(styles.wrapper, className)}>
        <img className={styles.productImage} src={productImg} alt={productName}/>
        <span className={styles.productName}>{productName}</span>
        <span className={styles.productPrice} dangerouslySetInnerHTML={{__html: currencyUtils.getPriceString(price, currencyType)}}/>
        <span className={styles.productCount}>{count} {PiecesUnits}</span>
    </div>
}

export const PizzaOrderItemDetails = memo(PizzaOrderItemDetailsComponent);