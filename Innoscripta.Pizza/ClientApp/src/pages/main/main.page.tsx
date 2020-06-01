import React, {memo} from "react";
import {IPageProps} from "../page-props";
import {withPageWrapper} from "../../hocs";
import {PizzaProductList} from "../../components";
import {IMenuPageProps} from "../menu-page-props";
import * as styles from "./main.page.scss";

export interface IMainPageProps extends IMenuPageProps {
}

export function MainPageComponent(props: IMainPageProps) {
    const {products} = props;
    return <>
        <PizzaProductList items={products}/>
    </>
}

export const MainPage = memo(withPageWrapper<IPageProps & IMainPageProps>(MainPageComponent));