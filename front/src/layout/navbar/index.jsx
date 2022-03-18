import { useState } from 'react';

import { Menu } from 'antd';
import { HomeOutlined, FileAddOutlined } from '@ant-design/icons';

const { SubMenu } = Menu;

function Navbar() {
    const [current, setCurrent] = useState('mail');

    const handleClick = e => {
        setCurrent(e.key);
    };
    return (
        <Menu onClick={handleClick} selectedKeys={[current]} mode="horizontal">
            <Menu.Item key="mail" icon={<HomeOutlined />}>
                Home
            </Menu.Item>
            <Menu.Item key="truck" icon={<FileAddOutlined />}>
                Novo Caminhão
            </Menu.Item>
        </Menu>
    );
}

export default Navbar;
