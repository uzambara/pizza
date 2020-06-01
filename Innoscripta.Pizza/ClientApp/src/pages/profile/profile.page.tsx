import {withPageWrapper} from "../../hocs";
import React, {useEffect} from "react";
import {PizzaOrderHistory, PizzaUnauthorizedMsg} from "../../components";
import {PizzaUserStatistic} from "../../components";
import {useDispatch, useSelector} from "react-redux";
import {userSelectors} from "../../redux/selectors";
import {userActions} from "../../redux/actions";
import * as styles from "./profile.page.scss";

function ProfilePageComponent(props) {
    const dispatch = useDispatch();
    const {statistic, currentUser, orderHistory} = useSelector(userSelectors.selectUserState);

    useEffect(() => {
        dispatch(userActions.getOrderHistoryRemote());
        dispatch(userActions.getStatisticRemote());
    }, []);
    if(!currentUser)
        return <PizzaUnauthorizedMsg/>;
    return <>
        {statistic && <PizzaUserStatistic
            userStatistic={statistic}
            user={currentUser}
            className={styles.statistics}
        />}
        {orderHistory && <PizzaOrderHistory orders={orderHistory}/>}
    </>
}

export const ProfilePage = withPageWrapper(ProfilePageComponent);
