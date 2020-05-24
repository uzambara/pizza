import {CartAction, CartActionType} from "../actions";
import {ICartItem} from "../../models";
import {ProductType} from "../../enums";
import {cartItemFactory} from "../../factories";

export interface ICartState {
    items: {[id: number]: ICartItem},
    totalPrice: number
}

const cartItem = cartItemFactory.createCartItem({
    id: 7,
    description: "<b>Ingredients:</b> pizza sauce, Mozzarella and Parmesan cheeses, champignons, bacon, pepperoni sausage, tomatoes, chicken breast, garlic, red onion, greens.",
    img: "/images/pizzas/pizzaman.png",
    name: "Pizzaman",
    price: 5,
    type: ProductType.Pizza
});

const initialState: ICartState = {
    items: [cartItem],
    totalPrice: 0
};

export const cartReducer = (state: ICartState = initialState, action: CartAction): ICartState => {
    switch (action.type) {
        case CartActionType.AddToCart:
            const newItem = action.payload;

            const items = {...state.items};
            if(items[newItem.productId]) {
                items[newItem.productId].count++;
            } else {
                items[newItem.productId] = newItem;
            }

            return {
                items,
                totalPrice: state.totalPrice + newItem.price
            };
        default:
            return state;
    }
};