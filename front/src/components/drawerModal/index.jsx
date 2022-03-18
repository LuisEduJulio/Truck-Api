import { Drawer } from 'antd';

function DrawerModal({ props, open, title }) {
    return (
        <Drawer
            title={title}
            width={500}
            closable={false}
            // onClose={this.onChildrenDrawerClose}
            visible={open}
        >
            {props}
        </Drawer>
    );
}

export default DrawerModal;
