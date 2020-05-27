import React, {useCallback} from "react";
import {reduxForm, Field, InjectedFormProps} from "redux-form";
import {PizzaButton} from "..";
import cn from "classnames";
import * as styles from "./pizza-order-form.scss";
import {IMakeOrderFormData} from "../../models";
import {OrderService} from "../../services/order.service";

export interface IPizzaOrderFormProps {
    onCancel: () => void
}

const submitMock = () => {};

let PizzaOrderFormComponent = (props: InjectedFormProps<IMakeOrderFormData> & IPizzaOrderFormProps) => {
    const {handleSubmit, onCancel} = props;

    return <form className={styles.orderForm} onSubmit={handleSubmit}>
        <label className={styles.label}>Address</label>
        <Field className={styles.field} name="address" component="input" type="text"/>
        <label className={styles.label}>First Name</label>
        <Field className={styles.field} name="name" component="input"/>
        <label className={styles.label}>Last Name</label>
        <Field className={styles.field} name="lastName" component="input"/>
        <label className={styles.label}>Phone</label>
        <Field className={styles.field} name="phone" component="input"/>
        <label className={styles.label}>Comment</label>
        <Field className={cn(styles.field, styles.fieldTextarea)} name="comment" component="textarea"/>
        <PizzaButton style="submit" onClick={submitMock} type="submit" className={styles.submitButton}>Submit</PizzaButton>
        <PizzaButton style="simple" onClick={onCancel} type="button" className={styles.submitButton}>Cancel</PizzaButton>
    </form>
};



export const PizzaOrderForm = reduxForm<IMakeOrderFormData, IPizzaOrderFormProps>({form: "PizzaOrderForm"})(PizzaOrderFormComponent);