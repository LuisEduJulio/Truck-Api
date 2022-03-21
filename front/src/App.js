import { BrowserRouter } from "react-router-dom";
import { Provider } from 'react-redux';
import { PersistGate } from 'redux-persist/es/integration/react';

import Routes from "./routes";
import { persister, store } from './stores';

import './App.css';

function App() {
  return (
    <Provider store={store}>
      <PersistGate persistor={persister}>
        <BrowserRouter>
          <Routes />
        </BrowserRouter>
      </PersistGate>
    </Provider>
  );
}

export default App;
