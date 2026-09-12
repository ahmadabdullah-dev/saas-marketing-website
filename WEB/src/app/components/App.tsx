import { Outlet } from "react-router";
import Header from "./Header/Header";
import Footer from "./Footer";

export default function App() {
  return (
    <div>
      <Header />
      <Outlet />
      <Footer />
    </div>
  );
}
