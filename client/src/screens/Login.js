import React, { useState } from "react";
import { Button, Input } from "../components/Form";
import { BiLogInCircle } from "react-icons/bi";
import { useNavigate } from "react-router-dom";

function Login() {
  const [email, setEmail] = useState("admin@gmail.com");
  const [password, setPassword] = useState("password");
  const [error, setError] = useState("");
  const navigate = useNavigate();

  const handleLogin = (e) => {
    e.preventDefault();

    // Example login logic (replace with your actual authentication logic)
    if (email === "admin@gmail.com" && password === "password") {
      // Save user info (e.g., in localStorage)
      localStorage.setItem("user", JSON.stringify({ email, role: "admin" }));

      // Navigate to the dashboard or appropriate page
      navigate("/");
    } else {
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
            onChange={(e) => {
              console.log("Email input changed:", e.target.value);
              setEmail(e.target.value);
            }}
          />
          <Input
            label="Password"
            type="password"
            color={true}
            placeholder="*********"
            value={password}
            onChange={(e) => {
              console.log("Password input changed:", e.target.value);
              setPassword(e.target.value);
            }}
          />
        </div>
        {error && <p className="text-red-500">{error}</p>}
        <Button label="Login" Icon={BiLogInCircle} type="submit" />
      </form>
    </div>
  );
}

export default Login;
