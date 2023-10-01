import React, { useState, useEffect, Component } from 'react';

function withButtonState(Component) {
  return function WrappedComponent(props) {
    const [count, setCount] = useState(0);

    useEffect(() => {
      document.title = `Clicked ${count} times`;

      return () => {
        document.title = 'React App';
      };
    }, [count]);

    function handleClick() {
      setCount(count + 1);
    }

    return <Component count={count} onClick={handleClick} {...props} />;
  };
}

function MyButton({ count, onClick }) {
  return (
    <button onClick={onClick}>
      Clicked {count} times
    </button>
  );
}

const ButtonWithState = withButtonState(MyButton);

class LifecycleComponent extends Component {
  componentDidMount() {
    console.log('LifecycleComponent mounted');
  }

  componentWillUnmount() {
    console.log('LifecycleComponent will unmount');
  }

  render() {
    return (
      <div>
        <h2>Lifecycle Component</h2>
        <p>This component uses lifecycle methods</p>
      </div>
    );
  }
}

export default function MyApp() {
  return (
    <div>
      <h1>Usage hook</h1>
      <ButtonWithState />
      <ButtonWithState />
      <LifecycleComponent />
    </div>
  );
}
