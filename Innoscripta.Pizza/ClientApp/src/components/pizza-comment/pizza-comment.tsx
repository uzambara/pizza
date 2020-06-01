import React, {memo, useRef} from "react";
import {ICommentModelRemote} from "../../models-remote";
import {PizzaStars} from "..";
import {actionMock} from "../../constants";
import cn from "classnames";
import * as styles from "./pizza-comment.scss";

interface IPizzaCommentProps {
    comment: ICommentModelRemote,
    className?: string
}

function PizzaCommentComponent(props: IPizzaCommentProps) {
    const {comment: {text, date, name, stars}, className} = props;
    const ref = useRef();



    return <div className={cn(styles.wrapper, className)} ref={ref}>
        <h3 className={styles.name}>{name}</h3>
        <span className={styles.date}>{date}</span>
        <PizzaStars size={24} className={styles.stars} disable={true} input={{value: stars - 1, onChange: actionMock}}/>
        <p className={styles.text}>{text}</p>
    </div>
}

export const PizzaComment = memo(PizzaCommentComponent);