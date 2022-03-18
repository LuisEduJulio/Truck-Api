import React, { useState } from 'react';
import {
    Form,
    Input,
    Button,
    Radio,
    Select,
    Cascader,
    DatePicker,
    InputNumber,
    TreeSelect,
    Switch,
} from 'antd';
import { useDispatch } from "react-redux";

import * as actions from '../../stores/configs/rootAction';

function FormPostTruck() {
    const dispatch = useDispatch();
    const [componentSize, setComponentSize] = useState('default');

    const onFormLayoutChange = (size) => {
        setComponentSize(size);
    };

    const onClearChange = () => {
        dispatch(actions.default.modal.closeModalNewTruck());
    };

    return (
        <Form
            labelCol={{ span: 4 }}
            wrapperCol={{ span: 14 }}
            layout="horizontal"
            initialValues={componentSize}
            onValuesChange={onFormLayoutChange}
            size={componentSize}
        >
            <Form.Item label="Descrição">
                <Input />
            </Form.Item>
            <Form.Item label="Data de Fabricação">
                <Input />
            </Form.Item>
            <Form.Item label="Data do Modelo">
                <Input />
            </Form.Item>
            <Form.Item label="Cor">
                <Input />
            </Form.Item>
            <Form.Item label="Chassi">
                <Input />
            </Form.Item>
            <Form.Item label="Modelo">
                <Select>
                    <Select.Option value="1">HM</Select.Option>
                    <Select.Option value="1">HF</Select.Option>
                </Select>
            </Form.Item>
            <Form.Item>
                <Button
                // onClick={() => onClearChange()}
                >
                    Salvar
                </Button>
                <Button
                    onClick={() => onClearChange()}
                >
                    Cancelar
                </Button>
            </Form.Item>
        </Form>
    );
}

export default FormPostTruck;
