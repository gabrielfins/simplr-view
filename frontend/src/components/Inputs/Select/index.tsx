import { useState, useEffect, useRef, FormEvent, InputHTMLAttributes } from 'react';
import { FaAngleDown, FaAngleUp } from 'react-icons/fa';
import { Dropdown, DropdownButton } from '../../Dropdown';
import { FloatingLabel } from '../FloatingLabel';
import { OutsideClickDetector } from '../../OutsideClickDetector';
import './styles.scss';

type SelectProps = InputHTMLAttributes<HTMLInputElement> & {
    label: string;
    options: Array<SelectOptions>;
}

type SelectOptions = {
    value?: string;
    displayText: string;
}

export function Select({label, options, ...props}: SelectProps) {
    const [value, setValue] = useState(props.value ? props.value : '');
    const [isInputFocused, setIsInputFocused] = useState<boolean>();
    const [isInputFilled, setIsInputFilled] = useState<boolean>(value ? true : false);
    const dropdown = useRef<HTMLDivElement>(null);

    useEffect(() => {
        setIsInputFilled(value ? true : false);
    }, [value]);

    function handleInputClick() {
        setIsInputFocused(!isInputFocused);
    }

    function handleDropdownButtonClick(evt: FormEvent<HTMLButtonElement>) {
        setIsInputFocused(false);
        setValue(evt.currentTarget.value);
    }

    function handleOutsideClick() {
        setIsInputFocused(false);
    }

    return (
        <div className={`select-component${isInputFocused ? ' focused' : ''}`}>
            <OutsideClickDetector functionToExecute={handleOutsideClick}>
                <div className="select-wrapper">
                    <div className="select-container">
                        <input className="select" type="text" {...props} value={value} onInput={(evt) => setValue(evt.currentTarget.value)} onMouseDown={handleInputClick} />
                        {!isInputFocused ? <FaAngleDown className="select-icon" /> : <FaAngleUp className="select-icon" />}
                    </div>
                    <FloatingLabel className="select-label" htmlFor={props.id} label="teste" floating={isInputFocused || isInputFilled} />
                </div>
                {isInputFocused &&
                    <Dropdown ref={dropdown}>
                        {options.map((option, index) => {
                            return <DropdownButton key={index} value={option.value ? option.value : option.displayText} onClick={(evt) => handleDropdownButtonClick(evt)}>{option.displayText}</DropdownButton>
                        })}
                    </Dropdown>
                }
            </OutsideClickDetector>
        </div>
    );
}
