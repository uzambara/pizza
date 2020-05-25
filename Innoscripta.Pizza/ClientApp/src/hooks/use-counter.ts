import {useCallback, useState} from "react";

export function useCounter(initialValue: number) {
    const [counterValue, setCounterValue] = useState(initialValue);

    const onIncrease = useCallback(() => {
        setCounterValue(prev => prev + 1);
    }, []);
    const onDecrease = useCallback(() => {
        setCounterValue(prev => prev - 1);
    }, []);

    return {
        counterValue,
        onIncrease,
        onDecrease
    }
}