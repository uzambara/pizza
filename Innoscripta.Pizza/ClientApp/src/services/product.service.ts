import {IProductModelRemote} from "../models-remote";
import {ProductType} from "../enums";
import {IGetAllProductsResponse} from "../contratcs/product";
import {fetchUtil} from "../utils";
import {ApiRouting} from "../routing";

const PRODUCTS_MOCK: IProductModelRemote[] = [
    {
        id: 1,
        description: "<b>Ingredients:</b> pizza sauce, Mozzarella and Parmesan cheeses, champignons, bacon, pepperoni sausage, tomatoes, chicken breast, garlic, red onion, greens.",
        img: "/images/pizzas/pizzaman.png",
        name: "Pizzaman",
        price: 4,
        type: ProductType.Pizza
    },
    {
        id: 2,
        description: "<b>Ingredients:</b> pizza sauce, Mozzarella cheese, pepperoni sausage, champignons.",
        img: "/images/pizzas/pepperoni.png",
        name: "Pepperoni",
        price: 5,
        type: ProductType.Pizza
    },
    {
        id: 3,
        description: "<b>Ingredients:</b> pizza sauce, mozzarella cheese, ham, pineapple.",
        img: "/images/pizzas/hawaiian.png",
        name: "Hawaiian",
        price: 6.5,
        type: ProductType.Pizza
    },
    {
        id: 4,
        description: "<b>Ingredients:</b> pizza sauce, mozzarella cheese, tomatoes.",
        img: "/images/pizzas/margarita.png",
        name: "Margarita",
        price: 4.5,
        type: ProductType.Pizza
    },
    {
        id: 5,
        description: "<b>Ingredients:</b> \n" +
            "pizza sauce, mozzarella and parmesan cheeses, ham, mushrooms, pepperoni, jalapenos.",
        img: "/images/pizzas/dragon.png",
        name: "Dragon",
        price: 5,
        type: ProductType.Pizza
    },
    {
        id: 6,
        description: "<b>Ingredients:</b> mustard sauce, Mozzarella cheese, chicken breast, red onion, mushrooms, garlic.",
        img: "/images/pizzas/chicken-julienne.png",
        name: "Chicken julienne",
        price: 6.5,
        type: ProductType.Pizza
    },
    {
        id: 7,
        description: "<b>Ingredients:</b> pizza sauce, Mozzarella, Parmesan, Cheddar cheeses, blue noble cheese.",
        img: "/images/pizzas/four-cheeses.png",
        name: "Four cheeses",
        price: 7,
        type: ProductType.Pizza
    },
    {
        id: 8,
        description: "",
        img: "/images/drinks/coca-cola.png",
        name: "Coca-cola",
        price: 2,
        type: ProductType.Drink
    },
    {
        id: 9,
        description: "",
        img: "/images/drinks/fanta.png",
        name: "Fanta",
        price: 2,
        type: ProductType.Drink
    },
    {
        id: 10,
        description: "",
        img: "/images/drinks/cranberry-juice.png",
        name: "Cranberry juice",
        price: 3,
        type: ProductType.Drink
    },
    {
        id: 11,
        description: "",
        img: "/images/drinks/bon-aqua.png",
        name: "Bon aqua",
        price: 1,
        type: ProductType.Drink
    }
];

export class ProductService {
    public static async  GetAll(): Promise<IGetAllProductsResponse> {
        const result: IGetAllProductsResponse = {} as IGetAllProductsResponse;
        return  await fetchUtil.get<IGetAllProductsResponse>(ApiRouting.Product.getAll);
    }
}