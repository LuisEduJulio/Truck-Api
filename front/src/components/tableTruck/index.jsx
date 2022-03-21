import { Table, Space } from 'antd';
import moment from 'moment';
import { useState } from 'react';
import { useHistory } from 'react-router-dom';

import { DeleteOutlined, EditOutlined } from '@ant-design/icons';

import { useDispatch } from 'react-redux';

import * as actions from '../../stores/configs/rootAction';
import ModalDelete from '../modalDelete';


function TableTruck({ data, loading }) {
    const dispatch = useDispatch();
    const history = useHistory();

    const [pagination, setPagination] = useState({
        current: data.current ? data.current : 0,
        pageSize: data.pageSize ? data.pageSize : 0,
        total: data.total ? data.total : 0
    });

    const [list, setList] = useState(data.truckEntities ?? []);
    const [modalDelete, setModalDelete] = useState(false);
    const [truck, setTruck] = useState({
        id: 0,
        page: 0
    });

    const handleSelectModel = (model) =>{
        if(model === 1){
            return 'FH'
        }else{
            return 'FM'
        }
    }

    const columns = [
        {
            title: 'Id',
            dataIndex: 'id',
            key: 'id',
            render: text => <a>{text}</a>,
        },
        {
            title: 'Data de fabricação',
            dataIndex: 'dateFabric',
            key: 'dateFabric',
            render: text => <a>{moment(text).format('DD/MM/YYYY')}</a>,
        },
        {
            title: 'Data do modelo',
            dataIndex: 'dateModel',
            key: 'dateModel',
            render: text => <a>{moment(text).format('DD/MM/YYYY')}</a>,
        },
        {
            title: 'Cor',
            dataIndex: 'color',
            key: 'color',
        },
        {
            title: 'Chassi',
            dataIndex: 'chassis',
            key: 'chassis',
        },
        {
            title: 'Modelo',
            dataIndex: 'eModelTruck',
            key: 'eModelTruck',
            render: text => <a>{handleSelectModel(text)}</a>,
        },
        {
            title: 'Editar',
            key: 'id',
            render: (text) => (
                <Space onClick={() => handleUpdatePage(text.id)}>
                    <a><EditOutlined /></a>
                </Space>
            ),
        },
        {
            title: 'Deletar',
            key: 'id',
            render: (text) => (
                <Space onClick={() => handleOpenDelete(text.id, data.page)}>
                    <a><DeleteOutlined /></a>
                </Space>
            ),
        }
    ];

    const handleTableChange = (pageSize) => {
        var count = 5;
        dispatch(actions.default.getAllTruck.getTruckAll(pageSize, count));
    };

    const handleUpdatePage = (id) => {
        history.push(`/updatetruck/${id}`);
    }

    const handleOpenDelete = (id, page) => {
        setModalDelete(true);
        setTruck({
            id: id,
            page: page
        });
    }

    const handleDelete = () => {
        setModalDelete(false);
        dispatch(actions.default.deleteTruckAction.deleteTruck(truck.id, truck.page));
    }

    const handleCancelDelete = () => {
        setModalDelete(false);
    }

    return (
        <div className='table-truck-container'>
            <Table
                columns={columns}
                dataSource={list}
                rowKey={record => record.id}
                pagination={pagination}
                loading={loading}
                onChange={(e) => handleTableChange(e.current)}
            />
            <ModalDelete
                showModal={modalDelete}
                textDescription={'Deseja apaga o caminhão?'}
                handleOk={() => handleDelete()}
                handleCancel={() => handleCancelDelete()}
            />
        </div>
    );
}

export default TableTruck;
