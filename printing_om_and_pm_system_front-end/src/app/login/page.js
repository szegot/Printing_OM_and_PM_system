//import styles from "../../../styles/global.css"
import LoginForm from "@/components/LoginForm";

const loginPage = () => {
    
    const handleSubmit = async (userInfo) => {
        const result = await signIn("credentials", {
          email: userInfo.email,
          password: userInfo.password,
          redirect: false,
        });
        return result;
    };

    return (
        <div>
            <h1>Login</h1>
            <LoginForm 
            handleSubmit={handleSubmit}
            />
        </div>
    );
};

export default loginPage;