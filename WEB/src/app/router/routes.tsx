import { createBrowserRouter } from "react-router";
import App from "../components/App";
import NotFound from "../../features/errors/NotFound";
import ErrorPage from "../../features/errors/ErrorPage";
import LoginForm from "../../features/auth/LoginForm";
import LandingPage from "../components/LandingPage";
import AdminDashbord from "../components/AdminDashbord";
import PricingTable from "../../features/pricing/PricingTable";

export const routes = createBrowserRouter([
  {
    path: "/",
    element: <App />,
    errorElement: <ErrorPage />,
    children: [
      { index: true, element: <LandingPage /> },
      { path: "admin", element: <AdminDashbord /> },
      { path: "pricing", element: <PricingTable/> },

      { path: "login", element: <LoginForm /> },
    ],
  },
  { path: "*", element: <NotFound /> },
]);
