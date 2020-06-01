import {reduxForm, Field, InjectedFormProps} from "redux-form";
import {IRegistrationFormData} from "../../models";
import React from "react";
import cn from "classnames";
import * as styles from "./pizza-registration-form.scss";
import {PizzaButton} from "..";
import {actionMock} from "../../constants";
import {useSelector} from "react-redux";
import {languageSelectors} from "../../redux/selectors";

export interface IPizzaRegistrationFormProps {
    className?: string,
    onCancel: () => void
}

function PizzaRegistrationFormComponent(props: InjectedFormProps<IRegistrationFormData> & IPizzaRegistrationFormProps) {
    const {className, onCancel, handleSubmit} = props;
    const {
        CancelButton,
        LastNameLabel,
        NameLabel,
        PhoneLabel,
        SubmitButton,
        PasswordConfirmLabel,
        PasswordLabel,
        Title
    } = useSelector(languageSelectors.selectRegistrationForm);

    return <form className={cn(styles.registrationForm, className)} onSubmit={handleSubmit}>
        <h3 className={styles.title}>{Title}</h3>
        <label className={styles.label}>{NameLabel}</label>
        <Field className={styles.input} name="name" component="input"/>
        <label className={styles.label}>{LastNameLabel}</label>
        <Field className={styles.input} name="lastName" component="input"/>
        <label className={styles.label}>{PhoneLabel}</label>
        <Field className={styles.input} name="phone" component="input"/>
        <label className={styles.label}>{PasswordLabel}</label>
        <Field className={styles.input} name="password" component="input" type="password"/>
        <label className={styles.label}>{PasswordConfirmLabel}</label>
        <Field className={styles.input} name="confirmPassword" component="input" type="password"/>
        <PizzaButton style="submit" onClick={actionMock} type="submit" className={styles.submitButton}>{SubmitButton}</PizzaButton>
        <PizzaButton style="simple" onClick={onCancel} type="button" className={styles.cancelButton}>{CancelButton}</PizzaButton>
    </form>
}

export const PizzaRegistrationForm =
    reduxForm<IRegistrationFormData, IPizzaRegistrationFormProps>({form: "PizzaRegistrationForm"})(PizzaRegistrationFormComponent);