import { truckGetAllTypes } from './getAllTruck.actionsType';

const initialState = {
    error: false,
    message: '',
    success: false,
    loading: false,
    data: []
};

// eslint-disable-next-line import/no-anonymous-default-export
export default function (state = initialState, action) {
    switch (action.type) {
        case truckGetAllTypes.TRUCK_GET_ALL_LOADING:
            return {
                ...state,
                loading: !action.loading
            };
        case truckGetAllTypes.TRUCK_GET_ALL_SUCCESS:
            return {
                ...state,
                loading: initialState.loading,
                error: action.error,
                success: action.success,
                message: action.message,
                data: action.data
            };
        case truckGetAllTypes.TRUCK_GET_ALL_ERROR:
            return {
                ...state,
                error: action.error,
                loading: initialState.loading,
                success: action.success,
                message: action.message,
                data: initialState.data
            };
        default:
            return state;
    }
}
