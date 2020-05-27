import {withPageWrapper} from "../../hocs";
import React, {memo} from "react";
import {IPageProps} from "../page-props";
import {PizzaCommentForm} from "../../components";

function CommentsPageComponent() {
    return <section>
        <PizzaCommentForm onSubmit={(data) => console.log(data)}/>
    </section>
}

export const CommentsPage = memo(withPageWrapper<IPageProps>(CommentsPageComponent));