import { useState } from 'react';
import { useEffect } from 'react';
import { LabelHTMLAttributes } from 'react';
import './styles.scss';

type FloatingLabelProps = LabelHTMLAttributes<HTMLLabelElement> & {
    label: string;
    floating: boolean;
}

export function FloatingLabel({label, floating, ...props}: FloatingLabelProps) {
    const [isFloating, setIsFloating] = useState<boolean>(floating);

    useEffect(() => {
        setIsFloating(floating);
    }, [floating]);

    return (
        <div className={`floating-label-container${isFloating ? ' floating' : ''}`}>
            <label {...props}>{label}</label>
        </div>
    );
}