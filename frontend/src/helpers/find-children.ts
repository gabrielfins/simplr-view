import { ReactNode } from 'react';
import React from 'react';

export function findChildren(children: any, type: Function): Array<ReactNode> {
  const newChildren: Array<ReactNode> = React.Children.map(children, (child) => {
    if (child?.type === type) {
      return child;
    }
  });
  return newChildren;
}
