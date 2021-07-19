import { FaTruck } from 'react-icons/fa';
import logo from '../../images/simplr-view-logo.svg';
import { Input } from '../../components/Inputs';
import s from './styles.module.scss';

export default function Home() {
    return (
        <form>
            <div className={s['form-field-container']}>
                <Input id="name"
                       autoComplete="off"
                       type="email"
                       label="Teste"
                       leadingIcon={<FaTruck size="2.2rem" />}
                       trailingIcon={logo}
                       helperText="teste"
                       invalidValueText="erro"
                       maxLength={50}
                       showCharacterCount={true} />
            </div>
        </form>
    );
}
