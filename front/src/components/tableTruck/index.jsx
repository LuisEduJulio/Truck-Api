import { Table, Space } from 'antd';
import moment from 'moment';
import { useState } from 'react';
import { useHistory } from 'react-router-dom';

import { DeleteOutlined, EditOutlined } from '@ant-design/icons';

import { useDispatch } from 'react-redux';

import * as actions from '../../stores/configs/rootAction';


function TableTruck({ data }) {
    const dispatch = useDispatch();
    const history = useHistory();

    const [pagination, setPagination] = useState({
        current: data.page ?? 0,
        pageSize: data.count ?? 0,
        total: data.total ?? 0
    });
    const [loading, setLoading] = useState(false);
    const [list, setList] = useState(data.truckEntities ?? []);

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
                <Space onClick={() => handleDelete(text.id)}>
                    <a><DeleteOutlined /></a>
                </Space>
            ),
        }
    ];

    const handleTableChange = (current, pageSize) => {
        var page = pageSize + 1;
        var count = current + 1;
        dispatch(actions.default.getAllTruck.getTruckAll(page, count));
    };

    const handleUpdatePage = (id) => {
        history.push(`/updatetruck/${id}`);
    }

    const handleDelete = (id) => {
        dispatch(actions.default.deleteTruckAction.deleteTruck(id));
    }

    return list ? (
        <div className='table-truck-container'>
            <Table
                columns={columns}
                dataSource={list}
                rowKey={record => record.id}
                pagination={pagination}
                loading={loading}
            // onChange={() => handleTableChange(pagination.current, pagination.pageSize)}
            />
        </div>
    ) : null;
}

export default TableTruck;
