function getDeepCopy<T extends object>(obj: T) {
    return JSON.parse(JSON.stringify(obj)) as T;
}

const delay = (timer) => new Promise(resolve => setTimeout(() => resolve(), timer));

export const testUtils = {
    getDeepCopy,
    delay
};