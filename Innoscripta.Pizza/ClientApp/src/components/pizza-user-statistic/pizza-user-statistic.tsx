import React, {memo} from "react";
import {IUserModelRemote, IUserStatisticModelRemote} from "../../models-remote";
import {useSelector} from "react-redux";
import {languageSelectors, settingsSelectors} from "../../redux/selectors";
import {currencyUtils} from "../../utils";
import cn from "classnames";
import * as styles from "./pizza-user-statistic.scss";

export interface IPizzaUserStatisticProps {
    userStatistic: IUserStatisticModelRemote,
    user: IUserModelRemote,
    className?: string
}


function PizzaUserStatisticComponent(props: IPizzaUserStatisticProps) {
    const {
        className,
        userStatistic: {
            totalOrdersPrice,
            ordersCount,
            bonus
        },
        user: {
            name: userName,
            lastName,
            phone
        }
    } = props;
    const currencyType = useSelector(settingsSelectors.selectCurrencyType);
    const {
        Bonus,
        OrdersCount,
        TotalOrdersPrice,
        User,
        Phone
    } = useSelector(languageSelectors.selectProfilePage).Statistic;

    return <section className={className}>
        <ul className={styles.statisticList}>
            <li className={cn(styles.statisticItem, styles.userName)}>{User}: {userName} {lastName}</li>
            <li className={styles.statisticItem}>{Phone}: {phone}</li>
            <li className={styles.statisticItem}>{OrdersCount}: {ordersCount}</li>
            <li
                className={styles.statisticItem}
                dangerouslySetInnerHTML={{__html: `${TotalOrdersPrice}: ${currencyUtils.getPriceString(totalOrdersPrice, currencyType)}`}}
            />
            <li
                className={styles.statisticItem}
                dangerouslySetInnerHTML={{__html: `${Bonus}: ${currencyUtils.getPriceString(bonus, currencyType)}`}}
            />
        </ul>
    </section>
}

export const PizzaUserStatistic = memo(PizzaUserStatisticComponent);