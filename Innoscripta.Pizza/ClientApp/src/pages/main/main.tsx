import React from "react";
import cn from "classnames";
import * as styles from "./main.scss";

export interface IMainPageProps {
    className?: string
}

export function MainPage(props: IMainPageProps) {
    const {className} = props;
    return <main className={cn(styles.wrapper, className)}>
        <h2 className={styles.header}>Hot pizza</h2>
    </main>
}