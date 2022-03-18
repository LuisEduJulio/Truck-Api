import { useState } from 'react';

import DrawerModal from "../../components/drawerModal";
import FormPostTruck from "../../components/formPostTruck";

function Modals() {
    const [open, setOpen] = useState(true);

    return (
        <>
            <DrawerModal open={open} props={<FormPostTruck />} title={'Novo Caminhão'} />
        </>
    );
}

export default Modals;
