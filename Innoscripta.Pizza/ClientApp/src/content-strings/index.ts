import { englishStrings } from "./english-strings";
import { russianStrings } from "./russian-strings";

interface IContentStrings {
    Common: {
        PiecesUnits: string
    }
    Toasts: {
        MakeOrderToast: {
            Title: string,
            Text: string
        },
        AddCommentToast: {
            Title: string,
            Text: string
        },
    },
    Errors: {
        CommonError: string
        Account: {
            "UserWithTheSameNumberExists": string,
            "UserNotFound": string,
            "IncorrectPassword": string
        },
        Validation: {
            CommentText: string,
            Phone: string,
            Name: string,
            Password: string,
            PasswordEquality: string
        }
    },
    Header: {
        SignInButton: string,
        SignOutButton: string,
        HeaderMainMenu: {
            Pizza: string,
            Drinks: string,
            Comments: string,
            Profile: string,
        },
    }

    Pages: {
        CommentsPage: {
            Title: string
        },
        DrinksPage: {
            Title: string
        },
        PizzaPage: {
            Title: string
        },
        CartPage: {
            Title: string,
            BuyButton: string
        },
        ProfilePage: {
            Title: string,
            OrdersHistory: {
                Comment: string,
                Details: string
            },
            Statistic: {
                OrdersCount: string,
                TotalOrdersPrice: string,
                Bonus: string,
                User: string,
                Phone: string,
            }
        }
    },
    ProductCard: {
        BuyButton: string
    },
    Forms: {
        AddComment: {
            Title: string,
            NameLabel: string,
            PhoneLabel: string,
            CommentLabel: string,
            AddButton: string
        },
        MakeOrder: {
            AddressLabel: string,
            FirstNameLabel: string,
            LastNameLabel: string,
            PhoneLabel: string,
            CommentLabel: string,
            SubmitButton: string,
            CancelButton: string,
        },
        RegistrationForm: {
            NameLabel: string,
            LastNameLabel: string,
            PhoneLabel: string,
            PasswordLabel: string,
            PasswordConfirmLabel: string,
            SubmitButton: string,
            CancelButton: string,
            Title: string
        },
        LoginForm: {
            PhoneLabel: string,
            PasswordLabel: string,
            SubmitButton: string,
            CancelButton: string,
            RegistrationButton: string,
            Title: string
        }
    },
    Account: {
        "RegisteredSuccessfully": string,
        "LogoutSuccessfully": string,
        "LoginSuccessfully": string,
    }
}

export {
    IContentStrings,
    englishStrings,
    russianStrings
}