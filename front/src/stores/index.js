import { createStore, applyMiddleware, compose } from 'redux';
import { persistStore } from 'redux-persist';
import thunk from 'redux-thunk';
import rootReducer from './configs/rootReducer';
import persistReducers from './configs/persistReducers';

const store = createStore(
    persistReducers(rootReducer),
    compose(applyMiddleware(thunk))
);

const persister = persistStore(store);

export { store, persister };
