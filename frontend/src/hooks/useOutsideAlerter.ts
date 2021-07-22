import { useEffect, RefObject } from 'react';

export function useOutsideAlerter(ref: RefObject<HTMLDivElement>, functionToExecute: Function){
    useEffect(() => {
        function handleClickOutside(evt: MouseEvent) {
            if (ref.current && !ref.current.contains(evt.target as Node)) {
                functionToExecute();
            }
        }
        document.addEventListener(('click'), handleClickOutside);
        return (() => {
            document.removeEventListener('click', handleClickOutside);
        });
    }, [ref, functionToExecute]);
}
