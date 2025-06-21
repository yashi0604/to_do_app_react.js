.App {
  max-width: 400px;
  margin: auto;
  text-align: center;
  font-family: sans-serif;
  padding: 2rem;
}

.input-section {
  display: flex;
  justify-content: center;
  margin-bottom: 20px;
}

input {
  padding: 8px;
  font-size: 1rem;
  width: 70%;
}

button {
  padding: 8px 12px;
  margin-left: 8px;
  cursor: pointer;
}

ul {
  list-style-type: none;
  padding: 0;
}

li {
  display: flex;
  justify-content: space-between;
  padding: 8px 10px;
  margin-bottom: 8px;
  background-color: #f1f1f1;
  border-radius: 4px;
}

li.completed span {
  text-decoration: line-through;
  color: gray;
}

li span {
  cursor: pointer;
}
