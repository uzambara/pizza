import React, {memo} from "react";
import {PizzaOrderDetails} from "..";
import {IOrderModelRemote} from "../../models-remote";
import * as styles from "./pizza-order-history.scss";

interface IPizzaOrderHistory {
    orders: IOrderModelRemote[]
}

function PizzaOrderHistoryComponent(props: IPizzaOrderHistory) {
    const {orders} = props;
    return <ul className={styles.ordersList}>
        {
            orders.map((order, idx) => <PizzaOrderDetails key={idx} order={order}/>)
        }
    </ul>
}


export const PizzaOrderHistory = memo(PizzaOrderHistoryComponent);