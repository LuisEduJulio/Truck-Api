import { Table, Tag, Space } from 'antd';

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
    },
    {
        title: 'Data do modelo',
        dataIndex: 'dateModel',
        key: 'dateModel',
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
        title: 'Action',
        key: 'action',
        render: (text, record) => (
            <Space size="middle">
                <a>Editar</a>
                <a>Deletar</a>
            </Space>
        ),
    },
];

const data = [
    {
        id: '1',
        dateFabric: 'John Brown',
        dateModel: 32,
        color: 'New York No. 1 Lake Park',
        chassis: ['nice', 'developer'],
    },
    {
        id: '2',
        dateFabric: 'Jim Green',
        dateModel: 42,
        color: 'London No. 1 Lake Park',
        chassis: ['loser'],
    },
    {
        id: '3',
        dateFabric: 'Joe Black',
        dateModel: 32,
        color: 'Sidney No. 1 Lake Park',
        chassis: ['cool', 'teacher'],
    },
];

function TableTruck() {
    return (
        <>
            <Table columns={columns} dataSource={data} />
        </>
    );
}

export default TableTruck;
