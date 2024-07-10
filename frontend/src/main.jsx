import React from 'react'
import ReactDOM from 'react-dom/client'
import App from './App.jsx'
import './index.css'
import Home from './Componets/Home/Home.jsx'
import Root from "./routes/root";
import ErrorPage from './error-page.jsx'
import Contact from "./routes/contact";

import {
  createBrowserRouter,
  Form,
  RouterProvider,
} from "react-router-dom";


const router = createBrowserRouter([
  {
    path: "/",
    element: <Root></Root>,
    errorElement: <ErrorPage />
    
  },
  {
    path: "contacts/:contactId",
    element: <Contact />,
  }
]);

ReactDOM.createRoot(document.getElementById('root')).render(
  <React.StrictMode>
 <RouterProvider router={router} />
  </React.StrictMode>,
)
