import { modalTypes } from './modal.actionsType';

export function openModalNewTruck() {
    return { type: modalTypes.MODAL_NEW_TRUCK_OPEN };
}

export function closeModalNewTruck() {
    return { type: modalTypes.MODAL_NEW_TRUCK_CLOSE };
}
