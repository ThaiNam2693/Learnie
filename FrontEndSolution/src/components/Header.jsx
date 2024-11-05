import React from "react";
import HomeIcon from "../assets/Homefilled.svg";
import OpenFolder from "../assets/Folderopen.svg";
import Group from "../assets/Group.svg";
import Look from "../assets/Look.svg";

const Header = () => {
  return (
    <div>
      <div className="w-full h-24 p-5">
        <div className="flex">
          <div className="w-[50%] flex">
            <div className="w-[171px] h-[45px] bg-[#704FE3] text-white flex items-center justify-center rounded-3xl font-newsreader">
              LEARNIE
            </div>
            <div className="pl-3 flex justify-between items-center gap-6">
              <div>
                <img src={HomeIcon} alt="" />
              </div>
              <div>
                <img src={OpenFolder} alt="" />
              </div>
              <div>
                <img src={Group} alt="" />
              </div>
            </div>
          </div>
          <div className="flex gap-5">
            <div className="w-[315px] h-[42px] bg-[#F1F1F1] rounded-3xl flex items-center p-3 ">
              <img src={Look} alt="" className="ml-auto" />
            </div>
            <button className="w-[172px] h-[32px] bg-[#F39DAA] rounded-3xl t text-[#B2152D] flex justify-center items-center mt-1 font-newsreader text-[18px] hover:opacity-70">
              Đăng ký
            </button>
            <button className="w-[172px] h-[32px] bg-[#F39DAA] rounded-3xl t text-[#B2152D] flex justify-center items-center mt-1 font-newsreader text-[18px] hover:opacity-70">
              Đăng nhập
            </button>
          </div>
        </div>
      </div>
    </div>
  );
};

export default Header;
