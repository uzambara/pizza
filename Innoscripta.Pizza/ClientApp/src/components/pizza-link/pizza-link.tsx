﻿import React, {PropsWithChildren} from "react";
import {Link} from "react-router-dom";

export interface IPizzaLinkProps {
    href: string,
    className?: string
}

export function PizzaLink(props: PropsWithChildren<IPizzaLinkProps>) {
    const {children, href, className} = props;
    return <Link to={href} className={className}>{children}</Link>
};