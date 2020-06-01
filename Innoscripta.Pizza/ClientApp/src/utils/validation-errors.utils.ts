import {ValidationResult} from "lakmus/src/results/validation-result";
import {Toasts} from "../components";

function handleValidationErrors(validationResult: ValidationResult) {
    const {errors} = validationResult;

    errors.forEach(error => {
        Toasts.error({text: error.errorMessage});
    });
}

export const validationErrorsUtils = {
    handleValidationErrors
};
