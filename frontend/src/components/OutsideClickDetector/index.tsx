import { useRef, HTMLAttributes } from 'react';
import { useOutsideAlerter } from '../../hooks/useOutsideAlerter';

type OutsideClickDetectorProps = HTMLAttributes<HTMLDivElement> & {
    functionToExecute: Function;
};

export function OutsideClickDetector(props: OutsideClickDetectorProps) {
    const detectorWrapper = useRef<HTMLDivElement>(null);
    useOutsideAlerter(detectorWrapper, props.functionToExecute);

    return <div className="outside-click-detector" ref={detectorWrapper}>{props.children}</div>;
}
