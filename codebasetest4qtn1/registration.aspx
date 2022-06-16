<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registration.aspx.cs" Inherits="codebasetest4qtn1.registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="./Register_style.css">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <pannel>
       <h1>Create an Account</h1>
      <table>
       
        <tr>
          <td><label for="email">Email:</label></td>
       
          <td><input type="text" name="email" id="email" placeholder="your email"></td>
        </tr>
        <tr>
          <td><label for="password">Password:</label></td>
          <td><input type="password" name="password" id="password"></td>
        </tr>
       
       
        <tr>
          <td><label for="language">Age</label></td>
          <td>
            <select name="language" id="language">
              <option value="">18</option>
              <option value="English">19</option>
              <option value="Spanish">20</option>
              <option value="Hindi">21</option>
              <option value="Arabic">22</option>
              <option value="Russian">23</option>
              <option value="">24</option>
              <option value="English">25</option>
              <option value="Spanish">26</option>
              <option value="Hindi">27</option>
              <option value="Arabic">28</option>
              <option value="Russian">29</option>
              <option value="Russian">30</option>
            </select>
          </td>
        </tr>
       
          <td><label for="about">Tell me about your:</label></td>
          <td><textarea name="about" id="about" placeholder="Write about yourself..."></textarea></td>
        </tr>
      </tr>
 
          <td><input type="CheckBox" name="gender" value="other">
            <label for="about">I aggree to the <a>terms of service</a></label></td>
        </tr>
        <tr>
          <td colspan="2"><input type="submit" class="submit" value="Sign Up" /></td>
        </tr>
      </table>
      </pannel>
        </div>
    </form>
</body>
</html>
