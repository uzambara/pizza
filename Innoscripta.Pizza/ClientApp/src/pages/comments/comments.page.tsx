import {withPageWrapper} from "../../hocs";
import React, {memo, useCallback, useLayoutEffect, useMemo, useRef} from "react";
import {IPageProps} from "../page-props";
import {PizzaCommentForm, PizzaCommentList, PizzaModal} from "../../components";
import {useDispatch} from "react-redux";
import {commentActions} from "../../redux/actions";
import {IComment} from "../../models";
import * as styles from "./comments.page.scss";
import {BehaviorSubject, Subject} from "rxjs";

function CommentsPageComponent() {
    const dispatch = useDispatch();
    const resetFormSubject = useRef(new BehaviorSubject<boolean>(false));

    const createComment = useCallback((comment: IComment) => {
        dispatch(commentActions.createCommentRemote(comment, resetFormSubject.current));
    }, []);

    return <section>
        <PizzaCommentForm onSubmit={createComment} className={styles.commentForm} resetForm$={resetFormSubject.current}/>
        <PizzaCommentList/>
    </section>
}

export const CommentsPage = memo(withPageWrapper<IPageProps>(CommentsPageComponent));