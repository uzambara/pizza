jest.mock("../pizza-button.scss", () => {
    return {
        button: "button",
        buttonAlert: "buttonAlert",
        buttonSubmit: "buttonSubmit",
        buttonSuccess: "buttonSuccess",
    }
});

import {PizzaButton} from "../../../index";
import {mount} from "enzyme";
import React from "react";
import {act} from "react-test-renderer";

describe("pizza button tests", () => {
    const onClickMock = jest.fn();
    beforeEach(() => {
        jest.clearAllMocks();
    });

    it("should call onClick handler, if button click", () => {
        // Act
        const component = mount(<PizzaButton onClick={onClickMock} style="submit"/>);
        act(() => {
            const buttonElement = component.find("button");
            buttonElement.simulate("click");
        });

        // Assert
        expect(onClickMock).toHaveBeenCalled();
    });


    it.each([
        ["submit", "buttonSubmit"],
        ["alert", "buttonAlert"],
        ["success", "buttonSuccess"],
    ])("should have right class name, according to given type prop", (style: any, className) => {
        // Act
        const component = mount(<PizzaButton onClick={onClickMock} style={style}/>);

        // Assert
        const buttonElement = component.find("button");
        expect(buttonElement.hasClass(className)).toBe(true);
    });

    it("should render button with submit type if prop is submit", () => {
        // Act
        const component = mount(<PizzaButton onClick={onClickMock} style="submit" type="submit"/>);

        // Assert
        const buttonElement = component.find("button");
        expect(buttonElement.props().type).toBe("submit");
    });

    it("should render button with reset type if prop is reset", () => {
        // Act
        const component = mount(<PizzaButton onClick={onClickMock} style="submit" type="reset"/>);

        // Assert
        const buttonElement = component.find("button");
        expect(buttonElement.props().type).toBe("reset");
    });

    it("should render button with button type if prop is undefined", () => {
        // Act
        const component = mount(<PizzaButton onClick={onClickMock} style="submit"/>);

        // Assert
        const buttonElement = component.find("button");
        expect(buttonElement.props().type).toBe("button");
    });
});