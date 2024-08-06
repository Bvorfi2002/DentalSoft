import React, { useState } from "react";
import { Button, Input } from "../components/Form";
import { BiLogInCircle } from "react-icons/bi";
import { useNavigate } from "react-router-dom";

const users = [
  { email: "admin@gmail.com", password: "password", role: "admin" },
  { email: "doctor@gmail.com", password: "password", role: "doctor" },
  { email: "finance@gmail.com", password: "password", role: "finance" },
  { email: "receptionist@gmail.com", password: "password", role: "receptionist" },
];

function Login() {
  const [email, setEmail] = useState("");
  const [password, setPassword] = useState("");
  const [error, setError] = useState("");
  const navigate = useNavigate();

  const handleEmailChange = (e) => {
    console.log("Email input change:", e.target.value);
    setEmail(e.target.value);
  };

  const handlePasswordChange = (e) => {
    console.log("Password input change:", e.target.value);
    setPassword(e.target.value);
  };

  const handleLogin = (e) => {
    e.preventDefault();
    console.log("Attempting login with:", email, password);

    const user = users.find((user) => user.email === email && user.password === password);

    if (user) {
      console.log("Login successful:", user);
      localStorage.setItem("user", JSON.stringify({ email: user.email, role: user.role }));

      switch (user.role) {
        case "admin":
          navigate("/admin");
          break;
        case "doctor":
          navigate("/doctor");
          break;
        case "finance":
          navigate("/finance");
          break;
        case "receptionist":
          navigate("/reception");
          break;
        default:
          navigate("/unauthorized");
      }
    } else {
      console.log("Login failed: Invalid email or password");
      setError("Invalid email or password");
    }
  };

  return (
    <div className="w-full h-screen flex-colo bg-dry">
      <form
        className="w-2/5 p-8 rounded-2xl mx-auto bg-white flex-colo"
        onSubmit={handleLogin}
      >
        <img
          src="/images/logo.png"
          alt="logo"
          className="w-48 h-16 object-contain"
        />
        <div className="flex flex-col gap-4 w-full mb-6">
          <Input
            label="Email"
            type="email"
            color={true}
            placeholder="admin@gmail.com"
            value={email}
            onChange={handleEmailChange}
          />
          <Input
            label="Password"
            type="password"
            color={true}
            placeholder="*********"
            value={password}
            onChange={handlePasswordChange}
          />
        </div>
        {error && <p className="text-red-500">{error}</p>}
        <Button label="Login" Icon={BiLogInCircle} type="submit" />
      </form>
    </div>
  );
}

export default Login;
