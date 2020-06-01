import {IContentStrings} from "./index";

export const russianStrings: IContentStrings = {
    Common: {
        PiecesUnits: "шт."
    },
    Account: {
        LoginSuccessfully: "Вход успешно выполнен",
        LogoutSuccessfully: "Выход успешно выполнен",
        RegisteredSuccessfully: "Регистрация успешна завершена"
    },
    Toasts: {
        AddCommentToast: {
            Text: "Комментарий добавлен",
            Title: ""},
        MakeOrderToast: {
            Title: "Заказ принят",
            Text: "ожидайте доставку в течении часа"
        }
    },
    Header: {
        SignInButton: "Войти",
        SignOutButton: "Выйти",
        HeaderMainMenu: {
            Comments: "Комментарии",
            Drinks: "Напитки",
            Pizza: "Горячая пицца",
            Profile: "Личный кабинет"
        },
    },
    Pages: {
        CommentsPage: {
            Title: "Комментарии"
        }, DrinksPage: {
            Title: "Холодные напитки"
        },
        PizzaPage: {
            Title: "Горячая пицца"
        },
        CartPage: {
            Title: "Ваш заказ",
            BuyButton: "Заказать"
        },
        ProfilePage: {
            Title: "Личный кабинет",
            OrdersHistory: {
                Comment: "Комментарий",
                Details: "подробнее"
            },
            Statistic: {
                OrdersCount: "Кол-во заказов",
                TotalOrdersPrice: "Заказов на сумму",
                Bonus: "Бонусы",
                User: "Пользователь",
                Phone: "Теленфон"
            }
        }
    },
    ProductCard: {
        BuyButton: "Добавить"
    },
    Errors: {
        CommonError: "Произошла ошибка. Повторите попытку позже.",
        Account: {
            UserWithTheSameNumberExists: "Пользователь с таким номером телефона уже зарегистрирован",
            IncorrectPassword: "Неверный пароль",
            UserNotFound: "Не верное имя пользователя"
        },
        Validation: {
            CommentText: "Комментарий не может быть пустым",
            Phone: "Телефон не может быть пустым",
            Name: "Имя не может быть пустым",
            Password: "Пароль не может быть пустым",
            PasswordEquality: "Пароли должны совпадать"
        }
    },
    Forms: {
        AddComment: {
            AddButton: "Добавить",
            CommentLabel: "Комментарий",
            NameLabel: "Имя",
            PhoneLabel: "Телефон",
            Title: "Сделайте нас лучше"
        },
        MakeOrder: {
            AddressLabel: "Адрес",
            FirstNameLabel: "Имя",
            LastNameLabel: "Фамилия",
            PhoneLabel: "Телефон",
            CommentLabel: "Комментарий",
            SubmitButton: "Подтвердить",
            CancelButton: "Отмена",
        },
        RegistrationForm: {
            NameLabel: "Имя",
            LastNameLabel: "Фамилия",
            PhoneLabel: "Телефон",
            PasswordLabel: "Пароль",
            PasswordConfirmLabel: "Повторите пароль",
            SubmitButton: "Зарегистрировать",
            CancelButton: "Отмена",
            Title: "Регистрация"
        },
        LoginForm: {
            PhoneLabel: "Телефон",
            PasswordLabel: "Пароль",
            SubmitButton: "Войти",
            CancelButton: "Отмена",
            RegistrationButton: "Регистрация",
            Title: "Логин"
        }
    }
};