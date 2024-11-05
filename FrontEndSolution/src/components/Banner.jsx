import React from "react";
import Game from "../assets/Game.svg";
import Artical from "../assets/Article.svg";
import Pratice from "../assets/Pratice.svg";
import Library from "../assets/Library.svg";

const Banner = () => {
  return (
    <div>
      <div className="w-full h-[470px] bg-[#DFC8FE] py-14 ">
        <div className="pl-20" >
          <h1 className="text-6xl font-bold font-montserrat-alt">
          Học và chơi cùng Learnie nhé!!
          </h1>
        </div>
        <div className="mt-10 ml-20">
            <span className="text-xl font-newsreader">Learnie sẽ cố gắng cung cấp cho người bạn của mình những  cách học sinh động hơn và dễ tiếp cận hơn <br/> bằng
                 các trò chơi cũng như những tiện ích cần thiết trong học tập.</span>
        </div>
        <div className="h-[200px] bg-[#FFFDFDB2] opacity-70 mt-10 flex items-center justify-around">
            <button className="w-[170px] h-[170px] bg-[#DFC8FE] rounded-3xl p-7 hover:opacity-70">
                <div className="">
                    <img src={Game} alt="" />
                </div>
            </button>
            <button className="w-[170px] h-[170px] bg-[#704FE6] rounded-3xl p-7 hover:opacity-70">
            <div className="">
                    <img src={Artical} alt="" />
                </div>
            </button>
            <button className="w-[170px] h-[170px] bg-[#F3B62A] rounded-3xl p-7 hover:opacity-70">
            <div className="">
                    <img src={Pratice} alt="" />
                </div>
            </button>
            <button className="w-[170px] h-[170px] bg-[#F39DAA] rounded-3xl p-7 hover:opacity-70">
            <div className="">
                    <img src={Library} alt="" />
                </div>
            </button>
        </div>
      </div>
    </div>
  );
};

export default Banner;
