import React from 'react';
import {
    Form,
    Input,
    Button,
    Select
} from 'antd';

const { Option } = Select;

function FormPostTruck({
    handleChange,
    onSubmit,
    truck,
    onClearChange
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
                    value={truck?.dateFabric || ''}
                    onChange={({ target }) => handleChange("dateFabric", target.value)}
                    required={true}
                />
            </Form.Item>
            <Form.Item label="Data do Modelo">
                <Input
                    class="form-control"
                    placeholder="Data a data do Modelo"
                    type="date"
                    value={truck?.dateModel || ''}
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
                <Select
                    onChange={(value) => handleChange("eModelTruck", value)}
                >
                    <Option value="1">FM</Option>
                    <Option value="2">FH</Option>
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
                    onClick={onClearChange}
                >
                    Cancelar
                </Button>
            </Form.Item>
        </Form>
    );
}

export default FormPostTruck;
