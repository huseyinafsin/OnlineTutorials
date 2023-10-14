"use client"
import React, { useEffect, useState } from 'react'

export default function MyCourses() {
  const [items, setItems] = useState([]);
  const [isLoaded, setIsLoaded] = useState(false);
  const [hasError, setHasError] = useState(null);
  const tokenStr = 'Bearer' + ' ' + JSON.parse(localStorage.getItem('access')).token;


  useEffect(() => {

    fetch(`${process.env.API_URL}/courses/mycourses`, {
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
          setHasError(error);
        }
      )
  }, [])

  return (
    <div className="col-12">
      <h4>Kurslarım</h4>

      {
        items.map((course, index) => {
          return (
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
              <div className="card-footer">
                <div className="accordion" id={`accordionExample-${course.id}`}>
                  <div className="card">
                    <div className="card-header" id="headingOne">
                      <h5 className="mb-0">
                        <button className="btn btn-link" type="button" data-toggle="collapse" data-target="#collapseOne" aria-expanded="true" aria-controls="collapseOne">
                          Collapsible Group Item #1
                        </button>
                      </h5>
                    </div>

                    <div id="collapseOne" className="collapse show" aria-labelledby="headingOne" data-parent="#accordionExample">
                      <div className="card-body">
                        Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch. Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor, sunt aliqua put a bird on it squid single-origin coffee nulla assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher vice lomo. Leggings occaecat craft beer farm-to-table, raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore sustainable VHS.
                      </div>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          )
        })
      }



    </div>

  )
}
