import React from "react";
jest.spyOn(React , "useRef").mockImplementation(() => {
    return {
        current: {}
    }
});

import {act, renderHook} from "@testing-library/react-hooks";
import {useScrollToBottomTracking} from "../index";
import {commonUtils} from "../../utils";
import {testUtils} from "../../testing";


describe("use scroll to bottom tracking tests", () => {
    const onScrolledToBottomMock = jest.fn();

    beforeEach(() => {
        jest.clearAllMocks();
    });

    it("should call onScrollToBottom handler once after 300ms, if it is element bottom", async () => {
        // Arrange
        const {result} = renderHook(() => useScrollToBottomTracking(onScrolledToBottomMock));
        commonUtils.isElementBottom = jest.fn((el) => true);

        // Act
        act(() => {
            const event = new Event("scroll");
            document.dispatchEvent(event);
            document.dispatchEvent(event);
            document.dispatchEvent(event);
        });

        await testUtils.delay(300);

        // Assert
        expect(onScrolledToBottomMock).toHaveBeenCalledTimes(1);
    });

    it("should not call onScrollToBottom handler after 300ms, if it is not element bottom", async () => {
        // Arrange
        const {result} = renderHook(() => useScrollToBottomTracking(onScrolledToBottomMock));
        commonUtils.isElementBottom = jest.fn((el) => false);

        // Act
        act(() => {
            const event = new Event("scroll");
            document.dispatchEvent(event);
            document.dispatchEvent(event);
            document.dispatchEvent(event);
        });

        await testUtils.delay(300);

        // Assert
        expect(onScrolledToBottomMock).not.toHaveBeenCalled();
    });
});