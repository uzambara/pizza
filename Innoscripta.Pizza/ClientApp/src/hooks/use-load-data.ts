import {useEffect, useState} from "react";
import {getInitialGetPartialDataResponse, IGetPartialDataRequest, IGetPartialDataResponse} from "../contratcs/shared";

export function usePartialLoadData<TData>(itemsCount: number, loader: (request: IGetPartialDataRequest) => Promise<IGetPartialDataResponse<TData>>) {
    const [response, setResponse] = useState<IGetPartialDataResponse<TData>>(() => getInitialGetPartialDataResponse<TData>());
    const [items, setItems] = useState<TData[]>([]);
    const [offset, setOffset] = useState(0);

    const load = () => {
        if(response.moreItemsExists) {
            loader({offset, itemsCount })
                .then((response) => {
                    setOffset(prev => prev + itemsCount);
                    setResponse(response);
                    setItems(prev => [...prev, ...response.items]);
                });
        }
    };
    const loadMore = () => {
        load();
    };
    useEffect(() => {
        load();
    }, []);

    return {
        response,
        loadMore,
        load,
        items
    }
}