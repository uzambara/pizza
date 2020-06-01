import React, {memo} from "react";
import * as styles from "./cart.page.scss";
import {IPageProps} from "../page-props";
import {withPageWrapper} from "../../hocs";
import {useDispatch, useSelector} from "react-redux";
import {cartSelectors, languageSelectors, settingsSelectors} from "../../redux/selectors";
import {PizzaButton, PizzaCartList, PizzaModal, PizzaOrderForm} from "../../components";
import {useTrigger} from "../../hooks";
import {IMakeOrderFormData} from "../../models";
import {cartUtils} from "../../utils";
import {orderActions} from "../../redux/actions";

export interface ICartPageProps {
    totalPrice: number
}

function CartPageComponent(props: ICartPageProps) {
    const {totalPrice} = props;
    const dispatch = useDispatch();
    const cartItemsMap = useSelector(cartSelectors.selectCartItemsMap);
    const currencyType = useSelector(settingsSelectors.selectCurrencyType);
    const {value: modalIsOpen, onTrigger: setOpen, offTrigger: setClose} = useTrigger(false);
    const contentsStrings = useSelector(languageSelectors.selectContentStrings);
    const submitOrder = async (data: IMakeOrderFormData) => {
        dispatch(orderActions.makeOrderRemote(data));
        setClose();
    };

    const cartPage = useSelector(languageSelectors.selectCartPage);

    const cartItems = cartUtils.cartItemsMapToArray(cartItemsMap);
    return <>
        <PizzaModal
            isOpen={modalIsOpen}
            classNameContainer={styles.orderFormModalContainer}
            classNameModal={styles.orderFormModal}
        >
            <PizzaOrderForm onSubmit={submitOrder} onCancel={setClose}/>
        </PizzaModal>
        {
            cartItems.length > 0 &&
            <>
                <PizzaCartList totalPrice={totalPrice} currencyType={currencyType} cartItems={cartItems}/>
                <div className={styles.buyButtonWrapper}>
                    <PizzaButton className={styles.buyButton} style="submit" onClick={setOpen} type="button">{cartPage.BuyButton}</PizzaButton>
                </div>
            </>
        }
    </>
}

export const CartPage = memo(withPageWrapper<IPageProps & ICartPageProps>(CartPageComponent));