import {currencyUtils} from "../index";
import {CurrencyType} from "../../enums";

const eur_to_usd_rate = 1.09;
const usd_to_eur_rate = 0.92;

describe("currency utils test", () => {
    it.each([
        [2, CurrencyType.USD, `2.00 &#36;`],
        [2, CurrencyType.EUR, `${(2 * usd_to_eur_rate).toFixed(2)} &#8364;`],
    ])("should return price string", (priceUsd, currencyType, expectedResult) => {
        const result = currencyUtils.getPriceString(priceUsd, currencyType);

        expect(result).toEqual(expectedResult);
    });
});