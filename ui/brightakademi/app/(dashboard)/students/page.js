"use client"
import { info } from 'autoprefixer';
import { useEffect, useState } from 'react';
import { toast } from 'react-toastify';
import { Modal, Button } from "react-bootstrap";
import Link from 'next/link';
import { useRouter } from 'next/navigation';

export default function Home() {

  const [hasError, setHasError] = useState(false);
  const [isLoaded, setIsLoaded] = useState(false);
  const [items, setItems] = useState([]);
  const [refresh, setRefresh] = useState(1);
  const [isCreateModalOpen, setIsCreateModalOpen] = useState(false);
  const [isUpdateModalOpen, setIsUpdateModalOpen] = useState(false);
  const [isDeleteModalOpen, setIsDeleteModalOpen] = useState(false);
  const [item, setItem] = useState({});
  const tokenStr = 'Bearer' + ' ' + JSON.parse(localStorage.getItem('access')).token;
  const router = useRouter()

  const [inputField, setInputField] = useState({
    firstName: '',
    lastName: '',
    educationalStatus: '',
    isActive: false
  })


  const inputsHandler = (e) => {
    const newValue = e.target.type === 'checkbox' ? e.target.checked : e.target.value;
    setInputField({ ...inputField, [e.target.name]: newValue })
  }
  const itemHandler = (e) => {
    const newValue = e.target.type === 'checkbox' ? e.target.checked : e.target.value;
    setItem({ ...item, [e.target.name]: newValue })
  }

  useEffect(() => {
    fetch(`${process.env.API_URL}/students`, {
      headers: new Headers({
        'content-type': 'application/json',
        Authorization: tokenStr
      }),
    }).then((res)=>{
      if(!res.ok){ throw new Error("unauthorized")}
      return res.json();
    }).then(
        (result) => {
          setIsLoaded(true);
          setItems(result.data);
        },
        (error) => {
          toast.error("Erişiminiz bulunmamakta")
          router.push("/dashboard")
          setHasError(true);
        }
      )
  }, [refresh])


  const handleCloseCreateModal = () => setIsCreateModalOpen(false)
  const handleOpenCreateModal = () => setIsCreateModalOpen(true)
  const handleOpenDeleteModal = () => setIsDeleteModalOpen(true)
  const handleCloseDeleteModal = () => setIsDeleteModalOpen(false)
  const handleOpenUpdateModal = () => setIsUpdateModalOpen(true)
  const handleCloseUpdateModal = () => setIsUpdateModalOpen(false)
  const handleItem2Delete = (item) => {
    item.isDeleted = true
    setItem(item)
    handleOpenDeleteModal()
  }
  const handleItem2Update = (item) => {
    setItem(item)
    handleOpenUpdateModal()
  }



  const handleSubmit = () => {
    var obj = JSON.stringify(inputField);
    fetch(`${process.env.API_URL}/student`,
      {
        method: 'POST',
        body: obj,
        headers: new Headers({
          'content-type': 'application/json',
          Authorization: tokenStr
        }),
      }).then((res) => {
        if (!res.ok) { throw new Error("unauthorized") }
        return res.json();
      })
      .then(
        (result) => {
          if (result.errors == null)
            toast("Öğrenci Kaydedildi");
          else
            toast.error(result.title);
        },
      ).catch(e => {
        toast.error("Yetkiniz yok")
       setHasError(true)
      })
      .finally(() => {
        handleCloseCreateModal()
        setIsLoaded(true)
      })
      setRefresh(refresh+1)
  }
  const handleUpdate = () => {
    var obj = JSON.stringify(item);
    fetch(`${process.env.API_URL}/student`,
      {
        method: 'PUT',
        body: obj,
        headers: new Headers({
          'content-type': 'application/json',
          Authorization: tokenStr
        }),
      })
      .then((res) => {
        if (!res.ok) { throw new Error("unauthorized") }
        return res.json();
      })
      .then(
        (result) => {
          if (result.errors == null)
            toast("Öğrenci Kaydedildi");
          else
            toast.error(result.title);
        }).catch((e) => {
          toast.error("Yetkiniz yok")
         setHasError(true)

        })
      .finally(f => {
        handleCloseUpdateModal()
        setItem({})
        setIsLoaded(true);
      }
      )
      setRefresh(refresh+1)
  }

  const handleDelete = () => {
    var obj = JSON.stringify(item)
    fetch(`${process.env.API_URL}/student`,
      {
        method: 'PUT',
        body: obj,
        headers: new Headers({
          'content-type': 'application/json',
          Authorization: tokenStr
        }),
      })
      .then((res) => {
        if (!res.ok) { throw new Error("unauthorized") }
        return res.json();
      })
      .then(
        (result) => {
          if (result.errors == null)
            notify("Öğrenci Silindi");
          else
            notify(result.title, "error");
        }).catch(e => {
          toast.error("Yetkiniz yok")
         setHasError(true)
        }).finally(f => {
          setItem({})
          handleCloseDeleteModal()
          setIsLoaded(true)
        })
        setRefresh(refresh+1)
  }

  return (
    <section className="content">
      <div className="container-fluid">
        <div className="row">
          <div className="col-12">
            {/* Create Modal */}
            <Modal show={isCreateModalOpen} onHide={handleOpenCreateModal}>
              <Modal.Header >
                <Modal.Title>Yeni Öğrenci</Modal.Title>
              </Modal.Header>
              <Modal.Body>
                <form onSubmit={(e) => handleSubmit(e)}>
                  <div className="card-body">
                    <div className="form-group">
                      <label htmlFor="exampleInputEmail1">İsim</label>
                      <input
                        type="text"
                        onChange={(inputsHandler)}
                        name='firstName'
                        value={inputField.firstName}
                        className="form-control"
                        id="exampleInputEmail1"
                        placeholder="İsim"
                      />
                    </div>
                    <div className="form-group">
                      <label htmlFor="exampleInputEmail1">Soyad</label>
                      <input
                        type="text"
                        onChange={inputsHandler}
                        name='lastName'
                        value={inputField.lastName}
                        className="form-control"
                        id="exampleInputEmail1"
                        placeholder="Soyad"
                      />
                    </div>
                    <div className="form-group">
                      <label htmlFor="exampleInputEmail1">Durum</label>
                      <textarea
                        type="text"
                        onChange={inputsHandler}
                        name='educationalStatus'
                        value={inputField.educationalStatus}
                        className="form-control"
                        id="exampleInputEmail1"
                        placeholder="Durum"
                      />
                    </div>
                  </div>

                </form>
              </Modal.Body>
              <Modal.Footer>
                <Button variant="secondary" onClick={handleCloseCreateModal}>
                  Kapat
                </Button>
                <Button variant="primary" onClick={handleSubmit}>
                  Ekle
                </Button>
              </Modal.Footer>
            </Modal>
            {/* Update Modal */}
            <Modal show={isUpdateModalOpen} onHide={handleOpenUpdateModal}>
              <Modal.Header >
                <Modal.Title>Öğrenci Güncelle</Modal.Title>
              </Modal.Header>
              <Modal.Body>
                <form>
                  <div className="card-body">
                    <div className="form-group">
                      <label htmlFor="exampleInputEmail1">İsim</label>
                      <input
                        type="text"
                        name='firstName'
                        onChange={itemHandler}
                        value={item.firstName}
                        className="form-control"
                        id="exampleInputEmail1"
                        placeholder="İsim"
                      />
                    </div>
                    <div className="form-group">
                      <label htmlFor="exampleInputEmail1">Soyad</label>
                      <input
                        type="text"
                        name='lastName'
                        onChange={itemHandler}
                        value={item.lastName}
                        className="form-control"
                        id="exampleInputEmail1"
                        placeholder="Soyad"
                      />
                    </div>
                    <div className="form-group">
                      <label htmlFor="exampleInputEmail1">Durum</label>
                      <textarea
                        type="text"
                        name='educationalStatus'
                        onChange={itemHandler}
                        value={item.educationalStatus}
                        className="form-control"
                        id="exampleInputEmail1"
                        placeholder="Durum"
                      />
                    </div>
                    <div className="form-check">
                      <input
                        type="checkbox"
                        name='isActive'
                        value={item.isActive}
                        onChange={itemHandler}
                        className="form-check-input"
                        placeholder="Aktif"

                        id="customSwitch3"
                        checked={item.isActive}
                        readOnly
                      />
                      <label className="form-check-label">
                        Aktif
                      </label>
                    </div>

                  </div>

                </form>
              </Modal.Body>
              <Modal.Footer>
                <Button variant="secondary" onClick={handleCloseUpdateModal}>
                  Kapat
                </Button>
                <Button variant="primary" onClick={handleUpdate}>
                  Güncelle
                </Button>
              </Modal.Footer>
            </Modal>
            {/* Delete Modal */}
            <Modal show={isDeleteModalOpen} onHide={handleCloseDeleteModal}>
              <Modal.Header >
                <Modal.Title><h5>Öğrenci silinecek,  onaylıyor musunuz?</h5></Modal.Title>
              </Modal.Header>
              <Modal.Footer>
                <Button variant="secondary" onClick={handleCloseDeleteModal}>
                  Kapat
                </Button>
                <Button variant="danger" onClick={handleDelete}>
                  Onayla
                </Button>
              </Modal.Footer>
            </Modal>
            <div className="modal show" >
              <div className="modal-dialog"  >
                <div className="modal-content">
                  <div className="modal-header">
                    <button type="button" className="close" data-dismiss="modal" aria-label="Close">
                      <span aria-hidden="true">&times;</span>
                    </button>
                  </div>
                  <div className="modal-footer justify-content-between">
                    <button type="button" className="btn btn-default" data-dismiss="modal">Kapat</button>
                    <button type="button" className="btn btn-danger">Onayla</button>
                  </div>
                </div>
              </div>
            </div>


            <div className="card">
              <div className="card-header " >
                <div className='d-flex justify-content-between'>
                  <h3 className="card-title">
                    students
                  </h3>
                  <button className='btn btn-sm btn-primary' onClick={handleOpenCreateModal}>Ekle</button>
                </div>
              </div>
              {/* /.card-header */}
              <div className="card-body">
                {
                  isLoaded ? <table id="example2" className="table table-bordered table-hover">
                    <thead>
                      <tr>
                        <th>İsim</th>
                        <th>Soyad</th>
                        <th>Durum</th>
                        <th>Kurslar</th>
                        <th>Aktiflik</th>
                        <th>Düzenle</th>
                        <th>Sil</th>
                      </tr>
                    </thead>
                    <tbody>
                      {
                        items.map((student, index) => {
                          return (
                            <tr key={index}>
                              <td><p style={{ whiteSpace: "nowrap" }}>{student.firstName}</p></td>
                              <td><p style={{ whiteSpace: "nowrap" }}>{student.lastName}</p></td>
                              <td><p style={{ whiteSpace: "nowrap" }}>{student.educationalStatus}</p></td>
                              <td>
                                <Link href={`/students/${student.id}`}
                                ><i className="fas fa-book-open"></i></Link>
                              </td>
                              <td>
                                <div className="form-group">
                                  <div className="custom-control custom-switch custom-switch-off-danger custom-switch-on-success">
                                    <input
                                      type="checkbox"
                                      className="custom-control-input"
                                      id="customSwitch3"
                                      checked={student.isActive}
                                      readOnly
                                    />
                                    <label className="custom-control-label" htmlFor="customSwitch3">

                                    </label>
                                  </div>
                                </div>
                              </td>
                              <td>
                                <a className='text-warning'
                                  onClick={() => handleItem2Update(student)}
                                ><i className="fas fa-edit"></i></a>
                              </td>
                              <td>
                                <a
                                  onClick={() => handleItem2Delete(student)}
                                  className='text-danger' ><i className="fas fa-trash"></i></a>
                              </td>
                            </tr>
                          )
                        })
                      }

                    </tbody>
                    <tfoot>
                      <tr>
                        <th>İsim</th>
                        <th>Soyad</th>
                        <th>Durum</th>
                        <th>Kurslar</th>
                        <th>Aktiflik</th>
                        <th>Düzenle</th>
                        <th>Sil</th>
                      </tr>
                    </tfoot>
                  </table>
                    : <h4> Öğrenci bulunmadı, yeni birtane eklyin</h4>
                }

              </div>
              {/* /.card-body */}
            </div>
          </div>
          {/* /.col */}
        </div>
        {/* /.row */}
      </div>
    </section>


  )
}
