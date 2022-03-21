import * as modalAction from '../modules/modal/modal.actions';
import * as getTruckAction from '../modules/getTruck/getTruck.actions';
import * as getAllTruckAction from '../modules/getAllTruck/getAllTruck.actions';
import * as postTruckAction from '../modules/postTruck/postTruck.actions';
import * as putTruckAction from '../modules/putTruck/putTruck.actions';
import * as deleteTruckAction from '../modules/deleteTruck/deleteTruck.actions';

const rootAction = {
  getTruck: getTruckAction,
  getAllTruck: getAllTruckAction,
  postTruck: postTruckAction,
  putTruck: putTruckAction,
  deleteTruckAction: deleteTruckAction,
  modal: modalAction
};

export default rootAction;
