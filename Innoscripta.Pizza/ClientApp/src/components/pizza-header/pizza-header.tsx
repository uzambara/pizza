import React, {useState} from "react";
import {PizzaLink, PizzaLogo} from "../index";
import  * as styles from "./pizza-header.scss";
import {Images} from "../../images";
import cn from "classnames";
import {Routing} from "../../routing";

export interface IPizzaHeaderProps {
    className?: string
}

export function PizzaHeader(props: IPizzaHeaderProps) {
    const {className} = props;
    const [menuOpened, setMenuOpened] = useState(false);

    const onMenuClick = () => {
        setMenuOpened(!menuOpened);
    };

    return <header className={cn(styles.wrapper, className)}>
        <section className={styles.header}>
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
        </section>
        <ul className={cn(styles.menuList, {[styles.menuListOpened]: menuOpened})}>
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
    </header>
}