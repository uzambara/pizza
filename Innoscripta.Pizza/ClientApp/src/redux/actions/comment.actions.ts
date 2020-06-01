import {IComment} from "../../models";
import {Dispatch} from "redux";
import {CommentService} from "../../services";
import {responseHandleUtils, validationErrorsUtils} from "../../utils";
import {IGlobalState} from "../reducers";
import {CommentValidator} from "../../validators";
import {Subject} from "rxjs";
import {ResponseCode} from "../../contratcs";

const createCommentRemote = (comment: IComment, resetForm$: Subject<boolean>) => async (dispatch: Dispatch, getState: () => IGlobalState) => {
    const {
        language: {
            contentStrings
        }
    } = getState();
    const validator = new CommentValidator(contentStrings);
    const validationResult = validator.validate(comment);
    if(!validationResult.isValid) {
        validationErrorsUtils.handleValidationErrors(validationResult);
        return;
    }
    const response = await CommentService.CreateComment(comment);
    if(response.code == ResponseCode.Ok) {
        resetForm$.next(true);
    }
    const state = getState();
    responseHandleUtils.comment.handleCreateComment(response, state.language.contentStrings);
};

export const commentActions = {
    createCommentRemote
};