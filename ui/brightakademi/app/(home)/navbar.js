"use client"
import React, { useEffect, useState } from 'react'
import Link from 'next/link';
import { useRouter } from 'next/navigation';

function Navbar() {
  const [isLoggedIn, setIsLoggedIn] = useState(false);
  const [isHover, setIsHover] = useState(false);
  const username = JSON.parse(localStorage.getItem('access'))?.name;
  const router = useRouter();
  useEffect(() => {
    username ? setIsLoggedIn(true) : setIsLoggedIn(false)
  })
  
  const handleLogout =()=>{
    localStorage.removeItem('access');
    router.push("/");
    setIsLoggedIn(false);
  }
  return (
    <header>
      {/* Header Start */}
      <div className="header-area header-transparent">
        <div className="main-header ">
          <div className="header-bottom  header-sticky">
            <div className="container-fluid">
              <div className="row align-items-center">
                {/* Logo */}
                <div className="col-xl-2 col-lg-2">
                  <div className="logo">
                    <a href="/">
                      <img src="assets/img/logo/logo.png" alt="" />
                    </a>
                  </div>
                </div>
                <div className="col-xl-10 col-lg-10">
                  <div className="menu-wrapper d-flex align-items-center justify-content-end">
                    {/* Main-menu */}
                    <div className="main-menu d-none d-lg-block">
                      <nav>
                        <ul id="navigation">
                          <li className="active">
                            <Link href="/">Anasayfa</Link >
                          </li>
                          <li>
                            <Link href="/course">Kurslar</Link >
                          </li>
                          <li>
                            <Link href="/about">Hakkında</Link>
                          </li>
                          <li>
                            <Link href="/category">Kategoriler</Link>
                          </li>
                          <li>
                            <Link href="/contact">İletişim</Link>
                          </li>
                          {/* Button */}
                          <li className="button-header margin-left ">
                            {!isLoggedIn ? <Link href="/register" className={"btn"}>
                              Katıl
                            </Link> : ""}
                          </li>
                          <li className="button-header rounded">
                            
                              {isLoggedIn ? <>
                                <div class="dropdown">
                                  <div 
                                  onMouseOver={()=>setIsHover(true)}
                                  onMouseLeave={()=>setIsHover(false)}
                                  class="btn btn-primary dropdown-toggle" type="button" id="dropdownMenuButton1" data-bs-toggle="dropdown" aria-expanded="false">
                                   {!isHover ? <><i className="fas fa-user-circle"></i> {username}</> :
                                    <>
                                    <li onClick={handleLogout} >
                                      <i  class="fas fa-sign-out-alt"></i>Çıkış
                                    </li>
                                    <li>
                                      <Link href="/dashboard">
                                      <i class="fas fa-sign-out-alt"></i>Panele dön                                   
                                      </Link>
                                    </li>
                                    </>}
                                  </div>
                       
                                </div>
                                 </>
                                : <><Link href="login" className={"btn btn3"}>Giriş Yap </Link></>}
                            
                          </li>
                        </ul>
                      </nav>
                    </div>
                  </div>
                </div>
                {/* Mobile Menu */}
                <div className="col-12">
                  <div className="mobile_menu d-block d-lg-none" />
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
      {/* Header End */}
    </header>
  )
}

export default Navbar