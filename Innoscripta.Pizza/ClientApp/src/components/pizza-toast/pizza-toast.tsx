import React from "react";
import {toast, ToastContent, ToastOptions} from "react-toastify";
import cn from "classnames";
import "./pizza-toast.scss";

export interface IPizzaToastSettings {
    text: string
    title?: string
}

enum ToastType {
    Success,
    Error,
    Info
}

function error(props: IPizzaToastSettings) {
    showToast(props, toast.error, ToastType.Error);
}

function success(props: IPizzaToastSettings) {
    showToast(props, toast.success, ToastType.Success);
}

function info(props: IPizzaToastSettings) {
    showToast(props, toast.info, ToastType.Info);
}

function showToast(props: IPizzaToastSettings, toastMethod: (content: ToastContent, options?: ToastOptions) => void, type: ToastType) {

    toastMethod(({closeToast}) => <PizzaToast {...props} closeToast={closeToast} toastType={type}/>, {
        className: "toast-wrapper"
    });
}


function getToastClassName(toastType: ToastType) {
    switch (toastType) {
        case ToastType.Error:
            return "error";
        case ToastType.Success:
            return "success";
        case ToastType.Info:
            return "info";
        default:
            return "info";
    }
}

interface IToastProps extends IPizzaToastSettings {
    closeToast: () => void
    toastType: ToastType
}

export function PizzaToast(props: IToastProps) {
    const {text, title, toastType, closeToast} = props;
    return <div className={cn("pizza-toast", getToastClassName(toastType))}>
        <h3 className="title">{title}</h3>
        <p className="text">{text}</p>
    </div>
}

export const Toasts = {
    error,
    success,
    info
};