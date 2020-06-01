import {Validator} from "lakmus";
import {ILoginFormData} from "../models";
import {IContentStrings} from "../content-strings";

export class LoginValidator extends Validator<ILoginFormData> {
    constructor(contentStrings: IContentStrings) {
        super();

        const {Phone, Password} = contentStrings.Errors.Validation
        this.ruleFor(obj => obj.password).notEmpty().withMessage(Password);
        this.ruleFor(obj => obj.phone).notEmpty().withMessage(Phone);
    }
}