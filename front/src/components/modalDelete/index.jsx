import { Modal } from 'antd';

const ModalDelete = ({
    showModal,
    textDescription,
    handleOk,
    handleCancel
}) => {
    return (
        <>
            <Modal
                visible={showModal}
                onOk={handleOk}
                onCancel={handleCancel}
            >
                <p>{textDescription}</p>
            </Modal>
        </>
    );
};

export default ModalDelete;