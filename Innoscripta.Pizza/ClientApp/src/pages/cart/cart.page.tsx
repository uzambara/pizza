import React, {memo, useState} from "react";
import * as styles from "./cart.page.scss";
import {IPageProps} from "../page-props";
import {withPageWrapper} from "../../hocs";
import {useSelector} from "react-redux";
import {cartSelectors, settingsSelectors} from "../../redux/selectors";
import {PizzaCartList, PizzaModal, PizzaOrderForm} from "../../components";

export interface ICartPageProps extends IPageProps {
    totalPrice: number
}

function CartPageComponent(props: ICartPageProps) {
    const {totalPrice} = props;
    const cartItemsMap = useSelector(cartSelectors.selectCartItemsMap);
    const currencyType = useSelector(settingsSelectors.selectCurrencyType);
    const [modalIsOpen, setModalIsOpen] = useState(false);
    return <>
        <PizzaModal
            classNameContainer={styles.orderFormModalContainer}
            classNameModal={styles.orderFormModal}
        >
            <PizzaOrderForm onSubmit={(data) => console.log(data)}/>
        </PizzaModal>
        <h2 className={styles.title}>Your order</h2>
        <PizzaCartList totalPrice={totalPrice} currencyType={currencyType} cartItemsMap={cartItemsMap}/>
    </>
}

export const CartPage = memo(withPageWrapper<ICartPageProps>(CartPageComponent));