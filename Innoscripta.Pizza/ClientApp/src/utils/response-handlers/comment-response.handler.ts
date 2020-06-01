import {IBaseResponse, ResponseCode} from "../../contratcs";
import {Toasts} from "../../components";
import {IContentStrings} from "../../content-strings";

function handleCreateComment(response: IBaseResponse, contentStrings: IContentStrings) {
    switch (response.code) {
        case ResponseCode.Ok: {
            const {Toasts: {AddCommentToast: {Text, Title}}} = contentStrings;
            Toasts.success({text: Text, title: Title});
            break;
        }
        default: {
            Toasts.error({text: contentStrings.Errors.CommonError});
        }
    }
}

export const comment = {
    handleCreateComment
};