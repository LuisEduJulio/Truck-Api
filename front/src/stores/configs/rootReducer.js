import { combineReducers } from 'redux';

// import authReducer from './authenticator/authenticator.reducer';

const appReducer = combineReducers({
  // authenticator: authReducer
});

const rootReducer = (state, action) => {
  return appReducer(state, action);
};

export default rootReducer;
