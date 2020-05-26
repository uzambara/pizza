import React, {memo, useCallback, useEffect, useState} from "react";
import {ISelectItem, PizzaButton, PizzaLink, PizzaLogo, PizzaSelect} from "..";
import {Images} from "../../images";
import cn from "classnames";
import {Routing} from "../../routing";
import {PizzaCart} from "../pizza-cart/pizza-cart";
import {CurrencyType} from "../../enums";
import * as styles from "./pizza-header.scss";
import {useSizeChanged} from "../../hooks";
import {useDispatch, useSelector} from "react-redux";
import {settingsSelectors} from "../../redux/selectors";
import {settingsActions} from "../../redux/actions";

export interface IPizzaHeaderProps {
    className?: string,
    onHeightChanged: (height: number) => void,
    totalPrice: number
}

const currencies: ISelectItem[] = [
    {text: "USD", value: CurrencyType.USD},
    {text: "EUR", value: CurrencyType.EUR}
];

function PizzaHeaderComponent(props: IPizzaHeaderProps) {
    const {className, onHeightChanged, totalPrice} = props;
    const [menuOpened, setMenuOpened] = useState(false);
    const {ref: headerRef, size: headerSize} = useSizeChanged();
    const currencyType = useSelector(settingsSelectors.selectCurrencyType);
    const dispatch = useDispatch();

    const changeCurrencyType = useCallback((currencyType: CurrencyType) => {
        dispatch(settingsActions.changeCurrencyType(currencyType));
    }, []);

    useEffect(() => {
        onHeightChanged(headerSize.height);
    }, [headerSize]);

    const onMenuClick = () => {
        setMenuOpened(!menuOpened);
    };

    return <header className={cn(styles.wrapper, className)} ref={headerRef}>
        <div className={styles.header}>
            <PizzaLogo/>
            <a className={styles.phone} href="tel:88005000668">
                <img className={styles.phoneImage} alt="phone" src={Images.Shared.phone}/>
                8 800 500 06 68
            </a>
            <button
                className={styles.menuToggleButton}
                onClick={onMenuClick}
                style={{backgroundImage: `url(${menuOpened ? Images.Shared.cross : Images.Shared.toggleBurger})`}}
            >
            </button>
        </div>
        <div className={cn(styles.menuListWrapper, {[styles.menuListWrapperOpened]: menuOpened})}>
            <ul className={styles.menuList}>
                <li className={styles.menuItem}>
                    <img className={styles.menuItemImage} src={Images.Menu.pizza} alt="pizza"/>
                    <PizzaLink className={styles.menuItemLink} href={Routing.PizzaMenu}>Hot Pizza</PizzaLink></li>
                <li className={styles.menuItem}>
                    <img className={styles.menuItemImage} src={Images.Menu.drinks} alt="drinks"/>
                    <PizzaLink className={styles.menuItemLink} href={Routing.DrinksMenu}>Drinks</PizzaLink>
                </li>
                <li className={styles.menuItem}>
                    <img className={styles.menuItemImage} src={Images.Menu.comments} alt="comments"/>
                    <PizzaLink className={styles.menuItemLink} href={Routing.Comments}>Comments</PizzaLink>
                </li>
            </ul>
            <div className={styles.delimiter}/>
            <div className={styles.buttonsWrapper}>
                <PizzaButton onClick={null} style={"submit"} className={styles.signInItem}>
                    Sign In
                </PizzaButton>
                <PizzaSelect
                    className={styles.currencySelect}
                    items={currencies}
                    onChange={changeCurrencyType}
                    value={currencyType}
                />
            </div>
        </div>
        <PizzaCart className={styles.cart} totalPrice={totalPrice} currencyType={currencyType}/>
    </header>
}

export const PizzaHeader = memo(PizzaHeaderComponent);