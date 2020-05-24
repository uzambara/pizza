import React, {memo, useEffect, useState} from "react";
import cn from "classnames";
import * as styles from "./main.page.scss";
import {IPageProps} from "../page-props";
import {withPageWrapper} from "../../hocs";
import {IProductModelRemote} from "../../models-remote";
import {ProductService} from "../../services";
import {PizzaProductList} from "../../components";

export interface IMainPageProps extends IPageProps{
}

export function MainPageComponent(props: IMainPageProps) {
    const {className} = props;
    const [products, setProducts] = useState<IProductModelRemote[]>([]);

    useEffect(() => {
        ProductService.GetAll().then(response => setProducts(response.items));
    },[]);
    return <main className={cn(styles.wrapper, className)}>
        <h2 className={styles.header}>Hot pizza</h2>
        <PizzaProductList items={products}/>
    </main>
}

export const MainPage = memo(withPageWrapper<IMainPageProps>(MainPageComponent));