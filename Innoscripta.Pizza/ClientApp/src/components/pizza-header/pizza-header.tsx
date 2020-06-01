import React, {memo, useCallback, useEffect, useState} from "react";
import {
    ISelectItem,
    PizzaButton,
    PizzaLink,
    PizzaLoginForm,
    PizzaLogo,
    PizzaModal,
    PizzaRegistrationForm,
    PizzaSelect
} from "..";
import {Images} from "../../images";
import cn from "classnames";
import {Routing} from "../../routing";
import {PizzaCart} from "../pizza-cart/pizza-cart";
import {CurrencyType, LanguageType} from "../../enums";
import {useSizeChanged, useTrigger} from "../../hooks";
import {useDispatch, useSelector} from "react-redux";
import {userSelectors, languageSelectors, settingsSelectors} from "../../redux/selectors";
import {accountActions, languageActions, settingsActions} from "../../redux/actions";
import * as styles from "./pizza-header.scss";
import {languageUtils} from "../../utils";
import {ILoginFormData, IRegistrationFormData} from "../../models";

export interface IPizzaHeaderProps {
    className?: string,
    onHeightChanged: (height: number) => void,
    totalPrice: number
}

const currencies: ISelectItem[] = [
    {text: "USD", value: CurrencyType.USD},
    {text: "EUR", value: CurrencyType.EUR}
];

function PizzaHeaderComponent(props: IPizzaHeaderProps) {
    const {className, onHeightChanged, totalPrice} = props;
    const dispatch = useDispatch();

    const [menuOpened, setMenuOpened] = useState(false);
    const {ref: headerRef, size: headerSize} = useSizeChanged();

    const {HeaderMainMenu, SignInButton, SignOutButton} = useSelector(languageSelectors.selectHeader);
    const currencyType = useSelector(settingsSelectors.selectCurrencyType);
    const language = useSelector(languageSelectors.selectLanguageType);

    // CurrentUser
    const currentUser = useSelector(userSelectors.selectCurrentUser);

    // Currency
    const changeCurrencyType = useCallback((currencyType: CurrencyType) => {
        dispatch(settingsActions.changeCurrencyType(currencyType));
    }, []);

    // Language
    const changeLanguage = useCallback((languageType: LanguageType) => {
        dispatch(languageActions.setLanguage(languageType));
    }, []);

    // Main Content top padding
    useEffect(() => {
        onHeightChanged(headerSize.height);
    }, [headerSize]);

    // Menu
    const onMenuClick = () => {
        setMenuOpened(!menuOpened);
    };
    const closeMenu = () => setMenuOpened(false);

    // Account
    const {
        value: registrationFormOpened,
        offTrigger: closeRegistrationForm,
        onTrigger: openRegistrationForm
    } = useTrigger(false);
    const {
        value: loginFormOpened,
        offTrigger: closeLoginForm,
        onTrigger: openLoginForm
    } = useTrigger(false);

    const login = (formData: ILoginFormData) => {
        dispatch(accountActions.loginRemote(formData, closeLoginForm));
    };
    const register = (formData: IRegistrationFormData) => {
        dispatch(accountActions.registerRemote(formData, closeRegistrationForm));
    };
    const logout = () => {
        dispatch(accountActions.logoutRemote());
    };

    return <header className={cn(styles.wrapper, className)} ref={headerRef}>
        {/*Logo  phone and toggle meny button*/}
        <div className={styles.header}>
            <PizzaLogo className={styles.logo}/>
            <a className={styles.phone} href="tel:88005000668">
                <img className={styles.phoneImage} alt="phone" src={Images.Shared.phone}/>
                8 800 500 06 68
            </a>
            <button
                className={styles.menuToggleButton}
                onClick={onMenuClick}
                style={{backgroundImage: `url(${menuOpened ? Images.Shared.cross : Images.Shared.toggleBurger})`}}
            >
            </button>
        </div>

        {/*Header main menu and buttons*/}
        <div className={cn(styles.menuListWrapper, {[styles.menuListWrapperOpened]: menuOpened})}>
            <ul className={styles.menuList}>
                <li className={styles.menuItem}>
                    <img className={styles.menuItemImage} src={Images.Menu.pizza} alt="pizza"/>
                    <PizzaLink onClick={closeMenu} className={styles.menuItemLink} href={Routing.PizzaMenu}>{HeaderMainMenu.Pizza}</PizzaLink></li>
                <li className={styles.menuItem}>
                    <img className={styles.menuItemImage} src={Images.Menu.drinks} alt="drinks"/>
                    <PizzaLink onClick={closeMenu} className={styles.menuItemLink} href={Routing.DrinksMenu}>{HeaderMainMenu.Drinks}</PizzaLink>
                </li>
                <li className={styles.menuItem}>
                    <img className={styles.menuItemImage} src={Images.Menu.comments} alt="comments"/>
                    <PizzaLink onClick={closeMenu} className={styles.menuItemLink} href={Routing.Comments}>{HeaderMainMenu.Comments}</PizzaLink>
                </li>
                {currentUser &&
                    <li className={styles.menuItem}>
                        <img className={styles.menuItemImage} src={Images.Menu.profile} alt="profile"/>
                        <PizzaLink onClick={closeMenu} className={styles.menuItemLink} href={Routing.Profile}>{HeaderMainMenu.Profile}</PizzaLink>
                    </li>
                }
            </ul>
            <div className={styles.delimiter}/>
            <div className={styles.buttonsWrapper}>
                { !currentUser
                    ? <PizzaButton onClick={openLoginForm} style={"submit"} className={styles.signInItem}>
                        {SignInButton}
                    </PizzaButton>
                    : <PizzaButton onClick={logout} style={"submit"} className={styles.signInItem}>
                        {SignOutButton}
                    </PizzaButton>
                }

                <PizzaSelect
                    className={styles.currencySelect}
                    items={currencies}
                    onChange={changeCurrencyType}
                    value={currencyType}
                />
                <div className={styles.languageSelectWrapper}>
                    <img className={styles.languageImage} src={languageUtils.getLanguageImageByType(language)} alt="lang"/>
                    <PizzaSelect
                        className={styles.languageSelect}
                        items={[{text: LanguageType.ENG, value: LanguageType.ENG}, {text: LanguageType.RUS, value: LanguageType.RUS}]}
                        onChange={changeLanguage}
                        value={language}
                    />
                </div>
            </div>
        </div>

        {/*Cart button*/}
        <PizzaCart className={styles.cart} totalPrice={totalPrice} currencyType={currencyType}/>

        {/*Login and registration*/}
        <PizzaModal
            isOpen={loginFormOpened}
            classNameContainer={styles.registrationFormModalContainer}
            classNameModal={styles.registrationFormModal}
        >
            <PizzaLoginForm
                onSubmit={login}
                onCancel={closeLoginForm}
                onRegistrationClick={() => {
                    closeLoginForm();
                    openRegistrationForm();
                }}
            />
        </PizzaModal>
        <PizzaModal
            isOpen={registrationFormOpened}
            classNameContainer={styles.registrationFormModalContainer}
            classNameModal={styles.registrationFormModal}
        >
            <PizzaRegistrationForm
                onSubmit={register}
                onCancel={closeRegistrationForm}
            />
        </PizzaModal>
    </header>
}

export const PizzaHeader = memo(PizzaHeaderComponent);