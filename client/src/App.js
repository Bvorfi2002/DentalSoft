import "./App.css";
import { BrowserRouter, Route, Routes, Navigate } from "react-router-dom";
import Aos from "aos";
import Dashboard from "./screens/Dashboard";
import Toast from "./components/Notifications/Toast";
import Payments from "./screens/Payments/Payments";
import Appointments from "./screens/Appointments";
import Patients from "./screens/Patients/Patients";
import Campaings from "./screens/Campaings";
import Services from "./screens/Services";
import Invoices from "./screens/Invoices/Invoices";
import Settings from "./screens/Settings";
import CreateInvoice from "./screens/Invoices/CreateInvoice";
import EditInvoice from "./screens/Invoices/EditInvoice";
import PreviewInvoice from "./screens/Invoices/PreviewInvoice";
import EditPayment from "./screens/Payments/EditPayment";
import PreviewPayment from "./screens/Payments/PreviewPayment";
import Medicine from "./screens/Medicine";
import PatientProfile from "./screens/Patients/PatientProfile";
import CreatePatient from "./screens/Patients/CreatePatient";
import Doctors from "./screens/Doctors/Doctors";
import DoctorProfile from "./screens/Doctors/DoctorProfile";
import Receptions from "./screens/Receptions";
import NewMedicalRecode from "./screens/Patients/NewMedicalRecode";
import NotFound from "./screens/NotFound";
import Login from "./screens/Login";
import ProtectedRoute from "./components/ProtectedRoute";
import AdminDashboard from "./screens/AdminDashboard";


function App() {
  Aos.init();
  const DefaultRoute = () => {
    const user = JSON.parse(localStorage.getItem("user"));

    if (!user) return <Navigate to="/login" />;

    switch (user.role) {
      case "admin":
        return <Navigate to="/admin" />;
      case "doctor":
        return <Navigate to="/doctor" />;
      case "finance":
        return <Navigate to="/finance" />;
      case "receptionist":
        return <Navigate to="/reception" />;
      default:
        return <Navigate to="/unauthorized" />;
    }
  };

  return (
    <>
      {/* Toaster */}
      <Toast />
      {/* Routes */}
      <BrowserRouter>
        <Routes>
          <Route path="/login" element={<Login />} />

          <Route
            path="/"
            element={
              <ProtectedRoute>
                <Dashboard />
              </ProtectedRoute>
            }
          />
          <Route
            path="/admin"
            element={
              <ProtectedRoute allowedRoles={["admin"]}>
                <AdminDashboard />
              </ProtectedRoute>
            }
          />
          <Route
            path="/doctor"
            element={
              <ProtectedRoute allowedRoles={["doctor"]}>
                <Dashboard />
              </ProtectedRoute>
            }
          />
          <Route
            path="/finance"
            element={
              <ProtectedRoute allowedRoles={["finance"]}>
                <Dashboard />
              </ProtectedRoute>
            }
          />
          <Route
            path="/reception"
            element={
              <ProtectedRoute allowedRoles={["receptionist"]}>
                <Dashboard />
              </ProtectedRoute>
            }
          />

          {/* invoce */}
          <Route path="/invoices" element={<Invoices />} />
          <Route path="/invoices/create" element={<CreateInvoice />} />
          <Route path="/invoices/edit/:id" element={<EditInvoice />} />
          <Route path="/invoices/preview/:id" element={<PreviewInvoice />} />
          {/* payments */}
          <Route path="/payments" element={<Payments />} />
          <Route path="/payments/edit/:id" element={<EditPayment />} />
          <Route path="/payments/preview/:id" element={<PreviewPayment />} />
          {/* patient */}
          <Route path="/patients" element={<Patients />} />
          <Route path="/patients/preview/:id" element={<PatientProfile />} />
          <Route path="/patients/create" element={<CreatePatient />} />
          <Route path="/patients/visiting/:id" element={<NewMedicalRecode />} />
          {/* doctors */}
          <Route path="/doctors" element={<Doctors />} />
          <Route path="/doctors/preview/:id" element={<DoctorProfile />} />
          {/* reception */}
          <Route path="/receptions" element={<Receptions />} />
          {/* others */}
          <Route path="/appointments" element={<Appointments />} />
          <Route path="/campaigns" element={<Campaings />} />
          <Route path="/medicine" element={<Medicine />} />
          <Route path="/services" element={<Services />} />
          <Route path="/settings" element={<Settings />} />
          <Route path="*" element={<NotFound />} />
        </Routes>
      </BrowserRouter>
    </>
  );
}

export default App;
