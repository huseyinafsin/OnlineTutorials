import React from 'react'
import Link from 'next/link';

function Navbar() {
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
                        <Link href="/">Blog</Link>
                        </li>
                        <li>
                        <Link href="/contact">İletişim</Link>
                        </li>
                        {/* Button */}
                        <li className="button-header margin-left ">
                          <Link href="/course" className={"btn"}>
                            Katıl
                          </Link>
                        </li>
                        <li className="button-header">
                          <Link href="login" className={"btn btn3"}>
                            Giriş Yap
                          </Link>
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