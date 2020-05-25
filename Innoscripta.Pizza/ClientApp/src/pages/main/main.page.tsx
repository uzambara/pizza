import React, {memo} from "react";
import * as styles from "./main.page.scss";
import {IPageProps} from "../page-props";
import {withPageWrapper} from "../../hocs";
import {PizzaProductList} from "../../components";
import {IMenuPageProps} from "../menu-page-props";

export interface IMainPageProps extends IPageProps, IMenuPageProps {
}

export function MainPageComponent(props: IMainPageProps) {
    const {products, header} = props;
    return <>
        <h2 className={styles.header}>{header}</h2>
        <PizzaProductList items={products}/>
    </>
}

export const MainPage = memo(withPageWrapper<IMainPageProps>(MainPageComponent));