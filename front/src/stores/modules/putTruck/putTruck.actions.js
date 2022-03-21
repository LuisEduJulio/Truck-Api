import { putTruckTypes } from './putTruck.actionsType';
import * as apiTruck from '../../../services/Api/apiTruck';

export function putTruck(object) {
    return function (dispatch) {
        dispatch(PutTruckLoading());
        apiTruck
            .putTruck(object)
            .then((e) => {
                dispatch(PutTruckSuccess(
                    false,
                    'Sucesso',
                    true
                ));
            })
            .catch((e) => {
                dispatch(PutTruckError(
                    true,
                    'Erro ao cadastra o caminhão!',
                    false
                ))
            });
    };
}

function PutTruckLoading() {
    return { type: putTruckTypes.TRUCK_PUT_LOADING };
}

function PutTruckSuccess(error, message, success, object) {
    return {
        type: putTruckTypes.TRUCK_PUT_SUCCESS,
        error: error,
        message: message,
        success: success,
        object: object
    };
}

function PutTruckError(error, message, success) {
    return {
        type: putTruckTypes.TRUCK_PUT_ERROR,
        error: error,
        message: message,
        success: success,
    };
}