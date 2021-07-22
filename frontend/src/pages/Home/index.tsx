import { Input, Select } from '../../components/Inputs';
import s from './styles.module.scss';

export default function Home() {
    return (
        <form>
            <div className={s['form-field-container']}>
                <Input id="name"
                       autoComplete="off"
                       type="email"
                       label="Teste"
                       helperText="teste"
                       invalidValueText="erro"
                       maxLength={50}
                       showCharacterCount={true}
                />
                <Select readOnly={true}
                        label="teste"
                        options={[
                            {value: 'funciona', displayText: 'teste'},
                            {value: 'pra cacete', displayText: 'Teste 2'}
                        ]}
                />
            </div>
        </form>
    );
}
