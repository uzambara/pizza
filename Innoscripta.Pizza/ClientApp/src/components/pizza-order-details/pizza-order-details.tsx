import {memo} from "react";
import * as React from "react";
import {IOrderModelRemote} from "../../models-remote";
import {PizzaOrderItemDetails} from "..";
import * as styles from "./pizza-order-details.scss";
import {currencyUtils} from "../../utils";
import {useSelector} from "react-redux";
import {languageSelectors, settingsSelectors} from "../../redux/selectors";
import {useTrigger} from "../../hooks";
import cn from "classnames";

export interface IPizzaOrderDetails {
    order: IOrderModelRemote
}

function PizzaOrderDetailsComponent(props: IPizzaOrderDetails) {
    const currencyType = useSelector(settingsSelectors.selectCurrencyType);
    const {Comment, Details} = useSelector(languageSelectors.selectProfilePage).OrdersHistory;
    const {value: detailsOpened, toggle: detailsOpenedToggle} = useTrigger(false);
    const {order: {
        totalPrice,
        address,
        comment,
        orderItems,
        date
    }} = props;
    console.log(totalPrice);
    return <section className={styles.wrapper}>
        <div className={styles.commonDetails}>
            <span className={styles.address}>{address}</span>
            <span className={styles.price} dangerouslySetInnerHTML={{__html: currencyUtils.getPriceString(totalPrice, currencyType)}}/>
        </div>
        <span className={styles.date}>{date}</span>
        <p className={styles.comment}>{Comment}: {comment}</p>
        <span className={styles.detailsButton} onClick={detailsOpenedToggle}>{Details}</span>
        <div className={cn(styles.orderItemDetails, {[styles.orderItemDetailsOpened]: detailsOpened})}>
            {
                orderItems.map((orderItem, idx) => <PizzaOrderItemDetails
                    key={idx}
                    orderItem={orderItem}
                    className={styles.orderItem}
                />)
            }
        </div>
    </section>
}

export const PizzaOrderDetails = memo(PizzaOrderDetailsComponent);