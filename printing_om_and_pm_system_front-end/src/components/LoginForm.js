//import styles from "../../styles/global.css";
import Link from "next/link";
//import { useState } from "react";
import { useRouter } from "next/navigation";

const LoginForm = ({ handleSubmit }) => {
  const router = useRouter();
  const [message, setMessage] = useState("");
  const [userInfo, setUserInfo] = useState({ email: "", password: "" });

  const handleFormSubmit = async (e) => {
    e.preventDefault();
    const result = await handleSubmit(userInfo);

    if (result.error) {
      console.log("Error:", result.error);
      setMessage("Incorrect email or password");
    } else {
      router.push("/");
    }
  }

  return (
    <form onSubmit={handleFormSubmit} data-testid="form">
      <div >
        <input
          name="email"
          placeholder="E-mail"
          type="email"
          required
          value={userInfo.email}
          pattern="^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"
          onChange={({ target }) =>
            setUserInfo({ ...userInfo, email: target.value })
          }
          data-testid="email"
        />
      </div>
      <br />
      <div>
        <input
          name="password"
          placeholder="Password"
          type="password"
          minLength="8"
          pattern=".{8,}"
          title="minimum 8 characters"
          required
          value={userInfo.password}
          onChange={({ target }) =>
            setUserInfo({ ...userInfo, password: target.value })
          }
        />
      </div>
      <div>
        <button data-testid="submit">Log In</button>
        <p>
          If you don't have an account,
          <Link href="/registration">
            {" "}
            click here!
          </Link>
        </p>

        <p>{message}</p>
      </div>
    </form>
  )
}

export default LoginForm;