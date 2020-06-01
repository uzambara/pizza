import React, {memo, PropsWithChildren} from "react";
import {Link} from "react-router-dom";

export interface IPizzaLinkProps {
    href: string,
    className?: string,
    onClick?: () => void
}

function PizzaLinkComponent(props: PropsWithChildren<IPizzaLinkProps>) {
    const {children, href, className, onClick} = props;
    return <Link to={href} className={className} onClick={onClick}>{children}</Link>
}

export const PizzaLink = memo(PizzaLinkComponent);