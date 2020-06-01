function getUrlImage(url: string) {
    return `url(${url})`
}

function isElementBottom(element: HTMLElement) {
    if(!element)
        return false;
    return element.getBoundingClientRect().bottom <= window.innerHeight;
}

export const commonUtils = {
    getUrlImage,
    isElementBottom
};