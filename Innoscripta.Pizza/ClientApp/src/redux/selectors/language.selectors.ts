import {IGlobalState} from "../reducers";

const selectLanguageType = (state: IGlobalState) => state.language.languageType;
const selectContentStrings = (state: IGlobalState) => state.language.contentStrings;

// Common
const selectCommon = (state: IGlobalState) => state.language.contentStrings.Common;

// Pages
const selectPages = (state: IGlobalState) => state.language.contentStrings.Pages;
const selectPizzaPage = (state: IGlobalState) => state.language.contentStrings.Pages.PizzaPage;
const selectDrinksPage = (state: IGlobalState) => state.language.contentStrings.Pages.DrinksPage;
const selectCommentsPage = (state: IGlobalState) => state.language.contentStrings.Pages.CommentsPage;
const selectCartPage = (state: IGlobalState) => state.language.contentStrings.Pages.CartPage;
const selectProfilePage = (state: IGlobalState) => state.language.contentStrings.Pages.ProfilePage;

// Header
const selectHeader = (state: IGlobalState) => state.language.contentStrings.Header;

const selectProductCard = (state: IGlobalState) => state.language.contentStrings.ProductCard;

// Forms
const selectAddCommentForm = (state: IGlobalState) => state.language.contentStrings.Forms.AddComment;
const selectMakeOrderForm = (state: IGlobalState) => state.language.contentStrings.Forms.MakeOrder;
const selectRegistrationForm = (state: IGlobalState) => state.language.contentStrings.Forms.RegistrationForm;
const selectLoginForm = (state: IGlobalState) => state.language.contentStrings.Forms.LoginForm;

export const languageSelectors = {
    selectLanguageType,
    selectContentStrings,
    selectPages,
    selectPizzaPage,
    selectDrinksPage,
    selectCommentsPage,
    selectCartPage,
    selectHeader,
    selectProductCard,
    selectAddCommentForm,
    selectMakeOrderForm,
    selectRegistrationForm,
    selectLoginForm,
    selectProfilePage,
    selectCommon
};