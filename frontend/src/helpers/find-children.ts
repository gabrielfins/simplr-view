import { ReactNode } from 'react';
import React from 'react';

/**
 * Finds the children of a specific type on the children props.
 * Meant to be used with dot notation components.
 * @param {any} children the children collection
 * @param {Function} type the function that represents the component type to find
 * @returns {ReactNode[]} the new array with the filtered children or an empty array if no child matches the type
 */
export function findChildren(children: any, type: Function): ReactNode[] {
  const newChildren: ReactNode[] = React.Children.map(children, (child) => {
    if (child?.type === type) {
      return child;
    }
  });
  return newChildren;
}
