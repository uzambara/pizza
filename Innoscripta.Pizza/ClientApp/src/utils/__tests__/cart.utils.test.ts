import {CartItemsMap} from "../../redux/reducers";
import {ICartItem} from "../../models";
import {cartUtils} from "../index";
import {ProductType} from "../../enums";

describe("cart utils tests", () => {
    it.each([
        [{
            1: {
                count: 1,
                price: 2
            } as ICartItem,
            2: {
                count: 2,
                price: 2
            } as ICartItem
        }, 6],
        [{
            1: {
                count: 0,
                price: 2
            } as ICartItem,
            2: {
                count: 0,
                price: 2
            } as ICartItem
        }, 0]
    ])("should calc cart total price", (cartMap, expectedResult) => {

        // Act
        const result = cartUtils.calcTotalPrice(cartMap);

        // Assert
        expect(result).toEqual(expectedResult);
    });

    it("should create array from cart items map", () => {
        // Arrange
        const product1 = {
            price: 1,
            count: 1,
            imageUrl: "",
            name: "product 1",
            productId: 1,
            productType: 1
        };
        const product2 = {
            price: 2,
            count: 2,
            imageUrl: "",
            name: "product 2",
            productId: 1,
            productType: 1
        };
        const cartItemsMap: CartItemsMap = {
            1: product1,
            2: product2
        };

        // Act
        const result = cartUtils.cartItemsMapToArray(cartItemsMap);

        // Assert
        expect(Array.isArray(result)).toEqual(true);
        expect(result).toHaveLength(2);
        expect(result[0]).toEqual(product1);
        expect(result[1]).toEqual(product2);
    });

    it("should return empty array if map is empty", () => {
        // Act
        const result = cartUtils.cartItemsMapToArray({});

        // Assert
        expect(Array.isArray(result)).toEqual(true);
        expect(result).toHaveLength(0);
    });

    it("should return empty array if map is null", () => {
        // Act
        const result = cartUtils.cartItemsMapToArray(null);

        // Assert
        expect(Array.isArray(result)).toEqual(true);
        expect(result).toHaveLength(0);
    });

    it("should return map from array", () => {
        // Arrange
        const product1 = {
            productId: 1,
            count: 1,
            imageUrl: "url",
            productType: ProductType.Pizza,
            name: "pizza 1",
            price: 1
        };
        const product2 = {
            productId: 2,
            count: 1,
            imageUrl: "url",
            productType: ProductType.Pizza,
            name: "pizza 2",
            price: 1
        };
        // Act
        const result = cartUtils.cartItemsArrayToMap([
            product1,
            product2
        ]);

        // Assert
        expect(Object.keys(result)).toHaveLength(2);
        expect(result[1]).toEqual(product1);
        expect(result[2]).toEqual(product2);
    });

    it("should return empty object if input array is null", () => {
        // Act
        const result = cartUtils.cartItemsArrayToMap(null);

        // Assert
        expect(result).toEqual({});
    });

    it("should return empty object if input array empty", () => {
        // Act
        const result = cartUtils.cartItemsArrayToMap([]);

        // Assert
        expect(result).toEqual({});
    });
});