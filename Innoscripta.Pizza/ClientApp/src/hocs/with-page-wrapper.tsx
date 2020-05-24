import React, {FunctionComponent} from "react";
import {IPageProps} from "../pages";



export function withPageWrapper<T extends IPageProps>(Component: any): FunctionComponent<T> {
    return function(props: T) {
        const {className, paddingTop, ...other} = props;
        return <main className={className} style={{paddingTop: paddingTop}}>
            <Component {...other}/>
        </main>
    }
}