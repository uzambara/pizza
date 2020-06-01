import {ICreateCommentRequest, ICreateCommentResponse} from "../contratcs/comment";
import {IComment} from "../models";
import {fetchUtil} from "../utils";
import {ApiRouting} from "../routing";
import {IGetCommentsResponse} from "../contratcs/comment/get-somments-response";
import {IGetCommentsRequest} from "../contratcs/comment/get-comments-request";
import {IGetPartialDataRequest} from "../contratcs/shared";

export class CommentService {
    public static CreateComment(comment: IComment): Promise<ICreateCommentResponse> {
        const request: ICreateCommentRequest = {
            ...comment
        };
        return fetchUtil.post<ICreateCommentResponse>(ApiRouting.Comment.create, request);
    }

    public static GetComments(request: IGetPartialDataRequest): Promise<IGetCommentsResponse> {
        return fetchUtil.get<IGetCommentsResponse>(ApiRouting.Comment.get, request);
    }
}