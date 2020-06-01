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
import {useDispatch, useSelector} from "react-redux";
import {languageSelectors} from "../../redux/selectors";
import {productUtils} from "../../utils/products.utils";

export interface IPizzaCardProps {
    currencyType: CurrencyType,
    productModel: IProductModelRemote,
    className?: string
}

function PizzaProductCardComponent(props: IPizzaCardProps) {
    const languageType = useSelector(languageSelectors.selectLanguageType);
    const {currencyType, productModel, className} = props;
    const {price, img} = productModel;
    const {name, description} = productUtils.getNameAndDescription(productModel, languageType);

    const dispatch = useDispatch();
    const addToCart = () => {
        const cartItem = cartItemFactory.createCartItem(productModel, languageType);
        dispatch(cartActions.addToCart(cartItem));
    };

    const productCardString = useSelector(languageSelectors.selectProductCard);

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
            <PizzaButton onClick={addToCart} style="submit">{productCardString.BuyButton}</PizzaButton>
        </div>
    </section>
}

export const PizzaProductCard = memo(PizzaProductCardComponent);