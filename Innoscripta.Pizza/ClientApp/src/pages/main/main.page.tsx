import React, {memo} from "react";
import * as styles from "./main.page.scss";
import {IPageProps} from "../page-props";
import {withPageWrapper} from "../../hocs";
import {PizzaProductList} from "../../components";
import {IMenuPageProps} from "../menu-page-props";

export interface IMainPageProps extends IMenuPageProps {
}

export function MainPageComponent(props: IMainPageProps) {
    const {products} = props;
    return <>
        <PizzaProductList items={products}/>
    </>
}

export const MainPage = memo(withPageWrapper<IPageProps & IMainPageProps>(MainPageComponent));