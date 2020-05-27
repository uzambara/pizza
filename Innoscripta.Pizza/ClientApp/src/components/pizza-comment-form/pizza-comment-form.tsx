import React from "react";
import {reduxForm, Field, InjectedFormProps} from "redux-form";
import {IComment} from "../../models";
import * as styles from "./pizza-comment-form.scss";
import cn from "classnames";
import {PizzaButton} from "..";
import {PizzaStars} from "../pizza-stars/pizza-stars";

function PizzaCommentFormComponent(props: InjectedFormProps<IComment>) {
    const {handleSubmit} = props;
    return <form onSubmit={handleSubmit} className={styles.form}>
        <h3 className={styles.title}>Make us better</h3>
        <label className={styles.nameLabel}>
            Name
            <Field name="name" component="input" className={styles.input}/>
        </label>

        <label className={styles.phoneLabel}>
            Phone
            <Field name="phone" component="input" className={styles.input}/>
        </label>

        <label className={styles.commentLabel}>
            Comment
            <Field name="comment" component="textarea" className={cn(styles.input, styles.inputTextarea)}/>
        </label>
        <PizzaButton onClick={() => {}} style="submit" type="submit">Add</PizzaButton>
        <Field name="stars" component={PizzaStars} className={cn(styles.input, styles.inputTextarea)}/>
    </form>
}

export const PizzaCommentForm = reduxForm<IComment, any>({form: "PizzaCommentForm"})(PizzaCommentFormComponent);