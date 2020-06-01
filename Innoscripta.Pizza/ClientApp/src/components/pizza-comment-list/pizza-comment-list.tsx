import React, {memo, useCallback} from "react";
import {usePartialLoadData} from "../../hooks/use-load-data";
import {CommentService} from "../../services";
import {ICommentModelRemote} from "../../models-remote";
import {PizzaComment} from "..";
import * as styles from "./pizza-comment-list.scss";
import {useScrollToBottomTracking} from "../../hooks";

function PizzaCommentListComponent() {
    const {load, items} = usePartialLoadData<ICommentModelRemote>(5, CommentService.GetComments);
    const {ref} = useScrollToBottomTracking(load);

    return <ul className={styles.commentsList} ref={ref}>
        {
            items.map((comment, idx) =>
                <PizzaComment key={idx} comment={comment} className={styles.comment}/>)
        }
    </ul>
}


export const PizzaCommentList = memo(PizzaCommentListComponent);