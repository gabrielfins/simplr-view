import { InputHTMLAttributes, LabelHTMLAttributes, ReactNode } from 'react';
import { findChildren } from 'helpers/find-children';
import styles from './form-field.module.scss';

function Label(props: LabelHTMLAttributes<HTMLLabelElement>) {
  return <label className={styles.label} {...props} />;
}

function Input(props: InputHTMLAttributes<HTMLInputElement>) {
  return <input className={styles.input} {...props} />;
}

function Icon({ children }: { children: ReactNode }) {
  return <>{children}</>;
}

interface FormFieldProps {
  children: ReactNode;
}

export default function FormField({ children }: FormFieldProps) {
  const label = findChildren(children, Label);
  const input = findChildren(children, Input);
  const icon = findChildren(children, Icon);

  return (
    <div className={styles.formField}>
      {label.length !== 0 && label}
      {(input.length !== 0 || icon.length !== 0) && (
        <div className={`${styles.inputContainer}${icon.length ? ` ${styles.hasIcon}` : ''}`}>
          {input.length !== 0 && input}
          {icon.length !== 0 && (
            <div className={styles.icon}>
              {icon}
            </div>
          )}
        </div>
      )}
    </div>
  );
}

FormField.Label = Label;
FormField.Input = Input;
FormField.Icon = Icon;
