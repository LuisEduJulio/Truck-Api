import { useState } from 'react';
import { useDispatch, useSelector } from 'react-redux';

import DrawerModal from "../../components/drawerModal";
import FormPostTruck from "../../components/formPostTruck";

import * as actions from '../../stores/configs/rootAction';

function Modals() {
    const dispatch = useDispatch();

    const modalNewTruck = useSelector(state => state.modal?.modalNewTruck);

    const [truck, setTruck] = useState({});

    const handleChange = (key, value) => {
        setTruck({
            ...truck,
            [key]: value
        });
    };

    const submit = () => {
        dispatch(actions.default.postTruck.postTruck(truck));
    }

    const onClearChange = () => {
        setTruck({});
        dispatch(actions.default.modal.closeModalNewTruck());
    };

    return (
        <>
            <DrawerModal
                open={modalNewTruck}
                props={
                    <FormPostTruck
                        truck={truck}
                        handleChange={handleChange}
                        onSubmit={submit}
                        onClearChange={onClearChange}
                    />}
                title={'Novo Caminhão'}
            />
        </>
    );
}

export default Modals;
