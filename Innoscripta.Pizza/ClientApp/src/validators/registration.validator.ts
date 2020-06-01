import {Validator} from "lakmus";
import {IRegistrationFormData} from "../models";
import {IContentStrings} from "../content-strings";

export class RegistrationValidator extends Validator<IRegistrationFormData> {
    constructor(contentStrings: IContentStrings) {
        super();

        const {Phone, Password, PasswordEquality, Name} = contentStrings.Errors.Validation;
        this.ruleFor(obj => obj.password).notEmpty().withMessage(Password);
        this.ruleFor(obj => obj.confirmPassword).notEmpty().withMessage(Password);
        this.ruleFor(obj => obj.password)
            .must((prop, instance) => prop === instance.confirmPassword)
            .withMessage(PasswordEquality);
        this.ruleFor(obj => obj.phone).notEmpty().withMessage(Phone);
        this.ruleFor(obj => obj.name).notEmpty().withMessage(Name);
    }
}