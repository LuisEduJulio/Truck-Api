import { truckGetAllTypes } from './getAllTruck.actionsType';
import * as apiTruck from '../../../services/Api/apiTruck';

export function getTruckAll(page, count) {
    return function (dispatch) {
        dispatch(GetTruckAllLoading());
        apiTruck
            .getTruckAll(page, count)
            .then((e) => {
                dispatch(GetTruckAllSuccess(
                    false,
                    'Sucesso',
                    true,
                    e.data
                ));
            })
            .catch((e) => {
                dispatch(GetTruckAllError(
                    true,
                    'Erro na consulta de caminhões',
                    false
                ))
            });
    };
}

function GetTruckAllLoading() {
    return { type: truckGetAllTypes.TRUCK_GET_ALL_SUCCESS };
}

function GetTruckAllSuccess(error, message, success, data) {
    return {
        type: truckGetAllTypes.TRUCK_GET_ALL_SUCCESS,
        error: error,
        message: message,
        success: success,
        data: data
    };
}

function GetTruckAllError(error, message, success) {
    return {
        type: truckGetAllTypes.TRUCK_GET_ALL_ERROR,
        error: error,
        message: message,
        success: success,
    };
}