import React from "react";
import {reduxForm, Field} from "redux-form";
import {PizzaButton} from "..";
import cn from "classnames";
import * as styles from "./pizza-order-form.scss";


const submitMock = () => {};

let PizzaOrderFormComponent = (props) => {
    const {handleSubmit} = props;
    return <form className={styles.orderForm} onSubmit={handleSubmit}>
        <label className={styles.label}>Address</label>
        <Field className={styles.field} name="address" component="input" type="text"/>
        <label className={styles.label}>First Name</label>
        <Field className={styles.field} name="firstName" component="input"/>
        <label className={styles.label}>Last Name</label>
        <Field className={styles.field} name="lastName" component="input"/>
        <label className={styles.label}>Phone</label>
        <Field className={styles.field} name="phone" component="input"/>
        <label className={styles.label}>Comment</label>
        <Field className={cn(styles.field, styles.fieldTextarea)} name="comment" component="textarea"/>
        <PizzaButton style="submit" onClick={submitMock} type="submit" className={styles.submitButton}>Submit</PizzaButton>
    </form>
};

export interface IPizzaOrderFormData {
    address: string,
    firstName: string,
    lastName: string
}

export const PizzaOrderForm = reduxForm<IPizzaOrderFormData>({form: "PizzaOrderForm"})(PizzaOrderFormComponent);