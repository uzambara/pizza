import {useSelector} from "react-redux";
import {userSelectors} from "../redux/selectors";

export function useCurrentUser() {
    const currentUser = useSelector(userSelectors.selectCurrentUser);

    return {
        currentUser
    }
}