import {cartReducer} from "../cart.reducer";
import {cartInitialState} from "../index";
import {cartActions} from "../../actions";
import {ProductType} from "../../../enums";
import {testUtils} from "../../../testing";

describe("cart reducers tests", () => {
    let state = cartInitialState;
    beforeEach(() => {
        state = testUtils.getDeepCopy(cartInitialState);
    });
    it("should return initial state on create", () => {

        // Act
        const result = cartReducer(undefined, {} as any);

        // Assert
        expect(result).toEqual(cartInitialState);
    });

    it("should add cart item in state", () => {
        // Arrange
        const product = {
            count: 1,
            productId: 1,
            price: 1,
            name: "product",
            productType: ProductType.Pizza,
            imageUrl: "img"
        };
        const action = cartActions.addToCart(product);

        expect(Object.keys(state.items)).toHaveLength(0);

        // Act
        const result = cartReducer(state, action);

        // Assert
        expect(Object.keys(result.items)).toHaveLength(1);
        expect(result.items[1]).toEqual(product);
    });

    it("should remove item from cart", () => {
        // Arrange
        const product = {
            count: 1,
            productId: 1,
            price: 1,
            name: "product",
            productType: ProductType.Pizza,
            imageUrl: "img"
        };
        state.items = {
            1: product
        };
        const action = cartActions.removeItem(1);

        expect(Object.keys(state.items)).toHaveLength(1);

        // Act
        const result = cartReducer(state, action);

        // Assert
        expect(Object.keys(result.items)).toHaveLength(0);
    });

    it("should not remove item from cart if no item with given id", () => {
        // Arrange
        const product = {
            count: 1,
            productId: 1,
            price: 1,
            name: "product",
            productType: ProductType.Pizza,
            imageUrl: "img"
        };
        state.items = {
            1: product
        };
        const action = cartActions.removeItem(2);

        expect(Object.keys(state.items)).toHaveLength(1);

        // Act
        const result = cartReducer(state, action);

        // Assert
        expect(Object.keys(result.items)).toHaveLength(1);
        expect(result.items[1]).toEqual(product);
    });

    it("should change item count in cart", () => {
        // Arrange
        const product = {
            count: 1,
            productId: 1,
            price: 1,
            name: "product",
            productType: ProductType.Pizza,
            imageUrl: "img"
        };
        state.items = {
            1: product
        };
        const action = cartActions.changeItemCount(1, 5);

        // Act
        const result = cartReducer(state, action);

        // Assert
        expect(result.items[1].count).toEqual(6);
    });

    it("should not change items count if no item with given id", () => {
        // Arrange
        const product = {
            count: 1,
            productId: 1,
            price: 1,
            name: "product",
            productType: ProductType.Pizza,
            imageUrl: "img"
        };
        state.items = {
            1: product
        };
        const action = cartActions.changeItemCount(2, 5);

        // Act
        const result = cartReducer(state, action);

        // Assert
        expect(result).toEqual(state);
    });

    it("should clear cart", () => {
        // Arrange
        const product = {
            count: 1,
            productId: 1,
            price: 1,
            name: "product",
            productType: ProductType.Pizza,
            imageUrl: "img"
        };
        state.items = {
            1: product
        };
        const action = cartActions.clearCart();

        // Acr
        const result = cartReducer(state, action);

        // Assert
        expect(result.items).toEqual({});
    });
});