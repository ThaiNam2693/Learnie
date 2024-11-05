import React, { useState } from "react";
import Header from "../components/Header";
import Footer from "../components/Footer";
import Button from "@mui/material/Button";
import TextField from "@mui/material/TextField";
import Dialog from "@mui/material/Dialog";
import DialogActions from "@mui/material/DialogActions";
import DialogContent from "@mui/material/DialogContent";
import DialogContentText from "@mui/material/DialogContentText";
import DialogTitle from "@mui/material/DialogTitle";
import Question from "../components/Question";

const QuestionSet = () => {
  const [open, setOpen] = useState(false);
  const handleClickOpen = () => {
    setOpen(true);
  };

  const handleClose = () => {
    setOpen(false);
  };
  return (
    <div>
      <Header />
      <div className="">
        <div className="p-10">
          <button
            onClick={handleClickOpen}
            className="w-[150px] h-[30px] bg-[#704FE3] text-white flex items-center justify-center rounded-3xl font-newsreader hover:opacity-70"
          >
            New +
          </button>
          <div className="mt-5 grid grid-cols-5 gap-5">
            <Question/>
            <Question/>
            <Question/>
            <Question/>
            <Question/>
            <Question/>
            <Question/>
            <Question/>
            <Question/>
          </div>










          <Dialog open={open} onClose={handleClose}>
            <DialogTitle>Create Question Set</DialogTitle>
            <DialogContent>
              <TextField
                autoFocus
                required
                margin="dense"
                id="name"
                name="email"
                label="name"
                type="text"
                fullWidth
                variant="standard"
              />
            </DialogContent>
            <DialogActions>
              <Button onClick={handleClose}>Cancel</Button>
              <Button type="submit">Add</Button>
            </DialogActions>
          </Dialog>
        </div>
      </div>
    </div>
  );
};

export default QuestionSet;
