import { deleteTruckTypes } from './deleteTruck.actionsType';
import { getTruckAll } from '../getAllTruck/getAllTruck.actions';
import * as apiTruck from '../../../services/Api/apiTruck';

export function deleteTruck(id) {
    return function (dispatch) {
        dispatch(deleteTruckLoading());
        apiTruck
            .deleteTruck(id)
            .then((e) => {
                dispatch(getTruckAll(1, 5))
                dispatch(deleteTruckSuccess(
                    false,
                    'Sucesso',
                    true
                ));
            })
            .catch((e) => {               
                dispatch(deleteTruckError(
                    true,
                    'Erro ao deletar o caminhão',
                    false
                ))
            });
    };
}

function deleteTruckLoading() {
    return { type: deleteTruckTypes.DELETE_TRUCK_LOADING };
}

function deleteTruckSuccess(error, message, success, data) {
    return {
        type: deleteTruckTypes.DELETE_TRUCK_SUCCESS,
        error: error,
        message: message,
        success: success
    };
}

function deleteTruckError(error, message, success) {
    return {
        type: deleteTruckTypes.DELETE_TRUCK_ERROR,
        error: error,
        message: message,
        success: success,
    };
}