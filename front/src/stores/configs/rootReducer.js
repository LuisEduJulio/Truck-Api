import { combineReducers } from 'redux';

import getAllTruckReducer from '../modules/getAllTruck/getAllTruck.reducer';
import deleteTruckReducer from '../modules/deleteTruck/deleteTruck.reducer';
import modalReducer from '../modules/modal/modal.reducer';

const appReducer = combineReducers({
  getAllTruck: getAllTruckReducer,
  deleteTruck: deleteTruckReducer,
  modal: modalReducer
});

const rootReducer = (state, action) => {
  return appReducer(state, action);
};

export default rootReducer;
