﻿import {useCallback, useState} from "react";

export function useTrigger(initialValue: boolean) {
    const [value, setValue] = useState(initialValue);
    const onTrigger = useCallback(() => setValue(true), []);
    const offTrigger = useCallback(() => setValue(false), []);
    const toggle = useCallback(() => setValue(prev => !prev), []);

    return {
        value,
        onTrigger,
        offTrigger,
        toggle
    }
}