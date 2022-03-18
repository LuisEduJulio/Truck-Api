import * as modalAction from '../modules/modal/modal.actions';
import * as getAllTruckAction from '../modules/getAllTruck/getAllTruck.actions';
import * as deleteTruckAction from '../modules/deleteTruck/deleteTruck.actions';

const rootAction = {
  getAllTruck: getAllTruckAction,
  deleteTruckAction: deleteTruckAction,
  modal: modalAction
};

export default rootAction;
