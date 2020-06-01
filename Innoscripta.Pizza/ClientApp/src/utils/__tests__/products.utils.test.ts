import {IProductModelRemote} from "../../models-remote";
import {LanguageType, ProductType} from "../../enums";
import {productUtils} from "../products.utils";

describe("product utils tests", () => {
    it("should return products by type", () => {
        // Arrange
        const products: IProductModelRemote[] = [
            {type: ProductType.Drink, nameRu: "drink 1"} as IProductModelRemote,
            {type: ProductType.Pizza, nameRu: "pizza 1"} as IProductModelRemote,
            {type: ProductType.Drink, nameRu: "drink 2"} as IProductModelRemote,
            {type: ProductType.Drink, nameRu: "drink 3"} as IProductModelRemote,
            {type: ProductType.Drink, nameRu: "drink 4"} as IProductModelRemote,
        ];

        // Act
        let result = productUtils.getProductsByType(products, ProductType.Pizza);

        // Assert
        expect(result).toHaveLength(1);
        expect(result[0]).toEqual({type: ProductType.Pizza, nameRu: "pizza 1"});

        // Act
        result = productUtils.getProductsByType(products, ProductType.Drink);

        // Assert
        expect(result).toHaveLength(4);
        expect(result.find(pr => pr.nameRu === "drink 1")).toBeDefined();
        expect(result.find(pr => pr.nameRu === "drink 2")).toBeDefined();
        expect(result.find(pr => pr.nameRu === "drink 3")).toBeDefined();
        expect(result.find(pr => pr.nameRu === "drink 4")).toBeDefined();
    });

    it("should return empty array if no products with given type", () => {
        // Arrange
        const products: IProductModelRemote[] = [
            {type: ProductType.Drink, nameRu: "drink 1"} as IProductModelRemote,
            {type: ProductType.Drink, nameRu: "drink 2"} as IProductModelRemote,
            {type: ProductType.Drink, nameRu: "drink 3"} as IProductModelRemote,
            {type: ProductType.Drink, nameRu: "drink 4"} as IProductModelRemote,
        ];

        // Act
        let result = productUtils.getProductsByType(products, ProductType.Pizza);

        // Assert
        expect(result).toEqual([]);
    });


    it.each([
        [
            {
                nameRu: "name ru",
                nameEng: "name eng",
                descriptionRu: "description ru",
                descriptionEng: "description eng",
            },
            LanguageType.RUS,
            {
                name: "name ru",
                description: "description ru"
            }
        ],
        [
            {
                nameRu: "name ru",
                nameEng: "name eng",
                descriptionRu: "description ru",
                descriptionEng: "description eng",
            },
            LanguageType.ENG,
            {
                name: "name eng",
                description: "description eng"
            }
        ]
    ])("should return name and description on right language", (
        product: IProductModelRemote,
        langType: LanguageType,
        expectedResult: {name: string, description: string} ) => {
        // Arrange

        // Act
        const result = productUtils.getNameAndDescription(product, langType);

        // Assert
        expect(result).toEqual(expectedResult);
    });
});