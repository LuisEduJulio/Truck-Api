import { truckGetTypes } from './getTruck.actionsType';

const initialState = {
    error: false,
    message: '',
    success: false,
    loading: false,
    object: {}
};

// eslint-disable-next-line import/no-anonymous-default-export
export default function (state = initialState, action) {
    switch (action.type) {
        case truckGetTypes.TRUCK_GET_LOADING:
            return {
                ...state,
                loading: !action.loading
            };
        case truckGetTypes.TRUCK_GET_SUCCESS:
            return {
                ...state,
                loading: initialState.loading,
                error: action.error,
                success: action.success,
                message: action.message,
                object: action.object
            };
        case truckGetTypes.TRUCK_GET_ERROR:
            return {
                ...state,
                error: action.error,
                loading: initialState.loading,
                success: action.success,
                message: action.message,
                object: initialState.object
            };
        default:
            return state;
    }
}
