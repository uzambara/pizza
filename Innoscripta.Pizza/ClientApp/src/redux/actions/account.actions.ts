import {Dispatch} from "redux";
import {ILoginFormData, IRegistrationFormData} from "../../models";
import {AccountService} from "../../services";
import {responseHandleUtils, validationErrorsUtils} from "../../utils";
import {IGlobalState} from "../reducers";
import {languageSelectors} from "../selectors";
import {ResponseCode} from "../../contratcs";
import {userActions} from "./index";
import {LoginValidator} from "../../validators";
import {RegistrationValidator} from "../../validators";


const tryAuthenticate = () => async (dispatch: Dispatch) => {
    const response = await AccountService.getCurrentUser();
    dispatch(userActions.setUser(response.user));
};

const loginRemote = (formData: ILoginFormData, closeForm: () => void) => async (dispatch: Dispatch, getState: () => IGlobalState) => {
    const validationResult = new LoginValidator(getState().language.contentStrings).validate(formData);
    if(!validationResult.isValid) {
        validationErrorsUtils.handleValidationErrors(validationResult);
        return;
    }

    const response = await AccountService.login({phone: formData.phone, password: formData.password});
    if(response.code == ResponseCode.Ok) {
        dispatch(userActions.setUser(response.user));
        closeForm();
    }

    const contentString = languageSelectors.selectContentStrings(getState());
    responseHandleUtils.account.handleLogin(response, contentString);
};

const logoutRemote = () => async (dispatch: Dispatch, getState: () => IGlobalState) => {
    const response = await AccountService.logout();
    if(response.code == ResponseCode.Ok) {
        dispatch(userActions.setUser(null));
    }
    const contentString = languageSelectors.selectContentStrings(getState());
    responseHandleUtils.account.handleLogout(response, contentString);

};

const registerRemote = (formData: IRegistrationFormData, closeForm: () => void) => async (dispatch: Dispatch, getState: () => IGlobalState) => {
    const validationResult = new RegistrationValidator(getState().language.contentStrings).validate(formData);
    if(!validationResult.isValid) {
        validationErrorsUtils.handleValidationErrors(validationResult);
        return;
    }

    const response = await AccountService.register({
        ...formData
    });
    if(response.code == ResponseCode.Ok) {
        dispatch(userActions.setUser(response.user));
        closeForm();
    }
    const contentString = languageSelectors.selectContentStrings(getState());
    responseHandleUtils.account.handleRegister(response, contentString);
};

export const accountActions = {
    loginRemote,
    logoutRemote,
    registerRemote,
    tryAuthenticate,
};