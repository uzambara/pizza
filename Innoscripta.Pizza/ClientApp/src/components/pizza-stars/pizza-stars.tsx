import React, {memo, useState} from "react";
import * as styles from "./pizza-stars.scss";
import {Images} from "../../images";
import _ from "underscore";
import cn from "classnames";
import {IReduxFormFieldProps} from "../index";

function selected(idx: number, hoveredIndex: number) {
    return hoveredIndex >= 0 && idx <= hoveredIndex;
}

interface PizzaStarsProps extends IReduxFormFieldProps {
    disable?: boolean,
    className?: string,
    size?: number
}

const defaultImageSize = 34;
const maxStarsCount = 5;
function PizzaStarsComponent(props: PizzaStarsProps) {
    const {
        disable,
        size,
        className,
        input: { value, onChange }
    } = props;

    const [hoveredIndex, setHoveredIndex] = useState(() => isNaN(parseInt(value)) ? -1 : value);
    const onMouseLeave = () => {
        if(!disable) {
            onChange(value);
            setHoveredIndex(value - 1);
        }
    };

    const imgSize = size || defaultImageSize;
    return <ul className={cn(styles.starsList, className)} onMouseLeave={onMouseLeave}>
        {
            _.range(maxStarsCount).map((item, idx) => <li
                key={idx}
                className={styles.starsItem}
                style={{width: imgSize, height: imgSize}}
            >
                <img
                    onMouseEnter={() => !disable && setHoveredIndex(idx)}
                    onClick={() => !disable && onChange(idx + 1)}
                    src={Images.Shared.pizzaStar}
                    alt="star"
                    className={cn(styles.starsImage)}
                    style={selected(idx, hoveredIndex) ? {marginTop: 0} : {marginTop: (imgSize * -1)}}
                />
            </li>
            )
        }
    </ul>
}

export const PizzaStars = memo(PizzaStarsComponent);
