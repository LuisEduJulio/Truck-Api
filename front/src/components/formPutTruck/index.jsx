import React, { useState } from 'react';
import {
    Form,
    Input,
    Button,
    Select
} from 'antd';
import moment from 'moment';

function FormPutTruck({
    handleChange,
    onSubmit,
    truck,
    handleCancel
}) {
    return (
        <Form
            name="normal_login"
            className="login-form"
            initialValues={{
                remember: true,
            }}
            onFinish={onSubmit}
        >
            <Form.Item label="Data de Fabricação">
                <Input
                    class="form-control"
                    placeholder="Digite o modelo"
                    type="date"
                    value={moment(truck?.dateFabric).format('YYYY-MM-DD') || ''}
                    onChange={({ target }) => handleChange("dateFabric", target.value)}
                    required={true}
                />
            </Form.Item>
            <Form.Item label="Data do Modelo">
                <Input
                    class="form-control"
                    placeholder="Data a data do Modelo"
                    type="date"
                    value={moment(truck?.dateModel).format('YYYY-MM-DD') || ''}
                    onChange={({ target }) => handleChange("dateModel", target.value)}
                    required={true}
                />
            </Form.Item>
            <Form.Item label="Cor">
                <Input
                    class="form-control"
                    placeholder="Digite a cor do modelo"
                    type="text"
                    value={truck?.color || ''}
                    onChange={({ target }) => handleChange("color", target.value)}
                    required={true}
                />
            </Form.Item>
            <Form.Item label="Chassi">
                <Input
                    class="form-control"
                    placeholder="Digite a cor do modelo"
                    type="text"
                    value={truck?.chassis || ''}
                    onChange={({ target }) => handleChange("chassis", target.value)}
                    required={true}
                />
            </Form.Item>
            <Form.Item label="Modelo">
                <Select>
                    <Select.Option value="1">HM</Select.Option>
                    <Select.Option value="2">HF</Select.Option>
                </Select>
            </Form.Item>
            <Form.Item
                style={{ marginTop: 30 }}
            >
                <Button
                    type="primary"
                    htmlType="submit"
                    style={{
                        width: '100%'
                    }}
                >
                    Salvar
                </Button>
                <Button
                    type="secundary"
                    style={{
                        width: '100%'
                    }}
                    onClick={handleCancel}
                >
                    Cancelar
                </Button>
            </Form.Item>
        </Form>
    );
}

export default FormPutTruck;
