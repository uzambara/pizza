import React, {memo} from "react";
import * as styles from "./pizza-product-card.scss";
import {Images} from "../../images";
import {IProductModelRemote} from "../../models-remote";
import {PizzaButton} from "..";
import {currencyUtils} from "../../utils";
import {CurrencyType} from "../../enums";
import cn from "classnames";
import {cartItemFactory} from "../../factories";
import {cartActions} from "../../redux/actions";
import {useDispatch} from "react-redux";

export interface IPizzaCardProps {
    currencyType: CurrencyType,
    productModel: IProductModelRemote,
    className?: string
}

function PizzaProductCardComponent(props: IPizzaCardProps) {
    const {currencyType, productModel, className} = props;
    const {price, name, img, description} = productModel;

    const dispatch = useDispatch();
    const addToCart = () => {
        const cartItem = cartItemFactory.createCartItem(productModel);
        dispatch(cartActions.AddToCart(cartItem));
    };

    return <section className={cn(styles.wrapper, className)}>
        <div className={styles.imageAndNameWrapper} style={{backgroundImage: `url(${Images.PizzaCard.background})`}}>
            <img className={styles.pizzaImage} src={img} alt={name}/>
            <h3 className={styles.pizzaName}>{name}</h3>
        </div>
        <div className={styles.descriptionAndPriceWrapper}>
            <p className={styles.pizzaDescription} dangerouslySetInnerHTML={{__html: description}}/>
            <span
                className={styles.pizzaPrice}
                dangerouslySetInnerHTML={{__html: currencyUtils.getPriceString(price, currencyType)}}
            />
            <PizzaButton onClick={addToCart} type="submit">Buy</PizzaButton>
        </div>
    </section>
}

export const PizzaProductCard = memo(PizzaProductCardComponent);