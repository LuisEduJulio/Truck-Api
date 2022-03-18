import axios from './axios';

export async function getTruckId(id) {
  try {
    const { data } = await axios.get(`/Truck/GetById/${id}`);

    return data;
  } catch (error) {
    return error;
  }
}

export async function getTruckAll(page, count) {
  try {
    const data = await axios.get(`/Truck/GetAll/${page}/${count}`);
    return data;
  } catch (error) {
    return error;
  }
}

export async function postTruck(object) {
  try {
    const data = await axios.post(`/Truck/CreateTruck`,
      {
        dateCreation: object.dateCreation,
        dateFabric: object.dateFabric,
        dateModel: object.dateModel,
        color: object.color,
        chassis: object.chassis,
        eModelTruck: object.eModelTruck
      });

    return data;
  } catch (error) {
    return error;
  }
}

export async function putTruck(object) {
  try {
    const data = await axios.put(`/Truck//Truck/UpdateTruck`,
      {
        id: object.id,
        dateCreation: object.dateCreation,
        dateFabric: object.dateFabric,
        dateModel: object.dateModel,
        color: object.color,
        chassis: object.chassis,
        eModelTruck: object.eModelTruck
      });

    return data;
  } catch (error) {
    return error;
  }
}

export async function deleteTruck(id) {
  try {
    const { data } = await axios.delete(`/Truck/DeleteTruck/${id}`);
    
    return data;
  } catch (error) {
    return error;
  }
}