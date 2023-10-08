import React, { useState, useMemo } from 'react';

function ExpensiveComponent({ data }) {
  return <div>Дорогостоящий компонент</div>;
}

const MemoizedExpensiveComponent = React.memo(ExpensiveComponent);

function App() {
  const [count, setCount] = useState(0);
  const [data, setData] = useState(5);

  const handleIncrement = () => {
    setCount(count + 1);
  };

  const handleDataChange = () => {
    setData(data + 1);
  };

  const result = useMemo(() => {
    return data * 2;
  }, [data]);

  return (
    <div>
      <p>Использование  Event handlers </p>
      <p>Счетчик: {count}</p>
        <button onClick={handleIncrement}>Увеличить</button>
      <br/>
      <br/>
      <p>Использование  Memoization  </p>
      <button onClick={handleDataChange}>Изменить данные</button>
      <MemoizedExpensiveComponent data={data} />
      <div>Результат вычисления: {result}</div>
    </div>
  );
}

export default App;
