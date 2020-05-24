import {IProductModelRemote} from "../models-remote";
import {ProductType} from "../enums";
import {IGetAllResponse} from "../contratcs/product";

const PIZZAS: IProductModelRemote[] = [
    {
        id: 1,
        description: "<b>Ingredients:</b> pizza sauce, Mozzarella and Parmesan cheeses, champignons, bacon, pepperoni sausage, tomatoes, chicken breast, garlic, red onion, greens.",
        img: "/images/pizzas/pizzaman.png",
        name: "Pizzaman",
        price: 5,
        type: ProductType.Pizza
    },
    {
        id: 2,
        description: "<b>Ingredients:</b> pizza sauce, Mozzarella and Parmesan cheeses, champignons, bacon, pepperoni sausage, tomatoes, chicken breast, garlic, red onion, greens.",
        img: "/images/pizzas/pizzaman.png",
        name: "Pizzaman",
        price: 5,
        type: ProductType.Pizza
    },
    {
        id: 3,
        description: "<b>Ingredients:</b> pizza sauce, Mozzarella and Parmesan cheeses, champignons, bacon, pepperoni sausage, tomatoes, chicken breast, garlic, red onion, greens.",
        img: "/images/pizzas/pizzaman.png",
        name: "Pizzaman",
        price: 5,
        type: ProductType.Pizza
    },
    {
        id: 4,
        description: "<b>Ingredients:</b> pizza sauce, Mozzarella and Parmesan cheeses, champignons, bacon, pepperoni sausage, tomatoes, chicken breast, garlic, red onion, greens.",
        img: "/images/pizzas/pizzaman.png",
        name: "Pizzaman",
        price: 5,
        type: ProductType.Pizza
    },
    {
        id: 5,
        description: "<b>Ingredients:</b> pizza sauce, Mozzarella and Parmesan cheeses, champignons, bacon, pepperoni sausage, tomatoes, chicken breast, garlic, red onion, greens.",
        img: "/images/pizzas/pizzaman.png",
        name: "Pizzaman",
        price: 5,
        type: ProductType.Pizza
    },
    {
        id: 6,
        description: "<b>Ingredients:</b> pizza sauce, Mozzarella and Parmesan cheeses, champignons, bacon, pepperoni sausage, tomatoes, chicken breast, garlic, red onion, greens.",
        img: "/images/pizzas/pizzaman.png",
        name: "Pizzaman",
        price: 5,
        type: ProductType.Pizza
    },
    {
        id: 7,
        description: "<b>Ingredients:</b> pizza sauce, Mozzarella and Parmesan cheeses, champignons, bacon, pepperoni sausage, tomatoes, chicken breast, garlic, red onion, greens.",
        img: "/images/pizzas/pizzaman.png",
        name: "Pizzaman",
        price: 5,
        type: ProductType.Pizza
    }
];

export class ProductService {
    public static async  GetAll(): Promise<IGetAllResponse> {
        const result: IGetAllResponse = {} as IGetAllResponse;
        result.items = PIZZAS;

        return result;
    }
}