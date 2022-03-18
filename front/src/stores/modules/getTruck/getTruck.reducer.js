import { userTypes } from './user.actionsType';

const initialState = {
    error: false,
    message: '',
    success: false,
    loading: false,
    user: {}
};

// eslint-disable-next-line import/no-anonymous-default-export
export default function (state = initialState, action) {
    switch (action.type) {
        case userTypes.USER_LOADING:
            return {
                ...state,
                loading: !action.loading
            };
        case userTypes.USER_SUCCESS:
            return {
                ...state,
                loading: initialState.loading,
                error: action.error,
                success: action.success,
                message: action.message,
                user: action.user
            };
        case userTypes.USER_ERROR:
            return {
                ...state,
                error: action.error,
                loading: initialState.loading,
                success: action.success,
                message: action.message,
                user: initialState.user
            };
        default:
            return state;
    }
}
