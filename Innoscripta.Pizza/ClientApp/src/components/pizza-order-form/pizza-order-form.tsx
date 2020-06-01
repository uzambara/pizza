import React from "react";
import {reduxForm, Field, InjectedFormProps} from "redux-form";
import {PizzaButton} from "..";
import cn from "classnames";
import * as styles from "./pizza-order-form.scss";
import {IMakeOrderFormData} from "../../models";
import {useSelector} from "react-redux";
import {languageSelectors} from "../../redux/selectors";
import {useCurrentUser} from "../../hooks";

export interface IPizzaOrderFormProps {
    onCancel: () => void
}

const submitMock = () => {};

function PizzaOrderFormComponent(props: InjectedFormProps<IMakeOrderFormData> & IPizzaOrderFormProps) {
    const {currentUser} = useCurrentUser();
    const {handleSubmit, onCancel} = props;
    const {
        AddressLabel,
        CancelButton,
        CommentLabel,
        FirstNameLabel,
        LastNameLabel,
        PhoneLabel,
        SubmitButton
    } = useSelector(languageSelectors.selectMakeOrderForm);

    return <form className={styles.orderForm} onSubmit={handleSubmit}>
        <label className={styles.label}>{AddressLabel}</label>
        <Field className={styles.field} name="address" component="input" type="text"/>
        <label className={styles.label}>{FirstNameLabel}</label>
        <Field className={styles.field} name="name" component="input"/>
        <label className={styles.label}>{LastNameLabel}</label>
        <Field className={styles.field} name="lastName" component="input" value={"Sdfsafsdaf"}/>
        <label className={styles.label}>{PhoneLabel}</label>
        <Field className={styles.field} name="phone" component="input"/>
        <label className={styles.label}>{CommentLabel}</label>
        <Field className={cn(styles.field, styles.fieldTextarea)} name="comment" component="textarea"/>
        <PizzaButton style="submit" onClick={submitMock} type="submit" className={styles.submitButton}>{SubmitButton}</PizzaButton>
        <PizzaButton style="simple" onClick={onCancel} type="button" className={styles.cancelButton}>{CancelButton}</PizzaButton>
    </form>
}

export const PizzaOrderForm = (props) => {
    const {currentUser} = useCurrentUser();
    let initialFormState: IMakeOrderFormData = {} as IMakeOrderFormData;
    if(currentUser) {
        initialFormState = {
            name: currentUser.name,
            lastName: currentUser.lastName,
            phone: currentUser.phone
        } as IMakeOrderFormData;
    }
    const Component = reduxForm<IMakeOrderFormData, IPizzaOrderFormProps>({
        form: "PizzaOrderForm",
        initialValues: initialFormState
    })(PizzaOrderFormComponent);
    return <Component {...props}/>
};