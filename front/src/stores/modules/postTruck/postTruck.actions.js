import { userTypes } from './user.actionsType';
import * as userApi from '../../apis/userApi';
import {
    USER_SUCCESS_REDUCER,
    USER_ERROR_REDUCER
} from '../../util/messageReducer';
import { Logout } from '../authenticator/authenticator.actions';

export function user() {
    return function (dispatch) {
        dispatch(UserLoading());

        userApi
            .getUser()
            .then((e) => {
                dispatch(UserSuccess(
                    USER_SUCCESS_REDUCER.ERROR,
                    USER_SUCCESS_REDUCER.MESSAGE,
                    USER_SUCCESS_REDUCER.SUCCESS,
                    e.user
                ));
            })
            .catch((e) => {
                if (e.message.includes('401')) return dispatch(Logout());

                dispatch(UserError(
                    USER_ERROR_REDUCER.ERROR,
                    USER_ERROR_REDUCER.MESSAGE,
                    USER_ERROR_REDUCER.SUCCESS
                ))
            });
    };
}

export function UserLoading() {
    return { type: userTypes.USER_LOADING };
}

export function UserError(error, message, success) {
    return {
        type: userTypes.USER_ERROR,
        error: error,
        message: message,
        success: success,
    };
}

export function UserSuccess(error, message, success, user) {
    return {
        type: userTypes.USER_SUCCESS,
        error: error,
        message: message,
        success: success,
        user: user
    };
}