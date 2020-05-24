import {CurrencyType} from "../enums";

function convert(input: number, inputType: CurrencyType, outputType: CurrencyType): string {
    let result = input;
    switch (inputType) {
        case CurrencyType.EUR:
            result = eurConverter(input, outputType);
            break;
        case CurrencyType.USD:
            result = usdConverter(input, outputType);
            break;
        default:
            result = input;
    }

    return result.toFixed(2);
}

function getCurrencyCode(currencyType: CurrencyType) {
    switch (currencyType) {
        case CurrencyType.EUR:
            return '&#8364';
        case CurrencyType.USD:
            return '&#36;'
    }
}

function getPriceString(priceUsd: number, currencyType: CurrencyType) {
    return `${convert(priceUsd, CurrencyType.USD, currencyType)} ${getCurrencyCode(currencyType)}`
}

function usdConverter(usd: number, outputType: CurrencyType) {
    switch (outputType) {
        case CurrencyType.EUR:
            return 0.92 * usd;
        case CurrencyType.USD:
            return usd;
    }
}


function eurConverter(eur: number, outputType: CurrencyType) {
    switch (outputType) {
        case CurrencyType.EUR:
            return 1.09 * eur;
        case CurrencyType.USD:
            return eur;
    }
}

export const currencyUtils = {
    getPriceString
};