import { useState } from 'react';
import { useDispatch } from "react-redux";

import { Menu } from 'antd';
import { HomeOutlined, FileAddOutlined } from '@ant-design/icons';

import * as actions from '../../stores/configs/rootAction';
import { useHistory } from 'react-router-dom';

function Navbar() {
    const dispatch = useDispatch();
    const history = useHistory();

    const [current, setCurrent] = useState('home');

    const handleClick = e => {
        setCurrent(e.key);
    };

    const handleNewTruck = () => {
        dispatch(actions.default.modal.openModalNewTruck());
    }

    const handleNavigationMenu = () => {
        history.push('/')
    }

    return (
        <Menu
            onClick={handleClick}
            selectedKeys={[current]}
            mode="horizontal"
        >
            <Menu.Item
                key="home"
                icon={<HomeOutlined />}
                onClick={() => handleNavigationMenu()}
            >
                Home
            </Menu.Item>
            <Menu.Item
                key="truck"
                icon={<FileAddOutlined />}
                onClick={() => handleNewTruck()}
            >
                Novo Caminhão
            </Menu.Item>
        </Menu>
    );
}

export default Navbar;
