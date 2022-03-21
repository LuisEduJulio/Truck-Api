import { useEffect, useState } from "react";
import { useParams } from "react-router-dom";
import { useDispatch, useSelector } from "react-redux";

import * as actions from '../../stores/configs/rootAction';
import FormPutTruck from "../../components/formPutTruck";
import DrawerModal from "../../components/drawerModal";
import { useHistory } from "react-router-dom";

function UpdateTruck() {
    const dispatch = useDispatch();
    const history = useHistory();

    const { id } = useParams();

    const object = useSelector(state => state.getTruck?.object);
    const loading = useSelector(state => state.getTruck?.loading);

    const [truck, setTruck] = useState({
        chassis: object?.chassis,
        color: object?.color,
        dateFabric: object?.dateFabric,
        dateModel: object?.dateModel,
        id: object?.id
    });

    const handleChange = (key, value) => {
        setTruck({
            ...truck,
            [key]: value
        });
    };

    const submit = () => {
        dispatch(actions.default.putTruck.putTruck(truck));
    }

    const handleUpdateSetTruck = () => {
        setTruck({
            chassis: object?.chassis,
            color: object?.color,
            dateFabric: object?.dateFabric,
            dateModel: object?.dateModel,
            id: object?.id
        });
    }

    const handleClearSetTruck = () => {
        setTruck({});
        history.push('/');
    }

    useEffect(() => {
        dispatch(actions.default.getTruck.getTruckId(id));
        handleUpdateSetTruck();
    }, []);

    return (
        <>
            <DrawerModal
                open={loading}
            />
            {truck ?
                <FormPutTruck
                    handleChange={handleChange}
                    onSubmit={submit}
                    truck={truck}
                    handleCancel={handleClearSetTruck}
                />
                : null}
        </>
    );
}

export default UpdateTruck;
