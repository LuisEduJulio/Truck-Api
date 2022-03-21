import { postTruckTypes } from './postTruck.actionsType';
import * as apiTruck from '../../../services/Api/apiTruck';
import { closeModalNewTruck } from '../modal/modal.actions';

export function postTruck(object) {
    return function (dispatch) {
        dispatch(PostTruckLoading());
        apiTruck
            .postTruck(object)
            .then((e) => {
                dispatch(closeModalNewTruck());
                dispatch(PostTruckSuccess(
                    false,
                    'Sucesso',
                    true
                ));
            })
            .catch((e) => {
                dispatch(PostTruckError(
                    true,
                    'Erro ao cadastra o caminhão!',
                    false
                ))
            });
    };
}

function PostTruckLoading() {
    return { type: postTruckTypes.TRUCK_POST_LOADING };
}

function PostTruckSuccess(error, message, success, object) {
    return {
        type: postTruckTypes.TRUCK_POST_SUCCESS,
        error: error,
        message: message,
        success: success,
        object: object
    };
}

function PostTruckError(error, message, success) {
    return {
        type: postTruckTypes.TRUCK_POST_ERROR,
        error: error,
        message: message,
        success: success,
    };
}