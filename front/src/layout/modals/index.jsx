import { useSelector } from 'react-redux';

import DrawerModal from "../../components/drawerModal";
import FormPostTruck from "../../components/formPostTruck";

function Modals() {
    const modalNewTruck = useSelector(state => state.modal?.modalNewTruck);

    return (
        <>
            <DrawerModal
                open={modalNewTruck}
                props={<FormPostTruck />}
                title={'Novo Caminhão'}
            />
        </>
    );
}

export default Modals;
