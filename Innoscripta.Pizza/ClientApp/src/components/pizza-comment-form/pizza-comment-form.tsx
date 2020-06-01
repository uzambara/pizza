import React, {useEffect} from "react";
import {reduxForm, Field, InjectedFormProps} from "redux-form";
import {IComment} from "../../models";
import cn from "classnames";
import {PizzaButton, PizzaStars} from "..";
import * as styles from "./pizza-comment-form.scss";
import {useSelector} from "react-redux";
import {languageSelectors} from "../../redux/selectors";
import {Subject} from "rxjs";

interface IPizzaFormProps {
    className?: string,
    resetForm$?: Subject<boolean>
}

function PizzaCommentFormComponent(props: InjectedFormProps<IComment> & IPizzaFormProps) {
    const {handleSubmit, className, reset, resetForm$} = props;
    const {
        Title,
        AddButton,
        CommentLabel,
        NameLabel,
        PhoneLabel
    } = useSelector(languageSelectors.selectAddCommentForm);
    useEffect(() => {
        resetForm$.subscribe(v => reset());
        return () => resetForm$.unsubscribe();
    }, [resetForm$]);
    return <form onSubmit={handleSubmit} className={cn(styles.form, className)}>
        <h3 className={styles.title}>{Title}</h3>
        <label className={styles.nameLabel}>
            {NameLabel}
            <Field name="name" component="input" className={styles.input}/>
        </label>
        <label className={styles.phoneLabel}>
            {PhoneLabel}
            <Field name="phone" component="input" className={styles.input}/>
        </label>

        <label className={styles.commentLabel}>
            {CommentLabel}
            <Field name="text" component="textarea" className={cn(styles.input, styles.inputTextarea)}/>
        </label>
        <div className={styles.starsAndSubmitWrapper}>
            <PizzaButton className={styles.submitButton} onClick={() => {}} style="submit" type="submit">{AddButton}</PizzaButton>
            <Field name="stars" component={PizzaStars} className={styles.pizzaStars}/>
        </div>
    </form>
}

export const PizzaCommentForm = reduxForm<IComment, IPizzaFormProps>({form: "PizzaCommentForm"})(PizzaCommentFormComponent);