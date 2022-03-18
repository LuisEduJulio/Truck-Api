import axios from 'axios';

export const base_url = 'https://localhost:5001/';

axios.defaults.baseURL = base_url;
axios.defaults.timeout = 10000;
axios.defaults.headers = {
  'Content-Type': 'application/json',
  Accept: 'application/json',
};

export default axios;
