import {Validator} from "lakmus";
import {IComment} from "../models";
import {IContentStrings} from "../content-strings";

export class CommentValidator extends Validator<IComment> {
    constructor(contentString: IContentStrings) {
        super();

        const {
            CommentText,
            Name,
            Phone
        } = contentString.Errors.Validation;
        this.ruleFor(obj => obj.text)
            .notEmpty()
            .withMessage(CommentText);
        this.ruleFor(obj => obj.name)
            .notEmpty()
            .withMessage(Name);
        this.ruleFor(obj => obj.phone)
            .notEmpty()
            .withMessage(Phone);
    }
}