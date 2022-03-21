import { truckGetTypes } from './getTruck.actionsType';
import * as apiTruck from '../../../services/Api/apiTruck';

export function getTruckId(id) {
    return function (dispatch) {
        dispatch(GetTruckLoading());
        apiTruck
            .getTruckId(id)
            .then((e) => {
                dispatch(GetTruckSuccess(
                    false,
                    'Sucesso',
                    true,
                    e
                ));
            })
            .catch((e) => {
                dispatch(GetTruckError(
                    true,
                    'Erro na consulta do caminhão!',
                    false
                ))
            });
    };
}

function GetTruckLoading() {
    return { type: truckGetTypes.TRUCK_GET_LOADING };
}

function GetTruckSuccess(error, message, success, object) {
    return {
        type: truckGetTypes.TRUCK_GET_SUCCESS,
        error: error,
        message: message,
        success: success,
        object: object
    };
}

function GetTruckError(error, message, success) {
    return {
        type: truckGetTypes.TRUCK_GET_ERROR,
        error: error,
        message: message,
        success: success,
    };
}