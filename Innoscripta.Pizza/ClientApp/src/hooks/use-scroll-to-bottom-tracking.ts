import {useCallback, useEffect, useRef} from "react";
import {commonUtils} from "../utils";
import {debounce} from "throttle-debounce";

export function useScrollToBottomTracking(onScrolledToBottom: () => void) {
    const ref = useRef();

    const trackScrolling = useCallback(() => {
        if (onScrolledToBottom && commonUtils.isElementBottom(ref.current)) {
            onScrolledToBottom();
        }
    }, [onScrolledToBottom]);

    useEffect(() => {
        if(ref.current) {
            const handler = debounce(300, trackScrolling);
            document.addEventListener('scroll', handler);
            return () => {
                document.removeEventListener("scroll", handler)
            };
        }
    }, [ref.current, onScrolledToBottom]);

    return {
        ref
    }
}