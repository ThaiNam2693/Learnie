import React from "react";
import facebookIcon from "../assets/facebook.svg";
import twitterIcon from "../assets/twitter.svg";
import instagramIcon from "../assets/instagram.svg";

const Footer = () => {
  return (
    <footer className="bg-[#704FE6] text-white py-10 px-32 text-center w-full border-t border-gray-300 ">
      <div className="container mx-auto px-4">
        {/* Phần trên của footer */}
        <div className="flex justify-between items-center flex-col md:flex-row">
          {/* Phần bên trái của footer */}
          <div className="footer-left text-center md:text-left mb-4 md:mb-0">
            <p className="mb-2">&copy; 2024 - EXE_Learnie</p>
            <div className="flex justify-center md:justify-start items-center space-x-4">
              <a className="text-white hover:text-gray-300" href="#">
                Privacy Policy
              </a>
              <span className="text-white">|</span>
              <a className="text-white hover:text-gray-300" href="#">
                Terms of Service
              </a>
            </div>
          </div>

          {/* Phần bên phải của footer */}
          <div className="footer-right text-center md:text-right">
            <p className="mb-2">Follow us:</p>
            <div className="flex justify-center md:justify-end items-center space-x-4">
              <a href="https://www.facebook.com/profile.php?id=61562074755458" className="hover:opacity-75">
                <img src={facebookIcon} alt="Facebook" className="w-6 h-6" />
              </a>
              <a href="#" className="hover:opacity-75">
                <img src={twitterIcon} alt="Twitter" className="w-6 h-6" />
              </a>
              <a href="#" className="hover:opacity-75">
                <img src={instagramIcon} alt="Instagram" className="w-6 h-6" />
              </a>
            </div>
          </div>
        </div>

        {/* Phần bottom của footer */}
        <div className="footer-bottom text-center mt-4">
          <div className="flex justify-center space-x-6 text-xl">
            <a className="text-white hover:text-gray-300" href="#">
              Home
            </a>
            <a className="text-white hover:text-gray-300" href="#">
              About Us
            </a>
            <a className="text-white hover:text-gray-300" href="#">
              For Student
            </a>
            <a className="text-white hover:text-gray-300" href="#">
              For Teacher
            </a>
            <a className="text-white hover:text-gray-300" href="#">
              Resource
            </a>
          </div>
        </div>
      </div>
    </footer>
  );
};

export default Footer;
