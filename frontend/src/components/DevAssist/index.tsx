import { useEffect } from 'react';
import { useState } from 'react';
import { FaRegSun, FaRegMoon } from 'react-icons/fa';
import s from './styles.module.scss';

export default function DevAssist() {
    const [isDevAssistOpen, setDevAssistOpen] = useState(false);
    const [isLightTheme, setLightTheme] = useState(false);
    const [themeColor, setThemeColor] = useState('marine');

    useEffect(() => {
        if (isLightTheme) {
            document.body.classList.add('light-theme');
        } else {
            document.body.classList.remove('light-theme');
        }
    }, [isLightTheme]);

    useEffect(() => {
        const themeColorClassName = `${isLightTheme ? 'light-theme' : ''}${isLightTheme && themeColor !== 'marine' ? ' ' : ''}${themeColor === 'marine' ? '' : themeColor}`;
        document.body.setAttribute('class', themeColorClassName);
    }, [isLightTheme, themeColor]);

    return (
        <div className={s['dev-assist']}>
            <button className={s['dev-assist-toggle']} onClick={() => setDevAssistOpen(!isDevAssistOpen)}>DevAssist</button>
            {isDevAssistOpen &&
                <div>
                    <div className={s['tool-section']}>
                        <span className={s['tool-heading']}>Tema</span>
                        <div className={s['theme-selection']}>
                            <button className={s['theme-selection-button']} onClick={() => setLightTheme(true)}><FaRegSun />Claro</button>
                            <button className={s['theme-selection-button']} onClick={() => setLightTheme(false)}><FaRegMoon />Escuro</button>
                        </div>
                    </div>
                    <div className={s['tool-section']}>
                        <span className={s['tool-heading']}>Cor de destaque</span>
                        <div className={s['theme-color-selection']}>
                            <button id={s['marine']} className={s['color-selection-button']} onClick={() => setThemeColor('marine')}></button>
                            <button id={s['blue']} className={s['color-selection-button']} onClick={() => setThemeColor('blue')}></button>
                            <button id={s['olive']} className={s['color-selection-button']} onClick={() => setThemeColor('olive')}></button>
                            <button id={s['green']} className={s['color-selection-button']} onClick={() => setThemeColor('green')}></button>
                            <button id={s['amber']} className={s['color-selection-button']} onClick={() => setThemeColor('amber')}></button>
                            <button id={s['yellow']} className={s['color-selection-button']} onClick={() => setThemeColor('yellow')}></button>
                            <button id={s['red']} className={s['color-selection-button']} onClick={() => setThemeColor('red')}></button>
                            <button id={s['orange']} className={s['color-selection-button']} onClick={() => setThemeColor('orange')}></button>
                            <button id={s['pink']} className={s['color-selection-button']} onClick={() => setThemeColor('pink')}></button>
                            <button id={s['salmon']} className={s['color-selection-button']} onClick={() => setThemeColor('salmon')}></button>
                            <button id={s['purple']} className={s['color-selection-button']} onClick={() => setThemeColor('purple')}></button>
                            <button id={s['violet']} className={s['color-selection-button']} onClick={() => setThemeColor('violet')}></button>
                        </div>
                    </div>
                </div>
            }
        </div>
    );
}
