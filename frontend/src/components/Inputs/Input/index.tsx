import { useState, useEffect, ReactNode, FormEvent, InputHTMLAttributes } from 'react';
import { FaExclamationCircle } from 'react-icons/fa';
import { FloatingLabel } from '../FloatingLabel';
import './styles.scss';

type InputProps = InputHTMLAttributes<HTMLInputElement> & {
    leadingIcon?: string | ReactNode;
    trailingIcon?: string | ReactNode;
    label: string;
    helperText?: string;
    invalidValueText?: string;
    showInvalidValueIcon?: boolean;
    showCharacterCount?: boolean;
}

export function Input({leadingIcon, trailingIcon, label, helperText, invalidValueText, showInvalidValueIcon = true, showCharacterCount = false, ...props}: InputProps) {
    const [value, setValue] = useState(props.value ? props.value : '');
    const [valueLength, setValueLength] = useState(value.toString().length);
    const [isInputFocused, setIsInputFocused] = useState<boolean>();
    const [isInputFilled, setIsInputFilled] = useState(value ? true : false);
    const [isInputedValueValid, setIsInputedValueValid] = useState(true);

    function handleInput(evt: FormEvent<HTMLInputElement>) {
        setValue(evt.currentTarget.value);
        setIsInputedValueValid(evt.currentTarget.checkValidity());
    }

    useEffect(() => {
        setIsInputFilled(value ? true : false);
        setValueLength(value.toString().length);
    }, [value]);

    return (
        <div className={`input-component${isInputFocused ? ' focused' : ''}${leadingIcon ? ' leading' : ''}${trailingIcon || !isInputedValueValid ? ' trailing' : ''}${isInputedValueValid ? '' : ' invalid'}`}>
            <div>
                <div className="input-container">
                    {typeof(leadingIcon) === 'string' ? (
                        <img aria-hidden={true} className="input-leading-icon" src={leadingIcon} alt="" />
                    ) : (
                        <div className="input-leading-icon">
                            {leadingIcon}
                        </div>
                    )}
                    <input className="input" {...props} value={value} onInput={(evt) => handleInput(evt)} onFocus={() => setIsInputFocused(true)} onBlur={() => setIsInputFocused(false)} />
                    {!isInputedValueValid ? (<FaExclamationCircle className={`input-trailing-icon invalid`} size="2.2rem" />) : typeof(trailingIcon) === 'string' ? (
                        <img aria-hidden={true} className="input-trailing-icon" src={trailingIcon} alt="" />
                    ) : (
                        <div className="input-trailing-icon">
                            {trailingIcon}
                        </div>
                    )}
                </div>
                <FloatingLabel className="input-label" htmlFor={props.id} label={label} floating={isInputFocused || isInputFilled} />
            </div>
            <div className="input-helper-container">
                <span className="input-helper">{isInputedValueValid ? helperText : invalidValueText ? invalidValueText : helperText}</span>
                {showCharacterCount &&
                    <span className="input-character-count">{`${valueLength}${props.maxLength ? ' / ' + props.maxLength : ''}`}</span>
                }
            </div>
        </div>
    );
}
