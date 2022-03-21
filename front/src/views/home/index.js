import { useEffect, useState } from "react";
import { useDispatch, useSelector } from "react-redux";

import * as actions from '../../stores/configs/rootAction';

import TableTruck from "../../components/tableTruck";

function Home() {
    const dispatch = useDispatch();

    const data = useSelector(state => state.getAllTruck?.data);
    const loading = useSelector(state => state.getAllTruck?.loading);

    useEffect(() => {
        dispatch(actions.default.getAllTruck.getTruckAll(1, 5));
    }, []);

    return (
        <>
            {loading ?
                null :
                (data ? <TableTruck data={data} loading={loading} /> : null)}
        </>
    );
}

export default Home;
