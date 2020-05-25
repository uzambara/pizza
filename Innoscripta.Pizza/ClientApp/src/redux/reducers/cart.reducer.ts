import {CartAction, CartActionType} from "../actions";
import {ICartItem} from "../../models";
import {ProductType} from "../../enums";
import {cartItemFactory} from "../../factories";

export type CartItemsMap = {[id: number]: ICartItem};

export interface ICartState {
    items: CartItemsMap
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
    items: {7: cartItem}
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
                items
            };
        case CartActionType.RemoveItem: {
            const id = action.payload;
            let newItems = {...state.items};
            delete newItems[id];
            return {
                ...state,
                items: newItems
            };
        }
        case CartActionType.ChangeItemCount: {
            const {id, diff} = action.payload;
            const items = {...state.items};
            let itemForChange: ICartItem = {...(items[id])};
            itemForChange.count += diff;

            items[id] = itemForChange;

            return {...state, items};
        }
        default:
            return state;
    }
};