import { modalTypes } from './modal.actionsType';

const initialState = {
    modalNewTruck: false
};

// eslint-disable-next-line import/no-anonymous-default-export
export default function (state = initialState, action) {
    switch (action.type) {
        case modalTypes.MODAL_NEW_TRUCK_OPEN:
            return {
                ...state,
                modalNewTruck: !initialState.modalNewTruck
            };
        case modalTypes.MODAL_NEW_TRUCK_CLOSE:
            return {
                ...state,
                modalNewTruck: initialState.modalNewTruck
            };
        default:
            return state;
    }
}
