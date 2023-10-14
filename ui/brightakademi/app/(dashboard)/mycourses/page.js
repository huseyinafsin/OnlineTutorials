"use client"
import React, { useEffect, useState } from 'react'
import  useTokenExpirationCheck from '@/app/hooks/useTokenExpirationCheck'

export default function MyCourses() {
const [items, setItems] = useState([]);
const [isLoaded, setIsLoaded] = useState(false);
const [hasError, setHasError] = useState(null);
const tokenStr = 'Bearer' + ' ' + JSON.parse(localStorage.getItem('access')).token;
useTokenExpirationCheck()


    useEffect(() => {

        fetch(`${process.env.API_URL}/courses/mycourses`,{
          headers: new Headers({
            'content-type': 'application/json',
              Authorization: tokenStr
          }),
        })
          .then(res => res.json())
          .then(
            (result) => {
              setIsLoaded(true);
              setItems(result.data);
            },
            (error) => {
              setIsLoaded(true);
              setError(error);
            }
          )
      }, [])

  return (
    <div className="col-12">
  <h4>Kurslarım</h4>

  {
    items.map((course,index)=>{
        return(
            <div className="card" key={index}>
            <div className="card-body">
            <div className="post">
            <div className="user-block">
              <img
                className="img-circle img-bordered-sm"
                src="../../assets/img/post/course.png"
                alt="user image"
              />
              <span className="username">
                <a href="#">{course.name}</a>   
              </span>
              <span className="description">{new Date(course.startCourseTime).toLocaleDateString("tr-TR")} - {new Date(course.finishCourseTime).toLocaleDateString("tr-TR")}</span>
            </div>
            {/* /.user-block */}
            <p>
              {course.description}
            </p>
            <p>
              <a href="#" className="link-black text-sm">
                <i className="fas fa-link mr-1" /> Demo File 1 v2
              </a>
            </p>
          </div>
            </div>
          </div>
        )
    })
  }



</div>

  )
}
