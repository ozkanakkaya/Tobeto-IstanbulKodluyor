import { ErrorMessage, Field, Form, Formik } from "formik";
import React from "react";
import { Button, FormField, Label } from "semantic-ui-react";
import * as Yup from "yup";
import KodlamaIoTextInput from "../utilities/customFormControls/KodlamaIoTextInput";

export default function ProductAdd() {
  const initialValues = { title: "", price: 10 };
  const shema = Yup.object({
    title: Yup.string().required("Ürün adı zorunludur."),
    price: Yup.number().required("Ürün fiyatı zorunludur."),
  });

  return (
    <Formik 
    initialValues={initialValues} 
    validationSchema={shema} 
    onSubmit={(values)=>{ console.log(values)}
    }>
      <Form className="ui form">
        <KodlamaIoTextInput name="title" placeholder="Ürün Adı"/>
        <KodlamaIoTextInput name="price" placeholder="Ürün Fiyatı"/>
        <Button color="green" type="submit">Ekle</Button>
      </Form>
    </Formik>
  );
}
