import React, {memo, useState} from "react";
import * as styles from "./pizza-stars.scss";
import {Images} from "../../images";
import _ from "underscore";
import cn from "classnames";
import {IReduxFormFieldProps} from "../index";

function selected(idx: number, hoveredIndex: number) {
    return hoveredIndex >= 0 && idx <= hoveredIndex;
}

function PizzaStarsComponent(props: IReduxFormFieldProps) {
    const [hoveredIndex, setHoveredIndex] = useState(-1);

    const {
        input: { value: starsCount, onChange }
    } = props;
    return <ul className={styles.starsList} onMouseLeave={() => onChange(starsCount)}>
        {
            _.range(5).map((item, idx) => <li key={idx} className={styles.starsItem}>
                <img
                    onMouseEnter={() => setHoveredIndex(idx)}
                    onClick={() => onChange(idx + 1)}
                    src={Images.Shared.pizzaStar}
                    alt="star"
                    className={cn(styles.starsImage, selected(idx, hoveredIndex) ? styles.starsImageSelected : "")}
                />
            </li>
            )
        }
    </ul>
}

export const PizzaStars = memo(PizzaStarsComponent);
