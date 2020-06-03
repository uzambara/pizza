import {IContentStrings} from "./index";

export const englishStrings: IContentStrings = {
    Common: {
        PiecesUnits: "pc"
    },
    Account: {
        LoginSuccessfully: "Login successfully",
        LogoutSuccessfully: "Logout successfully",
        RegisteredSuccessfully: "Registered successfully"
    },
    Toasts: {
        AddCommentToast: {
            Text: "Comment created successfully",
            Title: ""},
        MakeOrderToast: {
            Title: "Order is accepted",
            Text: "expect delivery within an hour"
        }
    },
    Header: {
        SignInButton: "Sign in",
        SignOutButton: "Sign out",
        HeaderMainMenu: {
            Comments: "Comments",
            Drinks: "Drinks",
            Pizza: "Hot pizza",
            Profile: "Profile"
        }
    },
    Pages: {
        CommentsPage: {
            Title: "Comments"
        }, DrinksPage: {
            Title: "Cold drinks"
        },
        PizzaPage: {
            Title: "Hot pizza"
        },
        CartPage: {
            Title: "Your order",
            BuyButton: "Buy"
        },
        ProfilePage: {
            Title: "Profile",
            OrdersHistory: {
                Comment: "Сomment",
                Details: "details"
            },
            Statistic: {
                OrdersCount: "Orders count",
                TotalOrdersPrice: "Total orders price",
                Bonus: "Bonus",
                User: "User",
                Phone: "Phone"
            }
        }
    },
    ProductCard: {
        BuyButton: "Buy"
    },
    Errors: {
        CommonError: "An error has occurred. Please try again later.",
        Account: {
            UserWithTheSameNumberExists: "User with the same number exists",
            IncorrectPassword: "Incorrect password",
            UserNotFound: "The username you entered is incorrect"
        },
        Validation: {
            CommentText: "Comment could not be empty",
            Phone: "Phone could not be empty",
            Name: "Name could not be empty",
            Password: "Password could not be empty",
            PasswordEquality: "Passwords must match"
        }
    },
    Forms: {
        AddComment: {
            AddButton: "Add",
            CommentLabel: "Comment",
            NameLabel: "Name",
            PhoneLabel: "Phone",
            Title: "Make us better"
        },
        MakeOrder: {
            AddressLabel: "Address",
            FirstNameLabel: "First Name",
            LastNameLabel: "Last Name",
            PhoneLabel: "Phone",
            CommentLabel: "Comment",
            SubmitButton: "Submit",
            CancelButton: "Cancel",
        },
        RegistrationForm: {
            NameLabel: "Name",
            LastNameLabel: "Last Name",
            PhoneLabel: "Phone",
            PasswordLabel: "Password",
            PasswordConfirmLabel: "Confirm password",
            SubmitButton: "Register",
            CancelButton: "Cancel",
            Title: "Registration"
        },
        LoginForm: {
            PhoneLabel: "Phone",
            PasswordLabel: "Password",
            SubmitButton: "Login",
            CancelButton: "Cancel",
            RegistrationButton: "Registration",
            Title: "Login"
        }
    }
};