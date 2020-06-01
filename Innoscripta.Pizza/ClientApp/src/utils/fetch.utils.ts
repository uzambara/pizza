import {IBaseResponse, ResponseCode} from "../contratcs";

const defaultGetOptions: RequestInit = {
    method: "GET",
    headers: {'content-type': 'application/json'},
    credentials: 'include',
};

const defaultPostOptions: RequestInit = {
    method: "POST",
    headers: {'content-type': 'application/json'},
    credentials: 'include',
};

function getURLSearchParamsFromObject (queryObject: {[key: string]: any}) {
    let result = new URLSearchParams();
    if(queryObject) {
        Object.keys(queryObject).forEach((key) => result.append(key, queryObject[key]));
    }
    return result;
}

async function get<TResponse extends IBaseResponse>(url: string, queryObject?: {[key: string]: any}, requestInit?: RequestInit): Promise<TResponse> {
    const searchParams = getURLSearchParamsFromObject(queryObject);
    const requestUrl = url + '?' + searchParams.toString();

    let response = await fetch(requestUrl, {
        ...defaultGetOptions,
        ...requestInit
    });

    if(response.ok) {
        return (await response.json() as TResponse);
    }

    return {
        code: ResponseCode.InnerError
    } as TResponse;
}

async function post<TResponse extends IBaseResponse>(url: string, data?: any, requestInit?: RequestInit): Promise<TResponse> {
    let body = data ? JSON.stringify(data) : null;

    let response = await fetch(url, {
        ...defaultPostOptions,
        body: body,
        ...requestInit
    });



    if(response.ok) {
        return (await response.json() as TResponse);
    }

    return {
        code: ResponseCode.InnerError
    } as TResponse;
}

export const fetchUtil = {
    get,
    post
};
