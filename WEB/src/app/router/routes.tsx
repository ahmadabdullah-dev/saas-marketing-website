import { createBrowserRouter, Navigate } from "react-router";
import App from "../components/App";
import NotFound from "../../features/errors/NotFound";
import ErrorPage from "../../features/errors/ErrorPage";
import LoginForm from "../../features/auth/LoginForm";

export const routes = createBrowserRouter([
  {
    path: "/",
    element: <App />,
    errorElement: <ErrorPage />,
    children: [
      { index: true, element: <Navigate to="/dashboard" replace /> },
      { path: "login", element: <LoginForm /> },
    ],
  },
  { path: "*", element: <NotFound /> },
]);
