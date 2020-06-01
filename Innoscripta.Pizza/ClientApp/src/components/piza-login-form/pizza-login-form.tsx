import {reduxForm, Field, InjectedFormProps} from "redux-form";
import {ILoginFormData} from "../../models";
import React from "react";
import cn from "classnames";
import {PizzaButton} from "..";
import {actionMock} from "../../constants";
import {useSelector} from "react-redux";
import {languageSelectors} from "../../redux/selectors";
import * as styles from "./pizza-login-form.scss";

export interface ILoginFormProps {
    className?: string,
    onCancel: () => void,
    onRegistrationClick: () => void
}

function PizzaLoginFormComponent(props: InjectedFormProps<ILoginFormData> & ILoginFormProps) {
    const {className, onCancel, onRegistrationClick, handleSubmit} = props;
    const {
        CancelButton,
        PhoneLabel,
        PasswordLabel,
        SubmitButton,
        RegistrationButton,
        Title
    } = useSelector(languageSelectors.selectLoginForm);

    return <form className={cn(styles.loginForm, className)} onSubmit={handleSubmit}>
        <h3 className={styles.title}>{Title}</h3>
        <label className={styles.label}>{PhoneLabel}</label>
        <Field className={styles.input} name="phone" component="input"/>
        <label className={styles.label}>{PasswordLabel}</label>
        <Field className={styles.input} name="password" component="input"/>
        <PizzaButton style="submit" onClick={actionMock} type="submit" className={styles.submitButton}>{SubmitButton}</PizzaButton>
        <PizzaButton style="simple" onClick={onCancel} type="button" className={styles.cancelButton}>{CancelButton}</PizzaButton>
        <PizzaButton style="simple" onClick={onRegistrationClick} type="button" className={styles.registrationButton}>{RegistrationButton}</PizzaButton>
    </form>
}

export const PizzaLoginForm =
    reduxForm<ILoginFormData, ILoginFormProps>({form: "PizzaLoginForm"})(PizzaLoginFormComponent);