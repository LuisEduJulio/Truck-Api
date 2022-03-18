import { deleteTruckTypes } from './deleteTruck.actionsType';

const initialState = {
    error: false,
    message: '',
    success: false,
    loading: false
};

// eslint-disable-next-line import/no-anonymous-default-export
export default function (state = initialState, action) {
    switch (action.type) {
        case deleteTruckTypes.DELETE_TRUCK_LOADING:
            return {
                ...state,
                loading: !action.loading
            };
        case deleteTruckTypes.DELETE_TRUCK_SUCCESS:
            return {
                ...state,
                loading: initialState.loading,
                error: action.error,
                success: action.success,
                message: action.message
            };
        case deleteTruckTypes.DELETE_TRUCK_ERROR:
            return {
                ...state,
                error: action.error,
                loading: initialState.loading,
                success: action.success,
                message: action.message
            };
        default:
            return state;
    }
}
