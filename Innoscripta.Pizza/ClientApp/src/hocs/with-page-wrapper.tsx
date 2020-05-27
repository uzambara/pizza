import React, {FunctionComponent} from "react";
import {IPageProps} from "../pages";
import * as styles from "./with-page-wrapper.scss";



export function withPageWrapper<T extends IPageProps>(Component: any): FunctionComponent<T> {
    return function(props: T) {
        const {className, paddingTop, header, ...other} = props;
        return <main className={className} style={{paddingTop: paddingTop}}>
            {header && <h2 className={styles.header}>{header}</h2>}
            <Component {...other}/>
        </main>
    }
}