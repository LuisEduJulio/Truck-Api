import { combineReducers } from 'redux';

import getAllTruckReducer from '../modules/getAllTruck/getAllTruck.reducer';
import getTruckReducer from '../modules/getTruck/getTruck.reducer';
import postTruckReducer from '../modules/postTruck/postTruck.reducer';
import putTruckReducer from '../modules/putTruck/putTruck.reducer';
import deleteTruckReducer from '../modules/deleteTruck/deleteTruck.reducer';
import modalReducer from '../modules/modal/modal.reducer';

const appReducer = combineReducers({
  getTruck: getTruckReducer,
  getAllTruck: getAllTruckReducer,
  postTruck: postTruckReducer,
  putTruck: putTruckReducer,
  deleteTruck: deleteTruckReducer,
  modal: modalReducer
});

const rootReducer = (state, action) => {
  return appReducer(state, action);
};

export default rootReducer;
