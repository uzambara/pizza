import {useCallback, useLayoutEffect, useRef, useState} from "react";
import ResizeObserver from 'resize-observer-polyfill';
import {throttle} from "throttle-debounce";

export function useSizeChanged() {
    const ref = useRef<HTMLElement>();
    const [size, setSize] = useState({height: 0, width: 0});

    const handleResize = useCallback(throttle(500, () => {
        if (ref.current) {
            const newSize = getSize(ref.current);
            setSize(newSize);
        }
    }), [ref.current]);

    useLayoutEffect(() => {
        if (!ref.current)
            return;

        const resizeObserver = new ResizeObserver(handleResize);
        resizeObserver.observe(ref.current);

        return () => resizeObserver.disconnect();
    }, [ref.current]);

    return {
        ref,
        size
    }
}

function getSize(el) {
    if (!el) {
        return {
            width: 0,
            height: 0
        }
    }

    return {
        width: el.offsetWidth,
        height: el.offsetHeight
    }
}